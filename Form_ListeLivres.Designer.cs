
namespace PPE4_ADO_Csharp
{
    partial class Form_ListeLivres
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
            this.dgv_ListeLivres = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            this.numDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editeurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anneeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.langueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unAuteurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unGenreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListeLivres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Ajouter
            // 
            this.btn_Ajouter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Ajouter.Location = new System.Drawing.Point(990, 182);
            this.btn_Ajouter.Name = "btn_Ajouter";
            this.btn_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.btn_Ajouter.TabIndex = 14;
            this.btn_Ajouter.Text = "Ajouter";
            this.btn_Ajouter.UseVisualStyleBackColor = true;
            // 
            // btn_Supprimer
            // 
            this.btn_Supprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Supprimer.Location = new System.Drawing.Point(990, 130);
            this.btn_Supprimer.Name = "btn_Supprimer";
            this.btn_Supprimer.Size = new System.Drawing.Size(75, 23);
            this.btn_Supprimer.TabIndex = 13;
            this.btn_Supprimer.Text = "Supprimer";
            this.btn_Supprimer.UseVisualStyleBackColor = true;
            // 
            // btn_Modifier
            // 
            this.btn_Modifier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Modifier.Location = new System.Drawing.Point(990, 77);
            this.btn_Modifier.Name = "btn_Modifier";
            this.btn_Modifier.Size = new System.Drawing.Size(75, 23);
            this.btn_Modifier.TabIndex = 12;
            this.btn_Modifier.Text = "Modifier";
            this.btn_Modifier.UseVisualStyleBackColor = true;
            // 
            // btn_Afficher
            // 
            this.btn_Afficher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Afficher.Location = new System.Drawing.Point(990, 30);
            this.btn_Afficher.Name = "btn_Afficher";
            this.btn_Afficher.Size = new System.Drawing.Size(75, 23);
            this.btn_Afficher.TabIndex = 11;
            this.btn_Afficher.Text = "Afficher";
            this.btn_Afficher.UseVisualStyleBackColor = true;
            // 
            // dgv_ListeLivres
            // 
            this.dgv_ListeLivres.AllowUserToAddRows = false;
            this.dgv_ListeLivres.AllowUserToDeleteRows = false;
            this.dgv_ListeLivres.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ListeLivres.AutoGenerateColumns = false;
            this.dgv_ListeLivres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListeLivres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numDataGridViewTextBoxColumn,
            this.isbnDataGridViewTextBoxColumn,
            this.titreDataGridViewTextBoxColumn,
            this.prixDataGridViewTextBoxColumn,
            this.editeurDataGridViewTextBoxColumn,
            this.anneeDataGridViewTextBoxColumn,
            this.langueDataGridViewTextBoxColumn,
            this.unAuteurDataGridViewTextBoxColumn,
            this.unGenreDataGridViewTextBoxColumn});
            this.dgv_ListeLivres.DataSource = this.bs;
            this.dgv_ListeLivres.Location = new System.Drawing.Point(12, 4);
            this.dgv_ListeLivres.MultiSelect = false;
            this.dgv_ListeLivres.Name = "dgv_ListeLivres";
            this.dgv_ListeLivres.ReadOnly = true;
            this.dgv_ListeLivres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ListeLivres.Size = new System.Drawing.Size(917, 434);
            this.dgv_ListeLivres.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "UnAuteur";
            this.dataGridViewTextBoxColumn1.HeaderText = "Auteur";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "UnGenre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Genre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // bs
            // 
            this.bs.DataSource = typeof(PPE4_ADO_Csharp.Livre);
            // 
            // numDataGridViewTextBoxColumn
            // 
            this.numDataGridViewTextBoxColumn.DataPropertyName = "Num";
            this.numDataGridViewTextBoxColumn.HeaderText = "Num";
            this.numDataGridViewTextBoxColumn.Name = "numDataGridViewTextBoxColumn";
            this.numDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isbnDataGridViewTextBoxColumn
            // 
            this.isbnDataGridViewTextBoxColumn.DataPropertyName = "Isbn";
            this.isbnDataGridViewTextBoxColumn.HeaderText = "Isbn";
            this.isbnDataGridViewTextBoxColumn.Name = "isbnDataGridViewTextBoxColumn";
            this.isbnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titreDataGridViewTextBoxColumn
            // 
            this.titreDataGridViewTextBoxColumn.DataPropertyName = "Titre";
            this.titreDataGridViewTextBoxColumn.HeaderText = "Titre";
            this.titreDataGridViewTextBoxColumn.Name = "titreDataGridViewTextBoxColumn";
            this.titreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prixDataGridViewTextBoxColumn
            // 
            this.prixDataGridViewTextBoxColumn.DataPropertyName = "Prix";
            this.prixDataGridViewTextBoxColumn.HeaderText = "Prix";
            this.prixDataGridViewTextBoxColumn.Name = "prixDataGridViewTextBoxColumn";
            this.prixDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // editeurDataGridViewTextBoxColumn
            // 
            this.editeurDataGridViewTextBoxColumn.DataPropertyName = "Editeur";
            this.editeurDataGridViewTextBoxColumn.HeaderText = "Editeur";
            this.editeurDataGridViewTextBoxColumn.Name = "editeurDataGridViewTextBoxColumn";
            this.editeurDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // anneeDataGridViewTextBoxColumn
            // 
            this.anneeDataGridViewTextBoxColumn.DataPropertyName = "Annee";
            this.anneeDataGridViewTextBoxColumn.HeaderText = "Annee";
            this.anneeDataGridViewTextBoxColumn.Name = "anneeDataGridViewTextBoxColumn";
            this.anneeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // langueDataGridViewTextBoxColumn
            // 
            this.langueDataGridViewTextBoxColumn.DataPropertyName = "Langue";
            this.langueDataGridViewTextBoxColumn.HeaderText = "Langue";
            this.langueDataGridViewTextBoxColumn.Name = "langueDataGridViewTextBoxColumn";
            this.langueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unAuteurDataGridViewTextBoxColumn
            // 
            this.unAuteurDataGridViewTextBoxColumn.DataPropertyName = "UnAuteur";
            this.unAuteurDataGridViewTextBoxColumn.HeaderText = "UnAuteur";
            this.unAuteurDataGridViewTextBoxColumn.Name = "unAuteurDataGridViewTextBoxColumn";
            this.unAuteurDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unGenreDataGridViewTextBoxColumn
            // 
            this.unGenreDataGridViewTextBoxColumn.DataPropertyName = "UnGenre";
            this.unGenreDataGridViewTextBoxColumn.HeaderText = "UnGenre";
            this.unGenreDataGridViewTextBoxColumn.Name = "unGenreDataGridViewTextBoxColumn";
            this.unGenreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form_ListeLivres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 450);
            this.Controls.Add(this.btn_Ajouter);
            this.Controls.Add(this.btn_Supprimer);
            this.Controls.Add(this.btn_Modifier);
            this.Controls.Add(this.btn_Afficher);
            this.Controls.Add(this.dgv_ListeLivres);
            this.Name = "Form_ListeLivres";
            this.Text = "Form_ListeLivres";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListeLivres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Ajouter;
        private System.Windows.Forms.Button btn_Supprimer;
        private System.Windows.Forms.Button btn_Modifier;
        private System.Windows.Forms.Button btn_Afficher;
        private System.Windows.Forms.DataGridView dgv_ListeLivres;
        private System.Windows.Forms.BindingSource bs;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn numDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn editeurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anneeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn langueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unAuteurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unGenreDataGridViewTextBoxColumn;
    }
}