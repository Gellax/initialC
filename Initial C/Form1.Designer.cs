namespace Initial_C
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbCatégorie = new System.Windows.Forms.ComboBox();
            this.dgvVehicule = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicule)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCatégorie
            // 
            this.cbCatégorie.FormattingEnabled = true;
            this.cbCatégorie.Items.AddRange(new object[] {
            "Voiture",
            "Camion",
            "Bateau"});
            this.cbCatégorie.Location = new System.Drawing.Point(17, 16);
            this.cbCatégorie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbCatégorie.Name = "cbCatégorie";
            this.cbCatégorie.Size = new System.Drawing.Size(160, 24);
            this.cbCatégorie.TabIndex = 0;
            this.cbCatégorie.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dgvVehicule
            // 
            this.dgvVehicule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicule.Location = new System.Drawing.Point(17, 66);
            this.dgvVehicule.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvVehicule.Name = "dgvVehicule";
            this.dgvVehicule.ReadOnly = true;
            this.dgvVehicule.Size = new System.Drawing.Size(587, 137);
            this.dgvVehicule.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(429, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(116, 40);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 481);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvVehicule);
            this.Controls.Add(this.cbCatégorie);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCatégorie;
        private System.Windows.Forms.DataGridView dgvVehicule;
        private System.Windows.Forms.Button btnDelete;
    }
}

