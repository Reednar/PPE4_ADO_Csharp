
namespace PPE4_ADO_Csharp
{
    partial class FicheAuteur
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
            this.label_Num = new System.Windows.Forms.Label();
            this.label_Nom = new System.Windows.Forms.Label();
            this.label_Prenom = new System.Windows.Forms.Label();
            this.label_Nation = new System.Windows.Forms.Label();
            this.tb_Num = new System.Windows.Forms.TextBox();
            this.tb_Nom = new System.Windows.Forms.TextBox();
            this.tb_Prenom = new System.Windows.Forms.TextBox();
            this.btn_Annuler = new System.Windows.Forms.Button();
            this.btn_Valider = new System.Windows.Forms.Button();
            this.cb_Nation = new System.Windows.Forms.ComboBox();
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Num
            // 
            this.label_Num.AutoSize = true;
            this.label_Num.Location = new System.Drawing.Point(36, 30);
            this.label_Num.Name = "label_Num";
            this.label_Num.Size = new System.Drawing.Size(44, 13);
            this.label_Num.TabIndex = 0;
            this.label_Num.Text = "Numéro";
            // 
            // label_Nom
            // 
            this.label_Nom.AutoSize = true;
            this.label_Nom.Location = new System.Drawing.Point(36, 70);
            this.label_Nom.Name = "label_Nom";
            this.label_Nom.Size = new System.Drawing.Size(29, 13);
            this.label_Nom.TabIndex = 1;
            this.label_Nom.Text = "Nom";
            // 
            // label_Prenom
            // 
            this.label_Prenom.AutoSize = true;
            this.label_Prenom.Location = new System.Drawing.Point(36, 114);
            this.label_Prenom.Name = "label_Prenom";
            this.label_Prenom.Size = new System.Drawing.Size(43, 13);
            this.label_Prenom.TabIndex = 2;
            this.label_Prenom.Text = "Prénom";
            // 
            // label_Nation
            // 
            this.label_Nation.AutoSize = true;
            this.label_Nation.Location = new System.Drawing.Point(36, 164);
            this.label_Nation.Name = "label_Nation";
            this.label_Nation.Size = new System.Drawing.Size(57, 13);
            this.label_Nation.TabIndex = 3;
            this.label_Nation.Text = "Nationalité";
            // 
            // tb_Num
            // 
            this.tb_Num.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "Num", true));
            this.tb_Num.Enabled = false;
            this.tb_Num.Location = new System.Drawing.Point(122, 30);
            this.tb_Num.Name = "tb_Num";
            this.tb_Num.Size = new System.Drawing.Size(133, 20);
            this.tb_Num.TabIndex = 4;
            // 
            // tb_Nom
            // 
            this.tb_Nom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "Nom", true));
            this.tb_Nom.Location = new System.Drawing.Point(122, 70);
            this.tb_Nom.Name = "tb_Nom";
            this.tb_Nom.Size = new System.Drawing.Size(133, 20);
            this.tb_Nom.TabIndex = 5;
            // 
            // tb_Prenom
            // 
            this.tb_Prenom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "Prenom", true));
            this.tb_Prenom.Location = new System.Drawing.Point(122, 114);
            this.tb_Prenom.Name = "tb_Prenom";
            this.tb_Prenom.Size = new System.Drawing.Size(133, 20);
            this.tb_Prenom.TabIndex = 6;
            // 
            // btn_Annuler
            // 
            this.btn_Annuler.Location = new System.Drawing.Point(39, 209);
            this.btn_Annuler.Name = "btn_Annuler";
            this.btn_Annuler.Size = new System.Drawing.Size(75, 23);
            this.btn_Annuler.TabIndex = 8;
            this.btn_Annuler.Text = "Annuler";
            this.btn_Annuler.UseVisualStyleBackColor = true;
            this.btn_Annuler.Click += new System.EventHandler(this.btn_Annuler_Click);
            // 
            // btn_Valider
            // 
            this.btn_Valider.Location = new System.Drawing.Point(180, 209);
            this.btn_Valider.Name = "btn_Valider";
            this.btn_Valider.Size = new System.Drawing.Size(75, 23);
            this.btn_Valider.TabIndex = 9;
            this.btn_Valider.Text = "Valider";
            this.btn_Valider.UseVisualStyleBackColor = true;
            this.btn_Valider.Click += new System.EventHandler(this.btn_Valider_Click);
            // 
            // cb_Nation
            // 
            this.cb_Nation.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "Nationalite", true));
            this.cb_Nation.FormattingEnabled = true;
            this.cb_Nation.Location = new System.Drawing.Point(122, 164);
            this.cb_Nation.Name = "cb_Nation";
            this.cb_Nation.Size = new System.Drawing.Size(133, 21);
            this.cb_Nation.TabIndex = 10;
            // 
            // bs
            // 
            this.bs.DataSource = typeof(PPE4_ADO_Csharp.Auteur);
            // 
            // FicheAuteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 264);
            this.Controls.Add(this.cb_Nation);
            this.Controls.Add(this.btn_Valider);
            this.Controls.Add(this.btn_Annuler);
            this.Controls.Add(this.tb_Prenom);
            this.Controls.Add(this.tb_Nom);
            this.Controls.Add(this.tb_Num);
            this.Controls.Add(this.label_Nation);
            this.Controls.Add(this.label_Prenom);
            this.Controls.Add(this.label_Nom);
            this.Controls.Add(this.label_Num);
            this.MaximizeBox = false;
            this.Name = "FicheAuteur";
            this.Text = "FicheAuteur";
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Num;
        private System.Windows.Forms.Label label_Nom;
        private System.Windows.Forms.Label label_Prenom;
        private System.Windows.Forms.Label label_Nation;
        private System.Windows.Forms.TextBox tb_Num;
        private System.Windows.Forms.TextBox tb_Nom;
        private System.Windows.Forms.TextBox tb_Prenom;
        private System.Windows.Forms.Button btn_Annuler;
        private System.Windows.Forms.Button btn_Valider;
        private System.Windows.Forms.ComboBox cb_Nation;
        private System.Windows.Forms.BindingSource bs;
    }
}