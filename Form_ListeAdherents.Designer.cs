
namespace PPE4_ADO_Csharp
{
    partial class Form_ListeAdherents
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
            this.btn_Ajouter = new System.Windows.Forms.Button();
            this.btn_Supprimer = new System.Windows.Forms.Button();
            this.btn_Modifier = new System.Windows.Forms.Button();
            this.btn_Afficher = new System.Windows.Forms.Button();
            this.dgv_ListeAdherents = new System.Windows.Forms.DataGridView();
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adrCP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adrVille = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListeAdherents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Ajouter
            // 
            this.btn_Ajouter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Ajouter.Location = new System.Drawing.Point(878, 184);
            this.btn_Ajouter.Name = "btn_Ajouter";
            this.btn_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.btn_Ajouter.TabIndex = 9;
            this.btn_Ajouter.Text = "Ajouter";
            this.btn_Ajouter.UseVisualStyleBackColor = true;
            this.btn_Ajouter.Click += new System.EventHandler(this.btn_Ajouter_Click);
            // 
            // btn_Supprimer
            // 
            this.btn_Supprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Supprimer.Location = new System.Drawing.Point(878, 132);
            this.btn_Supprimer.Name = "btn_Supprimer";
            this.btn_Supprimer.Size = new System.Drawing.Size(75, 23);
            this.btn_Supprimer.TabIndex = 8;
            this.btn_Supprimer.Text = "Supprimer";
            this.btn_Supprimer.UseVisualStyleBackColor = true;
            this.btn_Supprimer.Click += new System.EventHandler(this.btn_Supprimer_Click);
            // 
            // btn_Modifier
            // 
            this.btn_Modifier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Modifier.Location = new System.Drawing.Point(878, 79);
            this.btn_Modifier.Name = "btn_Modifier";
            this.btn_Modifier.Size = new System.Drawing.Size(75, 23);
            this.btn_Modifier.TabIndex = 7;
            this.btn_Modifier.Text = "Modifier";
            this.btn_Modifier.UseVisualStyleBackColor = true;
            this.btn_Modifier.Click += new System.EventHandler(this.btn_Modifier_Click);
            // 
            // btn_Afficher
            // 
            this.btn_Afficher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Afficher.Location = new System.Drawing.Point(878, 32);
            this.btn_Afficher.Name = "btn_Afficher";
            this.btn_Afficher.Size = new System.Drawing.Size(75, 23);
            this.btn_Afficher.TabIndex = 6;
            this.btn_Afficher.Text = "Afficher";
            this.btn_Afficher.UseVisualStyleBackColor = true;
            this.btn_Afficher.Click += new System.EventHandler(this.btn_Afficher_Click);
            // 
            // dgv_ListeAdherents
            // 
            this.dgv_ListeAdherents.AllowUserToAddRows = false;
            this.dgv_ListeAdherents.AllowUserToDeleteRows = false;
            this.dgv_ListeAdherents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ListeAdherents.AutoGenerateColumns = false;
            this.dgv_ListeAdherents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListeAdherents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num,
            this.Nom,
            this.Prenom,
            this.Rue,
            this.adrCP,
            this.adrVille,
            this.Tel,
            this.Mel});
            this.dgv_ListeAdherents.DataSource = this.bs;
            this.dgv_ListeAdherents.Location = new System.Drawing.Point(19, 8);
            this.dgv_ListeAdherents.MultiSelect = false;
            this.dgv_ListeAdherents.Name = "dgv_ListeAdherents";
            this.dgv_ListeAdherents.ReadOnly = true;
            this.dgv_ListeAdherents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ListeAdherents.Size = new System.Drawing.Size(804, 434);
            this.dgv_ListeAdherents.TabIndex = 5;
            // 
            // Num
            // 
            this.Num.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Num.DataPropertyName = "num";
            this.Num.FillWeight = 50F;
            this.Num.HeaderText = "Numéro";
            this.Num.Name = "Num";
            this.Num.ReadOnly = true;
            // 
            // Nom
            // 
            this.Nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nom.DataPropertyName = "nom";
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            // 
            // Prenom
            // 
            this.Prenom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Prenom.DataPropertyName = "prenom";
            this.Prenom.HeaderText = "Prénom";
            this.Prenom.Name = "Prenom";
            this.Prenom.ReadOnly = true;
            // 
            // Rue
            // 
            this.Rue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Rue.DataPropertyName = "adrRue";
            this.Rue.HeaderText = "Adresse";
            this.Rue.Name = "Rue";
            this.Rue.ReadOnly = true;
            // 
            // adrCP
            // 
            this.adrCP.DataPropertyName = "adrCP";
            this.adrCP.HeaderText = "Code Postal";
            this.adrCP.Name = "adrCP";
            this.adrCP.ReadOnly = true;
            // 
            // adrVille
            // 
            this.adrVille.DataPropertyName = "adrVille";
            this.adrVille.HeaderText = "Ville";
            this.adrVille.Name = "adrVille";
            this.adrVille.ReadOnly = true;
            // 
            // Tel
            // 
            this.Tel.DataPropertyName = "tel";
            this.Tel.HeaderText = "Téléphone";
            this.Tel.Name = "Tel";
            this.Tel.ReadOnly = true;
            // 
            // Mel
            // 
            this.Mel.DataPropertyName = "mel";
            this.Mel.HeaderText = "Email";
            this.Mel.Name = "Mel";
            this.Mel.ReadOnly = true;
            // 
            // Form_ListeAdherents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 450);
            this.Controls.Add(this.btn_Ajouter);
            this.Controls.Add(this.btn_Supprimer);
            this.Controls.Add(this.btn_Modifier);
            this.Controls.Add(this.btn_Afficher);
            this.Controls.Add(this.dgv_ListeAdherents);
            this.Name = "Form_ListeAdherents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liste des adherents";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListeAdherents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Ajouter;
        private System.Windows.Forms.Button btn_Supprimer;
        private System.Windows.Forms.Button btn_Modifier;
        private System.Windows.Forms.Button btn_Afficher;
        private System.Windows.Forms.DataGridView dgv_ListeAdherents;
        private System.Windows.Forms.BindingSource bs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rue;
        private System.Windows.Forms.DataGridViewTextBoxColumn adrCP;
        private System.Windows.Forms.DataGridViewTextBoxColumn adrVille;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mel;
    }
}