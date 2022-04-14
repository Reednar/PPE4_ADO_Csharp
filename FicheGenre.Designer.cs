
namespace PPE4_ADO_Csharp
{
    partial class FicheGenre
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
            this.tb_Libelle = new System.Windows.Forms.TextBox();
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            this.tb_Num = new System.Windows.Forms.TextBox();
            this.label_Libelle = new System.Windows.Forms.Label();
            this.label_Num = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Valider
            // 
            this.btn_Valider.Location = new System.Drawing.Point(187, 111);
            this.btn_Valider.Name = "btn_Valider";
            this.btn_Valider.Size = new System.Drawing.Size(75, 23);
            this.btn_Valider.TabIndex = 19;
            this.btn_Valider.Text = "Valider";
            this.btn_Valider.UseVisualStyleBackColor = true;
            this.btn_Valider.Click += new System.EventHandler(this.btn_Valider_Click_1);
            // 
            // btn_Annuler
            // 
            this.btn_Annuler.Location = new System.Drawing.Point(46, 111);
            this.btn_Annuler.Name = "btn_Annuler";
            this.btn_Annuler.Size = new System.Drawing.Size(75, 23);
            this.btn_Annuler.TabIndex = 18;
            this.btn_Annuler.Text = "Annuler";
            this.btn_Annuler.UseVisualStyleBackColor = true;
            this.btn_Annuler.Click += new System.EventHandler(this.btn_Annuler_Click_1);
            // 
            // tb_Libelle
            // 
            this.tb_Libelle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "Libelle", true));
            this.tb_Libelle.Location = new System.Drawing.Point(129, 69);
            this.tb_Libelle.Name = "tb_Libelle";
            this.tb_Libelle.Size = new System.Drawing.Size(133, 20);
            this.tb_Libelle.TabIndex = 16;
            // 
            // bs
            // 
            this.bs.DataSource = typeof(PPE4_ADO_Csharp.Genre);
            // 
            // tb_Num
            // 
            this.tb_Num.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "Num", true));
            this.tb_Num.Enabled = false;
            this.tb_Num.Location = new System.Drawing.Point(129, 29);
            this.tb_Num.Name = "tb_Num";
            this.tb_Num.Size = new System.Drawing.Size(133, 20);
            this.tb_Num.TabIndex = 15;
            // 
            // label_Libelle
            // 
            this.label_Libelle.AutoSize = true;
            this.label_Libelle.Location = new System.Drawing.Point(43, 69);
            this.label_Libelle.Name = "label_Libelle";
            this.label_Libelle.Size = new System.Drawing.Size(37, 13);
            this.label_Libelle.TabIndex = 12;
            this.label_Libelle.Text = "Libelle";
            // 
            // label_Num
            // 
            this.label_Num.AutoSize = true;
            this.label_Num.Location = new System.Drawing.Point(43, 29);
            this.label_Num.Name = "label_Num";
            this.label_Num.Size = new System.Drawing.Size(44, 13);
            this.label_Num.TabIndex = 11;
            this.label_Num.Text = "Numéro";
            // 
            // FicheGenre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 163);
            this.Controls.Add(this.btn_Valider);
            this.Controls.Add(this.btn_Annuler);
            this.Controls.Add(this.tb_Libelle);
            this.Controls.Add(this.tb_Num);
            this.Controls.Add(this.label_Libelle);
            this.Controls.Add(this.label_Num);
            this.MaximizeBox = false;
            this.Name = "FicheGenre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FicheGenre";
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Valider;
        private System.Windows.Forms.Button btn_Annuler;
        private System.Windows.Forms.TextBox tb_Libelle;
        private System.Windows.Forms.TextBox tb_Num;
        private System.Windows.Forms.Label label_Libelle;
        private System.Windows.Forms.Label label_Num;
        private System.Windows.Forms.BindingSource bs;
    }
}