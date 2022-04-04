
namespace PPE4_ADO_Csharp
{
    partial class FicheLivre
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
            this.components = new System.ComponentModel.Container();
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            this.btn_Valider = new System.Windows.Forms.Button();
            this.btn_Annuler = new System.Windows.Forms.Button();
            this.tb_Titre = new System.Windows.Forms.TextBox();
            this.tb_Isbn = new System.Windows.Forms.TextBox();
            this.tb_Num = new System.Windows.Forms.TextBox();
            this.label_Prix = new System.Windows.Forms.Label();
            this.label_Titre = new System.Windows.Forms.Label();
            this.label_Isbn = new System.Windows.Forms.Label();
            this.label_Num = new System.Windows.Forms.Label();
            this.tb_Prix = new System.Windows.Forms.TextBox();
            this.tb_Editeur = new System.Windows.Forms.TextBox();
            this.label_Editeur = new System.Windows.Forms.Label();
            this.tb_Annee = new System.Windows.Forms.TextBox();
            this.label_Annee = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_Langue = new System.Windows.Forms.Label();
            this.label_Auteur = new System.Windows.Forms.Label();
            this.label_Genre = new System.Windows.Forms.Label();
            this.cb_Auteur = new System.Windows.Forms.ComboBox();
            this.cb_Genre = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Valider
            // 
            this.btn_Valider.Location = new System.Drawing.Point(181, 463);
            this.btn_Valider.Name = "btn_Valider";
            this.btn_Valider.Size = new System.Drawing.Size(75, 23);
            this.btn_Valider.TabIndex = 19;
            this.btn_Valider.Text = "Valider";
            this.btn_Valider.UseVisualStyleBackColor = true;
            // 
            // btn_Annuler
            // 
            this.btn_Annuler.Location = new System.Drawing.Point(40, 463);
            this.btn_Annuler.Name = "btn_Annuler";
            this.btn_Annuler.Size = new System.Drawing.Size(75, 23);
            this.btn_Annuler.TabIndex = 18;
            this.btn_Annuler.Text = "Annuler";
            this.btn_Annuler.UseVisualStyleBackColor = true;
            // 
            // tb_Titre
            // 
            this.tb_Titre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "Prenom", true));
            this.tb_Titre.Location = new System.Drawing.Point(123, 122);
            this.tb_Titre.Name = "tb_Titre";
            this.tb_Titre.Size = new System.Drawing.Size(133, 20);
            this.tb_Titre.TabIndex = 17;
            // 
            // tb_Isbn
            // 
            this.tb_Isbn.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "Nom", true));
            this.tb_Isbn.Location = new System.Drawing.Point(123, 78);
            this.tb_Isbn.Name = "tb_Isbn";
            this.tb_Isbn.Size = new System.Drawing.Size(133, 20);
            this.tb_Isbn.TabIndex = 16;
            // 
            // tb_Num
            // 
            this.tb_Num.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "Num", true));
            this.tb_Num.Enabled = false;
            this.tb_Num.Location = new System.Drawing.Point(123, 38);
            this.tb_Num.Name = "tb_Num";
            this.tb_Num.Size = new System.Drawing.Size(133, 20);
            this.tb_Num.TabIndex = 15;
            // 
            // label_Prix
            // 
            this.label_Prix.AutoSize = true;
            this.label_Prix.Location = new System.Drawing.Point(37, 172);
            this.label_Prix.Name = "label_Prix";
            this.label_Prix.Size = new System.Drawing.Size(24, 13);
            this.label_Prix.TabIndex = 14;
            this.label_Prix.Text = "Prix";
            // 
            // label_Titre
            // 
            this.label_Titre.AutoSize = true;
            this.label_Titre.Location = new System.Drawing.Point(37, 122);
            this.label_Titre.Name = "label_Titre";
            this.label_Titre.Size = new System.Drawing.Size(28, 13);
            this.label_Titre.TabIndex = 13;
            this.label_Titre.Text = "Titre";
            // 
            // label_Isbn
            // 
            this.label_Isbn.AutoSize = true;
            this.label_Isbn.Location = new System.Drawing.Point(37, 78);
            this.label_Isbn.Name = "label_Isbn";
            this.label_Isbn.Size = new System.Drawing.Size(32, 13);
            this.label_Isbn.TabIndex = 12;
            this.label_Isbn.Text = "ISBN";
            // 
            // label_Num
            // 
            this.label_Num.AutoSize = true;
            this.label_Num.Location = new System.Drawing.Point(37, 38);
            this.label_Num.Name = "label_Num";
            this.label_Num.Size = new System.Drawing.Size(44, 13);
            this.label_Num.TabIndex = 11;
            this.label_Num.Text = "Numéro";
            // 
            // tb_Prix
            // 
            this.tb_Prix.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "Prenom", true));
            this.tb_Prix.Location = new System.Drawing.Point(123, 172);
            this.tb_Prix.Name = "tb_Prix";
            this.tb_Prix.Size = new System.Drawing.Size(133, 20);
            this.tb_Prix.TabIndex = 20;
            // 
            // tb_Editeur
            // 
            this.tb_Editeur.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "Prenom", true));
            this.tb_Editeur.Location = new System.Drawing.Point(123, 216);
            this.tb_Editeur.Name = "tb_Editeur";
            this.tb_Editeur.Size = new System.Drawing.Size(133, 20);
            this.tb_Editeur.TabIndex = 22;
            // 
            // label_Editeur
            // 
            this.label_Editeur.AutoSize = true;
            this.label_Editeur.Location = new System.Drawing.Point(37, 216);
            this.label_Editeur.Name = "label_Editeur";
            this.label_Editeur.Size = new System.Drawing.Size(40, 13);
            this.label_Editeur.TabIndex = 21;
            this.label_Editeur.Text = "Editeur";
            // 
            // tb_Annee
            // 
            this.tb_Annee.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "Prenom", true));
            this.tb_Annee.Location = new System.Drawing.Point(123, 270);
            this.tb_Annee.Name = "tb_Annee";
            this.tb_Annee.Size = new System.Drawing.Size(133, 20);
            this.tb_Annee.TabIndex = 24;
            // 
            // label_Annee
            // 
            this.label_Annee.AutoSize = true;
            this.label_Annee.Location = new System.Drawing.Point(37, 270);
            this.label_Annee.Name = "label_Annee";
            this.label_Annee.Size = new System.Drawing.Size(38, 13);
            this.label_Annee.TabIndex = 23;
            this.label_Annee.Text = "Année";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "Prenom", true));
            this.textBox1.Location = new System.Drawing.Point(123, 320);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 20);
            this.textBox1.TabIndex = 26;
            // 
            // label_Langue
            // 
            this.label_Langue.AutoSize = true;
            this.label_Langue.Location = new System.Drawing.Point(37, 320);
            this.label_Langue.Name = "label_Langue";
            this.label_Langue.Size = new System.Drawing.Size(43, 13);
            this.label_Langue.TabIndex = 25;
            this.label_Langue.Text = "Langue";
            // 
            // label_Auteur
            // 
            this.label_Auteur.AutoSize = true;
            this.label_Auteur.Location = new System.Drawing.Point(37, 366);
            this.label_Auteur.Name = "label_Auteur";
            this.label_Auteur.Size = new System.Drawing.Size(38, 13);
            this.label_Auteur.TabIndex = 27;
            this.label_Auteur.Text = "Auteur";
            // 
            // label_Genre
            // 
            this.label_Genre.AutoSize = true;
            this.label_Genre.Location = new System.Drawing.Point(37, 417);
            this.label_Genre.Name = "label_Genre";
            this.label_Genre.Size = new System.Drawing.Size(36, 13);
            this.label_Genre.TabIndex = 29;
            this.label_Genre.Text = "Genre";
            // 
            // cb_Auteur
            // 
            this.cb_Auteur.FormattingEnabled = true;
            this.cb_Auteur.Location = new System.Drawing.Point(123, 366);
            this.cb_Auteur.Name = "cb_Auteur";
            this.cb_Auteur.Size = new System.Drawing.Size(133, 21);
            this.cb_Auteur.TabIndex = 30;
            // 
            // cb_Genre
            // 
            this.cb_Genre.FormattingEnabled = true;
            this.cb_Genre.Location = new System.Drawing.Point(123, 417);
            this.cb_Genre.Name = "cb_Genre";
            this.cb_Genre.Size = new System.Drawing.Size(133, 21);
            this.cb_Genre.TabIndex = 31;
            // 
            // FicheLivre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 498);
            this.Controls.Add(this.cb_Genre);
            this.Controls.Add(this.cb_Auteur);
            this.Controls.Add(this.label_Genre);
            this.Controls.Add(this.label_Auteur);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_Langue);
            this.Controls.Add(this.tb_Annee);
            this.Controls.Add(this.label_Annee);
            this.Controls.Add(this.tb_Editeur);
            this.Controls.Add(this.label_Editeur);
            this.Controls.Add(this.tb_Prix);
            this.Controls.Add(this.btn_Valider);
            this.Controls.Add(this.btn_Annuler);
            this.Controls.Add(this.tb_Titre);
            this.Controls.Add(this.tb_Isbn);
            this.Controls.Add(this.tb_Num);
            this.Controls.Add(this.label_Prix);
            this.Controls.Add(this.label_Titre);
            this.Controls.Add(this.label_Isbn);
            this.Controls.Add(this.label_Num);
            this.Name = "FicheLivre";
            this.Text = "FicheLivre";
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bs;
        private System.Windows.Forms.Button btn_Valider;
        private System.Windows.Forms.Button btn_Annuler;
        private System.Windows.Forms.TextBox tb_Titre;
        private System.Windows.Forms.TextBox tb_Isbn;
        private System.Windows.Forms.TextBox tb_Num;
        private System.Windows.Forms.Label label_Prix;
        private System.Windows.Forms.Label label_Titre;
        private System.Windows.Forms.Label label_Isbn;
        private System.Windows.Forms.Label label_Num;
        private System.Windows.Forms.TextBox tb_Prix;
        private System.Windows.Forms.TextBox tb_Editeur;
        private System.Windows.Forms.Label label_Editeur;
        private System.Windows.Forms.TextBox tb_Annee;
        private System.Windows.Forms.Label label_Annee;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_Langue;
        private System.Windows.Forms.Label label_Auteur;
        private System.Windows.Forms.Label label_Genre;
        private System.Windows.Forms.ComboBox cb_Auteur;
        private System.Windows.Forms.ComboBox cb_Genre;
    }
}