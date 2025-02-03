namespace dbIAGE
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dataGridView2 = new DataGridView();
            btnAddCategorie = new Button();
            txtLibelleCategorie = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            btnAddProduct = new Button();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            textBox2 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(799, 451);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(dataGridView2);
            tabPage1.Controls.Add(btnAddCategorie);
            tabPage1.Controls.Add(txtLibelleCategorie);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(791, 423);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(245, 21);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(539, 378);
            dataGridView2.TabIndex = 3;
            // 
            // btnAddCategorie
            // 
            btnAddCategorie.Location = new Point(44, 154);
            btnAddCategorie.Name = "btnAddCategorie";
            btnAddCategorie.Size = new Size(101, 31);
            btnAddCategorie.TabIndex = 2;
            btnAddCategorie.Text = "Enregistrer";
            btnAddCategorie.UseVisualStyleBackColor = true;
            btnAddCategorie.Click += btnAddCategorie_Click;
            // 
            // txtLibelleCategorie
            // 
            txtLibelleCategorie.Location = new Point(8, 60);
            txtLibelleCategorie.Multiline = true;
            txtLibelleCategorie.Name = "txtLibelleCategorie";
            txtLibelleCategorie.Size = new Size(150, 35);
            txtLibelleCategorie.TabIndex = 1;
            txtLibelleCategorie.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 30);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 0;
            label1.Text = "Libelle";
            label1.Click += label1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button4);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(btnAddProduct);
            tabPage2.Controls.Add(textBox4);
            tabPage2.Controls.Add(textBox3);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(label2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(791, 423);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(8, 324);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(95, 31);
            btnAddProduct.TabIndex = 7;
            btnAddProduct.Text = "Enregistrer";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(22, 157);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(170, 40);
            textBox4.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(8, 263);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(184, 40);
            textBox3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 215);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 4;
            label4.Text = "Categorie";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 125);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 3;
            label3.Text = "Price";
            label3.Click += label3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(236, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(535, 377);
            dataGridView1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(23, 65);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(169, 40);
            textBox2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 35);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 0;
            label2.Text = "Libelle";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(8, 210);
            button1.Name = "button1";
            button1.Size = new Size(101, 31);
            button1.TabIndex = 4;
            button1.Text = "Modifier";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(124, 210);
            button2.Name = "button2";
            button2.Size = new Size(101, 31);
            button2.TabIndex = 5;
            button2.Text = "Supprimer";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(118, 324);
            button3.Name = "button3";
            button3.Size = new Size(101, 31);
            button3.TabIndex = 8;
            button3.Text = "Modifier";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(70, 368);
            button4.Name = "button4";
            button4.Size = new Size(101, 31);
            button4.TabIndex = 9;
            button4.Text = "Supprimer";
            button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnAddCategorie;
        private TextBox txtLibelleCategorie;
        private Label label1;
        private DataGridView dataGridView2;
        private DataGridView dataGridView1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label4;
        private Button btnAddProduct;
        private Button button2;
        private Button button1;
        private Button button4;
        private Button button3;
    }
}
