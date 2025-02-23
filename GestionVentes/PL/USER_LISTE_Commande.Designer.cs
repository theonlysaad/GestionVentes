namespace GestionVentes.PL
{
    partial class USER_LISTE_Commande
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label1;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dvgcommande = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paiement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateD = new System.Windows.Forms.DateTimePicker();
            this.dateF = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnimprimerFacture = new System.Windows.Forms.Button();
            this.btnresearch = new System.Windows.Forms.Button();
            this.btnajouterCom = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgcommande)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            label1.Location = new System.Drawing.Point(503, 97);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(151, 27);
            label1.TabIndex = 34;
            label1.Text = "Date Début :";
            // 
            // dvgcommande
            // 
            this.dvgcommande.AllowUserToAddRows = false;
            this.dvgcommande.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgcommande.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgcommande.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgcommande.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dvgcommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgcommande.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column9,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.paiement});
            this.dvgcommande.EnableHeadersVisualStyles = false;
            this.dvgcommande.Location = new System.Drawing.Point(12, 209);
            this.dvgcommande.Name = "dvgcommande";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgcommande.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dvgcommande.RowHeadersVisible = false;
            this.dvgcommande.RowHeadersWidth = 51;
            this.dvgcommande.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dvgcommande.RowTemplate.Height = 24;
            this.dvgcommande.Size = new System.Drawing.Size(1072, 387);
            this.dvgcommande.TabIndex = 18;
            this.dvgcommande.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgcommande_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Select";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Id";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Date";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Client";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "TOTAL HT";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "TVA%";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // paiement
            // 
            this.paiement.HeaderText = "TOTAL TTC";
            this.paiement.MinimumWidth = 6;
            this.paiement.Name = "paiement";
            // 
            // dateD
            // 
            this.dateD.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateD.Location = new System.Drawing.Point(690, 97);
            this.dateD.Name = "dateD";
            this.dateD.Size = new System.Drawing.Size(314, 30);
            this.dateD.TabIndex = 35;
            this.dateD.ValueChanged += new System.EventHandler(this.dateD_ValueChanged);
            // 
            // dateF
            // 
            this.dateF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateF.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateF.Location = new System.Drawing.Point(690, 164);
            this.dateF.Name = "dateF";
            this.dateF.Size = new System.Drawing.Size(314, 30);
            this.dateF.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(536, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 27);
            this.label2.TabIndex = 36;
            this.label2.Text = "Date Fin :";
            // 
            // btnimprimerFacture
            // 
            this.btnimprimerFacture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnimprimerFacture.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnimprimerFacture.FlatAppearance.BorderSize = 0;
            this.btnimprimerFacture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnimprimerFacture.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimprimerFacture.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnimprimerFacture.Image = global::GestionVentes.Properties.Resources.print_icon1;
            this.btnimprimerFacture.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnimprimerFacture.Location = new System.Drawing.Point(392, 625);
            this.btnimprimerFacture.Name = "btnimprimerFacture";
            this.btnimprimerFacture.Size = new System.Drawing.Size(306, 53);
            this.btnimprimerFacture.TabIndex = 39;
            this.btnimprimerFacture.Text = "       Imprimer Facture";
            this.btnimprimerFacture.UseVisualStyleBackColor = false;
            // 
            // btnresearch
            // 
            this.btnresearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnresearch.FlatAppearance.BorderSize = 0;
            this.btnresearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnresearch.Image = global::GestionVentes.Properties.Resources.search1;
            this.btnresearch.Location = new System.Drawing.Point(1019, 144);
            this.btnresearch.Name = "btnresearch";
            this.btnresearch.Size = new System.Drawing.Size(54, 59);
            this.btnresearch.TabIndex = 38;
            this.btnresearch.UseVisualStyleBackColor = true;
            this.btnresearch.Click += new System.EventHandler(this.btnresearch_Click);
            // 
            // btnajouterCom
            // 
            this.btnajouterCom.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnajouterCom.FlatAppearance.BorderSize = 0;
            this.btnajouterCom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnajouterCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnajouterCom.ForeColor = System.Drawing.Color.Snow;
            this.btnajouterCom.Image = global::GestionVentes.Properties.Resources.Actions_list_add_icon1;
            this.btnajouterCom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnajouterCom.Location = new System.Drawing.Point(27, 138);
            this.btnajouterCom.Name = "btnajouterCom";
            this.btnajouterCom.Size = new System.Drawing.Size(136, 53);
            this.btnajouterCom.TabIndex = 33;
            this.btnajouterCom.Text = "       Ajouter";
            this.btnajouterCom.UseVisualStyleBackColor = false;
            this.btnajouterCom.Click += new System.EventHandler(this.btnajouterCom_Click);
            // 
            // USER_LISTE_Commande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnimprimerFacture);
            this.Controls.Add(this.btnresearch);
            this.Controls.Add(this.dateF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateD);
            this.Controls.Add(label1);
            this.Controls.Add(this.btnajouterCom);
            this.Controls.Add(this.dvgcommande);
            this.Name = "USER_LISTE_Commande";
            this.Size = new System.Drawing.Size(1087, 720);
            this.Load += new System.EventHandler(this.USER_LISTE_Commande_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgcommande)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgcommande;
        private System.Windows.Forms.Button btnajouterCom;
        private System.Windows.Forms.DateTimePicker dateD;
        private System.Windows.Forms.DateTimePicker dateF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnresearch;
        private System.Windows.Forms.Button btnimprimerFacture;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn paiement;
    }
}
