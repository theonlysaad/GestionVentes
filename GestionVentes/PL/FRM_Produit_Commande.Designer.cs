namespace GestionVentes.PL
{
    partial class FRM_Produit_Commande
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
            this.grpProduit = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textremise = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textquantité = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblid = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblprix = new System.Windows.Forms.Label();
            this.lblstock = new System.Windows.Forms.Label();
            this.lblnom = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnenregistrer = new System.Windows.Forms.Button();
            this.grpProduit.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpProduit
            // 
            this.grpProduit.Controls.Add(this.label10);
            this.grpProduit.Controls.Add(this.textTotal);
            this.grpProduit.Controls.Add(this.label6);
            this.grpProduit.Controls.Add(this.textremise);
            this.grpProduit.Controls.Add(this.label5);
            this.grpProduit.Controls.Add(this.textquantité);
            this.grpProduit.Controls.Add(this.label4);
            this.grpProduit.Controls.Add(this.groupBox2);
            this.grpProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpProduit.ForeColor = System.Drawing.Color.Black;
            this.grpProduit.Location = new System.Drawing.Point(12, 21);
            this.grpProduit.Name = "grpProduit";
            this.grpProduit.Size = new System.Drawing.Size(699, 344);
            this.grpProduit.TabIndex = 0;
            this.grpProduit.TabStop = false;
            this.grpProduit.Text = "Vendre Produit";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(587, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 32);
            this.label10.TabIndex = 11;
            this.label10.Text = "%";
            // 
            // textTotal
            // 
            this.textTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textTotal.Enabled = false;
            this.textTotal.Location = new System.Drawing.Point(378, 297);
            this.textTotal.Name = "textTotal";
            this.textTotal.Size = new System.Drawing.Size(265, 31);
            this.textTotal.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(372, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 32);
            this.label6.TabIndex = 10;
            this.label6.Text = "     Total   ";
            // 
            // textremise
            // 
            this.textremise.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textremise.Location = new System.Drawing.Point(378, 190);
            this.textremise.Name = "textremise";
            this.textremise.Size = new System.Drawing.Size(265, 31);
            this.textremise.TabIndex = 7;
            this.textremise.TextChanged += new System.EventHandler(this.textremise_TextChanged);
            this.textremise.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textremise_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(355, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "       Promotion";
            // 
            // textquantité
            // 
            this.textquantité.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textquantité.Location = new System.Drawing.Point(378, 87);
            this.textquantité.Name = "textquantité";
            this.textquantité.Size = new System.Drawing.Size(265, 31);
            this.textquantité.TabIndex = 6;
            this.textquantité.TextChanged += new System.EventHandler(this.textquantité_TextChanged);
            this.textquantité.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textquantité_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(372, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "   Quantité";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblid);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lblprix);
            this.groupBox2.Controls.Add(this.lblstock);
            this.groupBox2.Controls.Add(this.lblnom);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(16, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 295);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Détail Produit";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.ForeColor = System.Drawing.Color.Ivory;
            this.lblid.Location = new System.Drawing.Point(121, 44);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(27, 29);
            this.lblid.TabIndex = 7;
            this.lblid.Text = "lI";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(12, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 29);
            this.label8.TabIndex = 6;
            this.label8.Text = "Id :";
            // 
            // lblprix
            // 
            this.lblprix.AutoSize = true;
            this.lblprix.ForeColor = System.Drawing.Color.Ivory;
            this.lblprix.Location = new System.Drawing.Point(125, 236);
            this.lblprix.Name = "lblprix";
            this.lblprix.Size = new System.Drawing.Size(35, 29);
            this.lblprix.TabIndex = 5;
            this.lblprix.Text = "lp";
            // 
            // lblstock
            // 
            this.lblstock.AutoSize = true;
            this.lblstock.ForeColor = System.Drawing.Color.Ivory;
            this.lblstock.Location = new System.Drawing.Point(122, 167);
            this.lblstock.Name = "lblstock";
            this.lblstock.Size = new System.Drawing.Size(33, 29);
            this.lblstock.TabIndex = 4;
            this.lblstock.Text = "ls";
            // 
            // lblnom
            // 
            this.lblnom.AutoSize = true;
            this.lblnom.ForeColor = System.Drawing.Color.Ivory;
            this.lblnom.Location = new System.Drawing.Point(121, 104);
            this.lblnom.Name = "lblnom";
            this.lblnom.Size = new System.Drawing.Size(34, 29);
            this.lblnom.TabIndex = 3;
            this.lblnom.Text = "ln";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(15, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prix :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(12, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stock :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom :";
            // 
            // btnenregistrer
            // 
            this.btnenregistrer.BackColor = System.Drawing.Color.Gray;
            this.btnenregistrer.FlatAppearance.BorderSize = 0;
            this.btnenregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnenregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenregistrer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnenregistrer.Location = new System.Drawing.Point(191, 387);
            this.btnenregistrer.Name = "btnenregistrer";
            this.btnenregistrer.Size = new System.Drawing.Size(324, 58);
            this.btnenregistrer.TabIndex = 84;
            this.btnenregistrer.Text = "Enregistrer";
            this.btnenregistrer.UseCompatibleTextRendering = true;
            this.btnenregistrer.UseVisualStyleBackColor = false;
            this.btnenregistrer.Click += new System.EventHandler(this.btnenregistrer_Click);
            // 
            // FRM_Produit_Commande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(720, 475);
            this.Controls.Add(this.btnenregistrer);
            this.Controls.Add(this.grpProduit);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FRM_Produit_Commande";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produit";
            this.Load += new System.EventHandler(this.FRM_Produit_Commande_Load);
            this.grpProduit.ResumeLayout(false);
            this.grpProduit.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnenregistrer;
        public System.Windows.Forms.Label lblprix;
        public System.Windows.Forms.Label lblstock;
        public System.Windows.Forms.Label lblnom;
        public System.Windows.Forms.TextBox textTotal;
        public System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.GroupBox grpProduit;
        public System.Windows.Forms.TextBox textremise;
        public System.Windows.Forms.TextBox textquantité;
    }
}