namespace GestionDeLivre
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Title = new System.Windows.Forms.Label();
            this.Author = new System.Windows.Forms.Label();
            this.ISBN = new System.Windows.Forms.Label();
            this.title_txt = new System.Windows.Forms.TextBox();
            this.author_txt = new System.Windows.Forms.TextBox();
            this.isbn_txt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Titre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Auteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.Title.Location = new System.Drawing.Point(32, 101);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(45, 22);
            this.Title.TabIndex = 0;
            this.Title.Text = "Title";
            this.Title.Click += new System.EventHandler(this.Title_Click);
            // 
            // Author
            // 
            this.Author.AutoSize = true;
            this.Author.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.Author.Location = new System.Drawing.Point(31, 138);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(63, 22);
            this.Author.TabIndex = 1;
            this.Author.Text = "Author";
            this.Author.Click += new System.EventHandler(this.label2_Click);
            // 
            // ISBN
            // 
            this.ISBN.AutoSize = true;
            this.ISBN.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISBN.Location = new System.Drawing.Point(33, 177);
            this.ISBN.Name = "ISBN";
            this.ISBN.Size = new System.Drawing.Size(50, 22);
            this.ISBN.TabIndex = 2;
            this.ISBN.Text = "ISBN";
            this.ISBN.Click += new System.EventHandler(this.ISBN_Click);
            // 
            // title_txt
            // 
            this.title_txt.Location = new System.Drawing.Point(101, 101);
            this.title_txt.Name = "title_txt";
            this.title_txt.Size = new System.Drawing.Size(124, 20);
            this.title_txt.TabIndex = 3;
            this.title_txt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // author_txt
            // 
            this.author_txt.Location = new System.Drawing.Point(101, 138);
            this.author_txt.Name = "author_txt";
            this.author_txt.Size = new System.Drawing.Size(124, 20);
            this.author_txt.TabIndex = 4;
            this.author_txt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // isbn_txt
            // 
            this.isbn_txt.Location = new System.Drawing.Point(101, 177);
            this.isbn_txt.Name = "isbn_txt";
            this.isbn_txt.Size = new System.Drawing.Size(124, 20);
            this.isbn_txt.TabIndex = 5;
            this.isbn_txt.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Titre,
            this.Auteur,
            this.id});
            this.dataGridView1.Location = new System.Drawing.Point(413, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(346, 325);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Titre
            // 
            this.Titre.HeaderText = "Title";
            this.Titre.Name = "Titre";
            // 
            // Auteur
            // 
            this.Auteur.HeaderText = "Author";
            this.Auteur.Name = "Auteur";
            // 
            // id
            // 
            this.id.HeaderText = "ISBN";
            this.id.Name = "id";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Green;
            this.button1.Location = new System.Drawing.Point(22, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold);
            this.delete.ForeColor = System.Drawing.Color.Red;
            this.delete.Location = new System.Drawing.Point(84, 283);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(97, 35);
            this.delete.TabIndex = 8;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold);
            this.update.Location = new System.Drawing.Point(139, 224);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(97, 35);
            this.update.TabIndex = 9;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(70, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Gestion De Livre";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 375);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.update);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.isbn_txt);
            this.Controls.Add(this.author_txt);
            this.Controls.Add(this.title_txt);
            this.Controls.Add(this.ISBN);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.Title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Author;
        private System.Windows.Forms.Label ISBN;
        private System.Windows.Forms.TextBox title_txt;
        private System.Windows.Forms.TextBox author_txt;
        private System.Windows.Forms.TextBox isbn_txt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Auteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
    }
}

