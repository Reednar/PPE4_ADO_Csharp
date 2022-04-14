
namespace PPE4_ADO_Csharp
{
    partial class FicheAdherent
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
            this.btn_Valider = new System.Windows.Forms.Button();
            this.btn_Annuler = new System.Windows.Forms.Button();
            this.tb_Prenom = new System.Windows.Forms.TextBox();
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            this.tb_Nom = new System.Windows.Forms.TextBox();
            this.tb_Num = new System.Windows.Forms.TextBox();
            this.label_Rue = new System.Windows.Forms.Label();
            this.label_Prenom = new System.Windows.Forms.Label();
            this.label_Nom = new System.Windows.Forms.Label();
            this.label_Num = new System.Windows.Forms.Label();
            this.tb_Rue = new System.Windows.Forms.TextBox();
            this.label_CP = new System.Windows.Forms.Label();
            this.tb_CP = new System.Windows.Forms.TextBox();
            this.tb_Ville = new System.Windows.Forms.TextBox();
            this.label_Ville = new System.Windows.Forms.Label();
            this.tb_Tel = new System.Windows.Forms.TextBox();
            this.label_Tel = new System.Windows.Forms.Label();
            this.tb_Mel = new System.Windows.Forms.TextBox();
            this.label_Mel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Valider
            // 
            this.btn_Valider.Location = new System.Drawing.Point(180, 373);
            this.btn_Valider.Name = "btn_Valider";
            this.btn_Valider.Size = new System.Drawing.Size(75, 23);
            this.btn_Valider.TabIndex = 19;
            this.btn_Valider.Text = "Valider";
            this.btn_Valider.UseVisualStyleBackColor = true;
            this.btn_Valider.Click += new System.EventHandler(this.btn_Valider_Click_1);
            // 
            // btn_Annuler
            // 
            this.btn_Annuler.Location = new System.Drawing.Point(39, 373);
            this.btn_Annuler.Name = "btn_Annuler";
            this.btn_Annuler.Size = new System.Drawing.Size(75, 23);
            this.btn_Annuler.TabIndex = 18;
            this.btn_Annuler.Text = "Annuler";
            this.btn_Annuler.UseVisualStyleBackColor = true;
            this.btn_Annuler.Click += new System.EventHandler(this.btn_Annuler_Click_1);
            // 
            // tb_Prenom
            // 
            this.tb_Prenom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "Prenom", true));
            this.tb_Prenom.Location = new System.Drawing.Point(122, 116);
            this.tb_Prenom.Name = "tb_Prenom";
            this.tb_Prenom.Size = new System.Drawing.Size(133, 20);
            this.tb_Prenom.TabIndex = 17;
            // 
            // bs
            // 
            this.bs.DataSource = typeof(PPE4_ADO_Csharp.Adherent);
            // 
            // tb_Nom
            // 
            this.tb_Nom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "Nom", true));
            this.tb_Nom.Location = new System.Drawing.Point(122, 72);
            this.tb_Nom.Name = "tb_Nom";
            this.tb_Nom.Size = new System.Drawing.Size(133, 20);
            this.tb_Nom.TabIndex = 16;
            // 
            // tb_Num
            // 
            this.tb_Num.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "Num", true));
            this.tb_Num.Enabled = false;
            this.tb_Num.Location = new System.Drawing.Point(122, 32);
            this.tb_Num.Name = "tb_Num";
            this.tb_Num.Size = new System.Drawing.Size(133, 20);
            this.tb_Num.TabIndex = 15;
            // 
            // label_Rue
            // 
            this.label_Rue.AutoSize = true;
            this.label_Rue.Location = new System.Drawing.Point(36, 166);
            this.label_Rue.Name = "label_Rue";
            this.label_Rue.Size = new System.Drawing.Size(27, 13);
            this.label_Rue.TabIndex = 14;
            this.label_Rue.Text = "Rue";
            // 
            // label_Prenom
            // 
            this.label_Prenom.AutoSize = true;
            this.label_Prenom.Location = new System.Drawing.Point(36, 116);
            this.label_Prenom.Name = "label_Prenom";
            this.label_Prenom.Size = new System.Drawing.Size(43, 13);
            this.label_Prenom.TabIndex = 13;
            this.label_Prenom.Text = "Prénom";
            // 
            // label_Nom
            // 
            this.label_Nom.AutoSize = true;
            this.label_Nom.Location = new System.Drawing.Point(36, 72);
            this.label_Nom.Name = "label_Nom";
            this.label_Nom.Size = new System.Drawing.Size(29, 13);
            this.label_Nom.TabIndex = 12;
            this.label_Nom.Text = "Nom";
            // 
            // label_Num
            // 
            this.label_Num.AutoSize = true;
            this.label_Num.Location = new System.Drawing.Point(36, 32);
            this.label_Num.Name = "label_Num";
            this.label_Num.Size = new System.Drawing.Size(44, 13);
            this.label_Num.TabIndex = 11;
            this.label_Num.Text = "Numéro";
            // 
            // tb_Rue
            // 
            this.tb_Rue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "AdrRue", true));
            this.tb_Rue.Location = new System.Drawing.Point(122, 166);
            this.tb_Rue.Name = "tb_Rue";
            this.tb_Rue.Size = new System.Drawing.Size(133, 20);
            this.tb_Rue.TabIndex = 20;
            // 
            // label_CP
            // 
            this.label_CP.AutoSize = true;
            this.label_CP.Location = new System.Drawing.Point(16, 211);
            this.label_CP.Name = "label_CP";
            this.label_CP.Size = new System.Drawing.Size(64, 13);
            this.label_CP.TabIndex = 21;
            this.label_CP.Text = "Code Postal";
            // 
            // tb_CP
            // 
            this.tb_CP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "AdrCP", true));
            this.tb_CP.Location = new System.Drawing.Point(122, 208);
            this.tb_CP.Name = "tb_CP";
            this.tb_CP.Size = new System.Drawing.Size(133, 20);
            this.tb_CP.TabIndex = 22;
            // 
            // tb_Ville
            // 
            this.tb_Ville.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "AdrVille", true));
            this.tb_Ville.Location = new System.Drawing.Point(122, 247);
            this.tb_Ville.Name = "tb_Ville";
            this.tb_Ville.Size = new System.Drawing.Size(133, 20);
            this.tb_Ville.TabIndex = 24;
            // 
            // label_Ville
            // 
            this.label_Ville.AutoSize = true;
            this.label_Ville.Location = new System.Drawing.Point(36, 250);
            this.label_Ville.Name = "label_Ville";
            this.label_Ville.Size = new System.Drawing.Size(26, 13);
            this.label_Ville.TabIndex = 23;
            this.label_Ville.Text = "Ville";
            // 
            // tb_Tel
            // 
            this.tb_Tel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "Tel", true));
            this.tb_Tel.Location = new System.Drawing.Point(122, 286);
            this.tb_Tel.Name = "tb_Tel";
            this.tb_Tel.Size = new System.Drawing.Size(133, 20);
            this.tb_Tel.TabIndex = 26;
            // 
            // label_Tel
            // 
            this.label_Tel.AutoSize = true;
            this.label_Tel.Location = new System.Drawing.Point(22, 289);
            this.label_Tel.Name = "label_Tel";
            this.label_Tel.Size = new System.Drawing.Size(58, 13);
            this.label_Tel.TabIndex = 25;
            this.label_Tel.Text = "Téléphone";
            // 
            // tb_Mel
            // 
            this.tb_Mel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "Mel", true));
            this.tb_Mel.Location = new System.Drawing.Point(122, 324);
            this.tb_Mel.Name = "tb_Mel";
            this.tb_Mel.Size = new System.Drawing.Size(133, 20);
            this.tb_Mel.TabIndex = 28;
            // 
            // label_Mel
            // 
            this.label_Mel.AutoSize = true;
            this.label_Mel.Location = new System.Drawing.Point(30, 327);
            this.label_Mel.Name = "label_Mel";
            this.label_Mel.Size = new System.Drawing.Size(32, 13);
            this.label_Mel.TabIndex = 27;
            this.label_Mel.Text = "Email";
            // 
            // FicheAdherent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 423);
            this.Controls.Add(this.tb_Mel);
            this.Controls.Add(this.label_Mel);
            this.Controls.Add(this.tb_Tel);
            this.Controls.Add(this.label_Tel);
            this.Controls.Add(this.tb_Ville);
            this.Controls.Add(this.label_Ville);
            this.Controls.Add(this.tb_CP);
            this.Controls.Add(this.label_CP);
            this.Controls.Add(this.tb_Rue);
            this.Controls.Add(this.btn_Valider);
            this.Controls.Add(this.btn_Annuler);
            this.Controls.Add(this.tb_Prenom);
            this.Controls.Add(this.tb_Nom);
            this.Controls.Add(this.tb_Num);
            this.Controls.Add(this.label_Rue);
            this.Controls.Add(this.label_Prenom);
            this.Controls.Add(this.label_Nom);
            this.Controls.Add(this.label_Num);
            this.MaximizeBox = false;
            this.Name = "FicheAdherent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FicheAdherent";
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Valider;
        private System.Windows.Forms.Button btn_Annuler;
        private System.Windows.Forms.TextBox tb_Prenom;
        private System.Windows.Forms.TextBox tb_Nom;
        private System.Windows.Forms.TextBox tb_Num;
        private System.Windows.Forms.Label label_Rue;
        private System.Windows.Forms.Label label_Prenom;
        private System.Windows.Forms.Label label_Nom;
        private System.Windows.Forms.Label label_Num;
        private System.Windows.Forms.TextBox tb_Rue;
        private System.Windows.Forms.Label label_CP;
        private System.Windows.Forms.TextBox tb_CP;
        private System.Windows.Forms.TextBox tb_Ville;
        private System.Windows.Forms.Label label_Ville;
        private System.Windows.Forms.TextBox tb_Tel;
        private System.Windows.Forms.Label label_Tel;
        private System.Windows.Forms.TextBox tb_Mel;
        private System.Windows.Forms.Label label_Mel;
        private System.Windows.Forms.BindingSource bs;
    }
}