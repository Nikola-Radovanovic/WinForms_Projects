namespace KlijentiCRUD
{
    partial class FormInsert
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtKontakt = new System.Windows.Forms.TextBox();
            this.txtGrad = new System.Windows.Forms.TextBox();
            this.txtZemlja = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kontakt:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Grad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Zemlja:";
            // 
            // BtnInsert
            // 
            this.BtnInsert.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInsert.Location = new System.Drawing.Point(218, 219);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(136, 54);
            this.BtnInsert.TabIndex = 4;
            this.BtnInsert.Text = "Insert";
            this.BtnInsert.UseVisualStyleBackColor = true;
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(369, 219);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(136, 54);
            this.BtnCancel.TabIndex = 5;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(139, 64);
            this.txtIme.MaxLength = 40;
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(366, 22);
            this.txtIme.TabIndex = 6;
            // 
            // txtKontakt
            // 
            this.txtKontakt.Location = new System.Drawing.Point(139, 101);
            this.txtKontakt.MaxLength = 30;
            this.txtKontakt.Name = "txtKontakt";
            this.txtKontakt.Size = new System.Drawing.Size(330, 22);
            this.txtKontakt.TabIndex = 7;
            // 
            // txtGrad
            // 
            this.txtGrad.Location = new System.Drawing.Point(139, 139);
            this.txtGrad.MaxLength = 15;
            this.txtGrad.Name = "txtGrad";
            this.txtGrad.Size = new System.Drawing.Size(230, 22);
            this.txtGrad.TabIndex = 8;
            // 
            // txtZemlja
            // 
            this.txtZemlja.Location = new System.Drawing.Point(139, 177);
            this.txtZemlja.MaxLength = 15;
            this.txtZemlja.Name = "txtZemlja";
            this.txtZemlja.Size = new System.Drawing.Size(230, 22);
            this.txtZemlja.TabIndex = 9;
            // 
            // FormInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 336);
            this.Controls.Add(this.txtZemlja);
            this.Controls.Add(this.txtGrad);
            this.Controls.Add(this.txtKontakt);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnInsert);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormInsert";
            this.Text = "Dodavanje klijenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnInsert;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtKontakt;
        private System.Windows.Forms.TextBox txtGrad;
        private System.Windows.Forms.TextBox txtZemlja;
    }
}