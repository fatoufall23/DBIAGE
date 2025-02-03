using System.ComponentModel;
using System.Windows.Forms;

namespace dbIAGE
{
    public partial class Form1 : Form
    {
        dbiagetabpanEntities db;
        public object CategorieIdselected { get; private set; }
        public object ProductIdselected { get; private set; }

        public Form1()
        {
            InitializeComponent();
            tabPage1.Text = "Categorie";
            tabPage2.Text = "Produit";
            db = new dbiagetabpanEntities();
        }

        private void
            label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refresh();
            cbCategorie.DataSource = db.Categories.ToList();
            cbCategorie.DisplayMember = "Name";
            cbCategorie.ValueMember = "CategoryId";
            btnUpdateCategories.Enabled = false;
            btnsupprimerCategorie.Enabled = false;
            btnSupprimer.Enabled = false;
            btnModifier.Enabled = false;
        }

        private void btnCategorie_Click(object sender, EventArgs e)
        {
            Categories categories = new Categories();
            categories.Name = txtLibelle.Text;
            db.Categories.Add(categories);
            db.SaveChanges();
            MessageBox.Show("donnee inserer");
            refresh();
            btnsupprimerCategorie.Enabled = true;
            btnUpdateCategories.Enabled = true;
        }
        private void refresh()
        {
            dataGridView1Categorie.DataSource = db.Categories.Select(c => new { Id = c.CategoryId, Libelle = c.Name }).ToList();
            dataGridView1Produit.DataSource = db.Products.Select(p => new {
                Id = p.ProductId,
                Libelle = p.Name,
                Prix = p.Price,
                Cate
            = p.Categories.Name
            }).ToList();
        }

        private void dataGridView1Categorie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                CategorieIdselected = dataGridView1Categorie.Rows[e.RowIndex].Cells["Id"].Value;
                txtLibelle.Text = dataGridView1Categorie.Rows[e.RowIndex].Cells["Libelle"].Value.ToString();
            }
        }

        private void btnEnregistrerProduit_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            products.Price = float.Parse(txtPrice.Text);
            var selected = (Categories)cbCategorie.SelectedItem;
            products.Categories = db.Categories.FirstOrDefault(c => c.CategoryId == selected.CategoryId);
            products.CategorieId = selected.CategoryId;
            db.Products.Add(products);
            int result = db.SaveChanges();
            if (result > 0)
            {
                MessageBox.Show("donnees inserer");
                Refresh();
                btnModifier.Enabled = true;
                btnSupprimer.Enabled = true;
            }
            else
            {
                MessageBox.Show("verifier les donnees");
            }
        }

        private void txtPrice_Validating(object sender, CancelEventArgs e)
        {
            if (int.TryParse(txtPrice.Text, out int prix))
            {
                if (prix < 0)
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtPrice, "valeur doit etre superieur a 0");

                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(txtPrice, "");
                }
            }
            else
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPrice, "valeur non valide");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CategorieIdselected == null)
            {
                MessageBox.Show("Veuillez sélectionner une catégorie.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Voulez-vous vraiment confirmer la suppression ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                int categoryId;
                if (int.TryParse(CategorieIdselected.ToString(), out categoryId))
                {

                    var categorie = db.Categories.FirstOrDefault(c => c.CategoryId == categoryId);

                    if (categorie != null)
                    {
                        db.Categories.Remove(categorie);
                        db.SaveChanges();
                        MessageBox.Show("Catégorie supprimée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        refresh();
                    }
                    else
                    {
                        MessageBox.Show("La catégorie sélectionnée n'existe pas.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Erreur : ID de la catégorie invalide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1Produit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ProductIdselected = dataGridView1Produit.Rows[e.RowIndex].Cells["Id"].Value;
                txtLibelle.Text = dataGridView1Produit.Rows[e.RowIndex].Cells["Libelle"].Value.ToString();
                txtPrice.Text = dataGridView1Produit.Rows[e.RowIndex].Cells["Price"].Value.ToString();
            }
        }

        private void btnUpdateCategories_Click(object sender, EventArgs e)
        {
            if (CategorieIdselected == null)
            {
                MessageBox.Show("Veuillez sélectionner une catégorie à modifier.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (int.TryParse(CategorieIdselected.ToString(), out int categoryId))
            {

                var categorie = db.Categories.FirstOrDefault(c => c.CategoryId == categoryId);

                if (categorie != null)
                {
                    categorie.Name = txtLibelle.Text;
                    db.SaveChanges();

                    MessageBox.Show("Catégorie mise à jour avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh();
                }
                else
                {
                    MessageBox.Show("Catégorie introuvable.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (ProductIdselected == null)
            {
                MessageBox.Show("Veuillez sélectionner un produit.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Voulez-vous vraiment confirmer la suppression ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes && int.TryParse(ProductIdselected.ToString(), out int productId))
            {
                var produit = db.Products.FirstOrDefault(p => p.ProductId == productId);
                if (produit != null)
                {
                    db.Products.Remove(produit);
                    db.SaveChanges();

                    MessageBox.Show("Produit supprimé avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh();
                }
                else
                {
                    MessageBox.Show("Le produit sélectionné n'existe pas.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
