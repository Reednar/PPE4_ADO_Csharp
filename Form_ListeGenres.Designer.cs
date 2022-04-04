
namespace PPE4_ADO_Csharp
{
    partial class Form_ListeGenres
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
            this.btn_AjouterGenre = new System.Windows.Forms.Button();
            this.btn_SupprimerGenre = new System.Windows.Forms.Button();
            this.btn_ModifierGenre = new System.Windows.Forms.Button();
            this.btn_AfficherGenre = new System.Windows.Forms.Button();
            this.dgv_ListeGenres = new System.Windows.Forms.DataGridView();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Libelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListeGenres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_AjouterGenre
            // 
            this.btn_AjouterGenre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AjouterGenre.Location = new System.Drawing.Point(706, 177);
            this.btn_AjouterGenre.Name = "btn_AjouterGenre";
            this.btn_AjouterGenre.Size = new System.Drawing.Size(75, 23);
            this.btn_AjouterGenre.TabIndex = 9;
            this.btn_AjouterGenre.Text = "Ajouter";
            this.btn_AjouterGenre.UseVisualStyleBackColor = true;
            this.btn_AjouterGenre.Click += new System.EventHandler(this.btn_AjouterGenre_Click_1);
            // 
            // btn_SupprimerGenre
            // 
            this.btn_SupprimerGenre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SupprimerGenre.Location = new System.Drawing.Point(706, 125);
            this.btn_SupprimerGenre.Name = "btn_SupprimerGenre";
            this.btn_SupprimerGenre.Size = new System.Drawing.Size(75, 23);
            this.btn_SupprimerGenre.TabIndex = 8;
            this.btn_SupprimerGenre.Text = "Supprimer";
            this.btn_SupprimerGenre.UseVisualStyleBackColor = true;
            this.btn_SupprimerGenre.Click += new System.EventHandler(this.btn_SupprimerGenre_Click_1);
            // 
            // btn_ModifierGenre
            // 
            this.btn_ModifierGenre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ModifierGenre.Location = new System.Drawing.Point(706, 72);
            this.btn_ModifierGenre.Name = "btn_ModifierGenre";
            this.btn_ModifierGenre.Size = new System.Drawing.Size(75, 23);
            this.btn_ModifierGenre.TabIndex = 7;
            this.btn_ModifierGenre.Text = "Modifier";
            this.btn_ModifierGenre.UseVisualStyleBackColor = true;
            this.btn_ModifierGenre.Click += new System.EventHandler(this.btn_ModifierGenre_Click_1);
            // 
            // btn_AfficherGenre
            // 
            this.btn_AfficherGenre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AfficherGenre.Location = new System.Drawing.Point(706, 25);
            this.btn_AfficherGenre.Name = "btn_AfficherGenre";
            this.btn_AfficherGenre.Size = new System.Drawing.Size(75, 23);
            this.btn_AfficherGenre.TabIndex = 6;
            this.btn_AfficherGenre.Text = "Afficher";
            this.btn_AfficherGenre.UseVisualStyleBackColor = true;
            this.btn_AfficherGenre.Click += new System.EventHandler(this.btn_AfficherGenre_Click_1);
            // 
            // dgv_ListeGenres
            // 
            this.dgv_ListeGenres.AllowUserToAddRows = false;
            this.dgv_ListeGenres.AllowUserToDeleteRows = false;
            this.dgv_ListeGenres.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ListeGenres.AutoGenerateColumns = false;
            this.dgv_ListeGenres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListeGenres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num,
            this.Libelle});
            this.dgv_ListeGenres.DataSource = this.bs;
            this.dgv_ListeGenres.Location = new System.Drawing.Point(19, 8);
            this.dgv_ListeGenres.MultiSelect = false;
            this.dgv_ListeGenres.Name = "dgv_ListeGenres";
            this.dgv_ListeGenres.ReadOnly = true;
            this.dgv_ListeGenres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ListeGenres.Size = new System.Drawing.Size(561, 434);
            this.dgv_ListeGenres.TabIndex = 5;
            // 
            // Num
            // 
            this.Num.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Num.DataPropertyName = "num";
            this.Num.HeaderText = "Numéro";
            this.Num.Name = "Num";
            this.Num.ReadOnly = true;
            // 
            // Libelle
            // 
            this.Libelle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Libelle.DataPropertyName = "libelle";
            this.Libelle.HeaderText = "Libelle";
            this.Libelle.Name = "Libelle";
            this.Libelle.ReadOnly = true;
            // 
            // Form_ListeGenres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_AjouterGenre);
            this.Controls.Add(this.btn_SupprimerGenre);
            this.Controls.Add(this.btn_ModifierGenre);
            this.Controls.Add(this.btn_AfficherGenre);
            this.Controls.Add(this.dgv_ListeGenres);
            this.Name = "Form_ListeGenres";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liste des genres";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListeGenres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_AjouterGenre;
        private System.Windows.Forms.Button btn_SupprimerGenre;
        private System.Windows.Forms.Button btn_ModifierGenre;
        private System.Windows.Forms.Button btn_AfficherGenre;
        private System.Windows.Forms.DataGridView dgv_ListeGenres;
        private System.Windows.Forms.BindingSource bs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Libelle;
    }
}