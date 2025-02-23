namespace GestionVentes.PL
{
    partial class FRM_Ajoute_Modifier_Categorie
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
            this.comboDep = new System.Windows.Forms.ComboBox();
            this.btnenregistrer = new System.Windows.Forms.Button();
            this.btnactualiser = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCat = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textNomCat = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnquitter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // comboDep
            // 
            this.comboDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboDep.FormattingEnabled = true;
            this.comboDep.Location = new System.Drawing.Point(254, 104);
            this.comboDep.Name = "comboDep";
            this.comboDep.Size = new System.Drawing.Size(270, 39);
            this.comboDep.TabIndex = 95;
            this.comboDep.SelectedIndexChanged += new System.EventHandler(this.comboDep_SelectedIndexChanged);
            // 
            // btnenregistrer
            // 
            this.btnenregistrer.BackColor = System.Drawing.Color.Gray;
            this.btnenregistrer.FlatAppearance.BorderSize = 0;
            this.btnenregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnenregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenregistrer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnenregistrer.Location = new System.Drawing.Point(294, 298);
            this.btnenregistrer.Name = "btnenregistrer";
            this.btnenregistrer.Size = new System.Drawing.Size(230, 58);
            this.btnenregistrer.TabIndex = 94;
            this.btnenregistrer.Text = "Enregistrer";
            this.btnenregistrer.UseCompatibleTextRendering = true;
            this.btnenregistrer.UseVisualStyleBackColor = false;
            this.btnenregistrer.Click += new System.EventHandler(this.btnenregistrer_Click);
            // 
            // btnactualiser
            // 
            this.btnactualiser.BackColor = System.Drawing.Color.Gray;
            this.btnactualiser.FlatAppearance.BorderSize = 0;
            this.btnactualiser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnactualiser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualiser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnactualiser.Location = new System.Drawing.Point(24, 298);
            this.btnactualiser.Name = "btnactualiser";
            this.btnactualiser.Size = new System.Drawing.Size(241, 58);
            this.btnactualiser.TabIndex = 93;
            this.btnactualiser.Text = "Actualiser";
            this.btnactualiser.UseCompatibleTextRendering = true;
            this.btnactualiser.UseVisualStyleBackColor = false;
            this.btnactualiser.Click += new System.EventHandler(this.btnactualiser_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(50, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 32);
            this.label2.TabIndex = 91;
            this.label2.Text = "Département:";
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCat.Location = new System.Drawing.Point(47, 23);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(357, 51);
            this.lblCat.TabIndex = 90;
            this.lblCat.Text = "Ajouter Catégorie";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(149)))), ((int)(((byte)(118)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(590, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 392);
            this.panel3.TabIndex = 89;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(149)))), ((int)(((byte)(118)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 392);
            this.panel4.TabIndex = 87;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(149)))), ((int)(((byte)(118)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 397);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(595, 5);
            this.panel2.TabIndex = 88;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(149)))), ((int)(((byte)(118)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 5);
            this.panel1.TabIndex = 86;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(122, 247);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(350, 3);
            this.textBox2.TabIndex = 96;
            // 
            // textNomCat
            // 
            this.textNomCat.BackColor = System.Drawing.Color.Gray;
            this.textNomCat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNomCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNomCat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textNomCat.Location = new System.Drawing.Point(161, 207);
            this.textNomCat.Multiline = true;
            this.textNomCat.Name = "textNomCat";
            this.textNomCat.Size = new System.Drawing.Size(294, 34);
            this.textNomCat.TabIndex = 97;
            this.textNomCat.Text = "Nom Catégorie";
            this.textNomCat.Enter += new System.EventHandler(this.textNomCat_Enter);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::GestionVentes.Properties.Resources.Categorie2;
            this.pictureBox4.Location = new System.Drawing.Point(56, 207);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(43, 43);
            this.pictureBox4.TabIndex = 98;
            this.pictureBox4.TabStop = false;
            // 
            // btnquitter
            // 
            this.btnquitter.FlatAppearance.BorderSize = 0;
            this.btnquitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnquitter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnquitter.Image = global::GestionVentes.Properties.Resources.Close_2_icon;
            this.btnquitter.Location = new System.Drawing.Point(520, 3);
            this.btnquitter.Name = "btnquitter";
            this.btnquitter.Size = new System.Drawing.Size(72, 61);
            this.btnquitter.TabIndex = 85;
            this.btnquitter.UseVisualStyleBackColor = true;
            this.btnquitter.Click += new System.EventHandler(this.btnquitter_Click);
            // 
            // FRM_Ajoute_Modifier_Categorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(595, 402);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.textNomCat);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboDep);
            this.Controls.Add(this.btnenregistrer);
            this.Controls.Add(this.btnactualiser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCat);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnquitter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Ajoute_Modifier_Categorie";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FRM_Ajoute_Modifier_Categorie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnquitter;
        public System.Windows.Forms.ComboBox comboDep;
        private System.Windows.Forms.Button btnenregistrer;
        public System.Windows.Forms.Button btnactualiser;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.TextBox textNomCat;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}