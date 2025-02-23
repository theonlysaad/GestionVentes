namespace GestionVentes.PL
{
    partial class USER_Liste_Produit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dvgproduit = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textrecherche = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnexcel = new System.Windows.Forms.Button();
            this.btnimprimerTout = new System.Windows.Forms.Button();
            this.btnimprimerSelect = new System.Windows.Forms.Button();
            this.btnafficherphoto = new System.Windows.Forms.Button();
            this.btnsupprimer = new System.Windows.Forms.Button();
            this.btnmodifier = new System.Windows.Forms.Button();
            this.btnajouter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgproduit)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgproduit
            // 
            this.dvgproduit.AllowUserToAddRows = false;
            this.dvgproduit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgproduit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgproduit.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgproduit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dvgproduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgproduit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column9,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dvgproduit.EnableHeadersVisualStyles = false;
            this.dvgproduit.Location = new System.Drawing.Point(13, 164);
            this.dvgproduit.Name = "dvgproduit";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgproduit.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dvgproduit.RowHeadersVisible = false;
            this.dvgproduit.RowHeadersWidth = 51;
            this.dvgproduit.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dvgproduit.RowTemplate.Height = 24;
            this.dvgproduit.Size = new System.Drawing.Size(1002, 357);
            this.dvgproduit.TabIndex = 17;
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
            this.Column2.HeaderText = "Nom";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantité";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Prix";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Catégorie";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Location = new System.Drawing.Point(82, 120);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(791, 3);
            this.panel3.TabIndex = 15;
            // 
            // textrecherche
            // 
            this.textrecherche.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textrecherche.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textrecherche.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textrecherche.ForeColor = System.Drawing.Color.Gray;
            this.textrecherche.Location = new System.Drawing.Point(81, 88);
            this.textrecherche.Multiline = true;
            this.textrecherche.Name = "textrecherche";
            this.textrecherche.Size = new System.Drawing.Size(791, 41);
            this.textrecherche.TabIndex = 14;
            this.textrecherche.Text = "Rechercher";
            this.textrecherche.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textrecherche.TextChanged += new System.EventHandler(this.textrecherche_TextChanged);
            this.textrecherche.Enter += new System.EventHandler(this.textrecherche_Enter_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Location = new System.Drawing.Point(13, 155);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(977, 3);
            this.panel2.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(13, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(977, 3);
            this.panel1.TabIndex = 12;
            // 
            // btnexcel
            // 
            this.btnexcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnexcel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnexcel.FlatAppearance.BorderSize = 0;
            this.btnexcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcel.ForeColor = System.Drawing.Color.Snow;
            this.btnexcel.Image = global::GestionVentes.Properties.Resources.Excel_icon1;
            this.btnexcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexcel.Location = new System.Drawing.Point(722, 539);
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.Size = new System.Drawing.Size(268, 53);
            this.btnexcel.TabIndex = 21;
            this.btnexcel.Text = "      Copie Excel";
            this.btnexcel.UseVisualStyleBackColor = false;
            this.btnexcel.Click += new System.EventHandler(this.btnexcel_Click);
            // 
            // btnimprimerTout
            // 
            this.btnimprimerTout.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnimprimerTout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnimprimerTout.FlatAppearance.BorderSize = 0;
            this.btnimprimerTout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnimprimerTout.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimprimerTout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnimprimerTout.Image = global::GestionVentes.Properties.Resources.Imprimer1;
            this.btnimprimerTout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnimprimerTout.Location = new System.Drawing.Point(382, 539);
            this.btnimprimerTout.Name = "btnimprimerTout";
            this.btnimprimerTout.Size = new System.Drawing.Size(232, 53);
            this.btnimprimerTout.TabIndex = 20;
            this.btnimprimerTout.Text = "        Imprimer Toutes";
            this.btnimprimerTout.UseVisualStyleBackColor = false;
            this.btnimprimerTout.Click += new System.EventHandler(this.btnimprimerTout_Click);
            // 
            // btnimprimerSelect
            // 
            this.btnimprimerSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnimprimerSelect.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnimprimerSelect.FlatAppearance.BorderSize = 0;
            this.btnimprimerSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnimprimerSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimprimerSelect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnimprimerSelect.Image = global::GestionVentes.Properties.Resources.Imprimer1;
            this.btnimprimerSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnimprimerSelect.Location = new System.Drawing.Point(30, 539);
            this.btnimprimerSelect.Name = "btnimprimerSelect";
            this.btnimprimerSelect.Size = new System.Drawing.Size(262, 53);
            this.btnimprimerSelect.TabIndex = 19;
            this.btnimprimerSelect.Text = "       Imprimer PR cocher";
            this.btnimprimerSelect.UseVisualStyleBackColor = false;
            this.btnimprimerSelect.Click += new System.EventHandler(this.btnimprimerSelect_Click);
            // 
            // btnafficherphoto
            // 
            this.btnafficherphoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnafficherphoto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnafficherphoto.FlatAppearance.BorderSize = 0;
            this.btnafficherphoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnafficherphoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnafficherphoto.ForeColor = System.Drawing.Color.Snow;
            this.btnafficherphoto.Image = global::GestionVentes.Properties.Resources.Pictures_icon1;
            this.btnafficherphoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnafficherphoto.Location = new System.Drawing.Point(781, 12);
            this.btnafficherphoto.Name = "btnafficherphoto";
            this.btnafficherphoto.Size = new System.Drawing.Size(234, 53);
            this.btnafficherphoto.TabIndex = 18;
            this.btnafficherphoto.Text = "     Afficher Photo";
            this.btnafficherphoto.UseVisualStyleBackColor = false;
            this.btnafficherphoto.Click += new System.EventHandler(this.btnafficherphoto_Click);
            // 
            // btnsupprimer
            // 
            this.btnsupprimer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnsupprimer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnsupprimer.FlatAppearance.BorderSize = 0;
            this.btnsupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsupprimer.ForeColor = System.Drawing.Color.Snow;
            this.btnsupprimer.Image = global::GestionVentes.Properties.Resources.Close_2_icon1;
            this.btnsupprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsupprimer.Location = new System.Drawing.Point(524, 12);
            this.btnsupprimer.Name = "btnsupprimer";
            this.btnsupprimer.Size = new System.Drawing.Size(239, 53);
            this.btnsupprimer.TabIndex = 11;
            this.btnsupprimer.Text = "     Supprimer";
            this.btnsupprimer.UseVisualStyleBackColor = false;
            this.btnsupprimer.Click += new System.EventHandler(this.btnsupprimer_Click);
            // 
            // btnmodifier
            // 
            this.btnmodifier.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnmodifier.FlatAppearance.BorderSize = 0;
            this.btnmodifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmodifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodifier.ForeColor = System.Drawing.Color.Snow;
            this.btnmodifier.Image = global::GestionVentes.Properties.Resources.Recycle_iconaaa1;
            this.btnmodifier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmodifier.Location = new System.Drawing.Point(263, 12);
            this.btnmodifier.Name = "btnmodifier";
            this.btnmodifier.Size = new System.Drawing.Size(238, 53);
            this.btnmodifier.TabIndex = 10;
            this.btnmodifier.Text = "       Modifier";
            this.btnmodifier.UseVisualStyleBackColor = false;
            this.btnmodifier.Click += new System.EventHandler(this.btnmodifier_Click);
            // 
            // btnajouter
            // 
            this.btnajouter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnajouter.FlatAppearance.BorderSize = 0;
            this.btnajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnajouter.ForeColor = System.Drawing.Color.Snow;
            this.btnajouter.Image = global::GestionVentes.Properties.Resources.Actions_list_add_icon1;
            this.btnajouter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnajouter.Location = new System.Drawing.Point(30, 12);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(212, 53);
            this.btnajouter.TabIndex = 9;
            this.btnajouter.Text = "    Ajouter";
            this.btnajouter.UseVisualStyleBackColor = false;
            this.btnajouter.Click += new System.EventHandler(this.btnajouter_Click);
            // 
            // USER_Liste_Produit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.btnexcel);
            this.Controls.Add(this.btnimprimerTout);
            this.Controls.Add(this.btnimprimerSelect);
            this.Controls.Add(this.btnafficherphoto);
            this.Controls.Add(this.dvgproduit);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.textrecherche);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnsupprimer);
            this.Controls.Add(this.btnmodifier);
            this.Controls.Add(this.btnajouter);
            this.Name = "USER_Liste_Produit";
            this.Size = new System.Drawing.Size(1222, 720);
            this.Load += new System.EventHandler(this.USER_Liste_Produit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgproduit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgproduit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textrecherche;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnsupprimer;
        private System.Windows.Forms.Button btnmodifier;
        private System.Windows.Forms.Button btnajouter;
        private System.Windows.Forms.Button btnafficherphoto;
        private System.Windows.Forms.Button btnexcel;
        private System.Windows.Forms.Button btnimprimerTout;
        private System.Windows.Forms.Button btnimprimerSelect;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
