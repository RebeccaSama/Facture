namespace Facture.WinForms
{
    partial class FormProducts
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
            this.lbUPL = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnImprimer = new System.Windows.Forms.Button();
            this.txtMontant_ht = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSaved = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbUPL
            // 
            this.lbUPL.AutoSize = true;
            this.lbUPL.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbUPL.Location = new System.Drawing.Point(269, 9);
            this.lbUPL.Name = "lbUPL";
            this.lbUPL.Size = new System.Drawing.Size(127, 26);
            this.lbUPL.TabIndex = 30;
            this.lbUPL.Text = "Product List";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(274, 38);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(544, 358);
            this.listView1.TabIndex = 23;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Designation";
            this.columnHeader1.Width = 131;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 129;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Montant_ht";
            this.columnHeader3.Width = 135;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Num_article";
            this.columnHeader4.Width = 221;
            // 
            // btnImprimer
            // 
            this.btnImprimer.BackColor = System.Drawing.Color.MediumBlue;
            this.btnImprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnImprimer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnImprimer.Location = new System.Drawing.Point(871, 359);
            this.btnImprimer.Name = "btnImprimer";
            this.btnImprimer.Size = new System.Drawing.Size(85, 37);
            this.btnImprimer.TabIndex = 31;
            this.btnImprimer.Text = "Imprimer";
            this.btnImprimer.UseVisualStyleBackColor = false;
            this.btnImprimer.Click += new System.EventHandler(this.btnImprimer_Click);
            // 
            // txtMontant_ht
            // 
            this.txtMontant_ht.Location = new System.Drawing.Point(14, 177);
            this.txtMontant_ht.Multiline = true;
            this.txtMontant_ht.Name = "txtMontant_ht";
            this.txtMontant_ht.Size = new System.Drawing.Size(236, 32);
            this.txtMontant_ht.TabIndex = 35;
            this.txtMontant_ht.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(9, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 26);
            this.label3.TabIndex = 38;
            this.label3.Text = "Montant_ht";
            // 
            // btnSaved
            // 
            this.btnSaved.BackColor = System.Drawing.Color.Red;
            this.btnSaved.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaved.Location = new System.Drawing.Point(14, 359);
            this.btnSaved.Name = "btnSaved";
            this.btnSaved.Size = new System.Drawing.Size(106, 37);
            this.btnSaved.TabIndex = 37;
            this.btnSaved.Text = "Save";
            this.btnSaved.UseVisualStyleBackColor = false;
            this.btnSaved.Click += new System.EventHandler(this.btnSaved_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(14, 113);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(236, 32);
            this.txtName.TabIndex = 34;
            this.txtName.UseSystemPasswordChar = true;
            // 
            // txtDesignation
            // 
            this.txtDesignation.Location = new System.Drawing.Point(14, 50);
            this.txtDesignation.Multiline = true;
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(236, 32);
            this.txtDesignation.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(9, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 26);
            this.label2.TabIndex = 36;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "Designation";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(14, 241);
            this.txtNum.Multiline = true;
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(236, 32);
            this.txtNum.TabIndex = 39;
            this.txtNum.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label4.Location = new System.Drawing.Point(9, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 26);
            this.label4.TabIndex = 40;
            this.label4.Text = "Num_article";
            // 
            // FormProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 412);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMontant_ht);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSaved);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtDesignation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbUPL);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnImprimer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormProducts";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.FormProducts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbUPL;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnImprimer;
        private System.Windows.Forms.TextBox txtMontant_ht;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSaved;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}