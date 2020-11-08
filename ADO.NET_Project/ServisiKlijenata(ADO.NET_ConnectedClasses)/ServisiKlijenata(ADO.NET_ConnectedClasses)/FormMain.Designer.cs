namespace ADO.NET_CRUD
{
    partial class FormMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GridKlijenti = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSelectKlijenti = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKijent = new System.Windows.Forms.TextBox();
            this.txtRegistracija = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtKomentar = new System.Windows.Forms.TextBox();
            this.BtnInsertKlijenti = new System.Windows.Forms.Button();
            this.GridServisi = new System.Windows.Forms.DataGridView();
            this.txtUsluga = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnSelectServisi = new System.Windows.Forms.Button();
            this.BtnInsertServisi = new System.Windows.Forms.Button();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.txtKlijentFK = new System.Windows.Forms.TextBox();
            this.BtnUpdateKlijent = new System.Windows.Forms.Button();
            this.BtnUpdateServis = new System.Windows.Forms.Button();
            this.txtKlijentID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtServisID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.BtnDeleteKlijent = new System.Windows.Forms.Button();
            this.BtnDeleteServis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridKlijenti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridServisi)).BeginInit();
            this.SuspendLayout();
            // 
            // GridKlijenti
            // 
            this.GridKlijenti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridKlijenti.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridKlijenti.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.GridKlijenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridKlijenti.DefaultCellStyle = dataGridViewCellStyle18;
            this.GridKlijenti.EnableHeadersVisualStyles = false;
            this.GridKlijenti.Location = new System.Drawing.Point(12, 54);
            this.GridKlijenti.Name = "GridKlijenti";
            this.GridKlijenti.ReadOnly = true;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridKlijenti.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.GridKlijenti.RowHeadersVisible = false;
            this.GridKlijenti.RowTemplate.Height = 24;
            this.GridKlijenti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridKlijenti.Size = new System.Drawing.Size(709, 347);
            this.GridKlijenti.TabIndex = 0;
            this.GridKlijenti.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridKlijenti_CellMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Klijenti";
            // 
            // BtnSelectKlijenti
            // 
            this.BtnSelectKlijenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSelectKlijenti.Location = new System.Drawing.Point(581, 9);
            this.BtnSelectKlijenti.Name = "BtnSelectKlijenti";
            this.BtnSelectKlijenti.Size = new System.Drawing.Size(140, 39);
            this.BtnSelectKlijenti.TabIndex = 2;
            this.BtnSelectKlijenti.Text = "Osveži listu";
            this.BtnSelectKlijenti.UseVisualStyleBackColor = true;
            this.BtnSelectKlijenti.Click += new System.EventHandler(this.BtnSelectKlijenti_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(111, 439);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Klijent:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 495);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Registracija:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(105, 467);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Adresa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 523);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Komentar(opciono):";
            // 
            // txtKijent
            // 
            this.txtKijent.Location = new System.Drawing.Point(176, 435);
            this.txtKijent.MaxLength = 40;
            this.txtKijent.Name = "txtKijent";
            this.txtKijent.Size = new System.Drawing.Size(247, 22);
            this.txtKijent.TabIndex = 7;
            // 
            // txtRegistracija
            // 
            this.txtRegistracija.Location = new System.Drawing.Point(176, 491);
            this.txtRegistracija.MaxLength = 20;
            this.txtRegistracija.Name = "txtRegistracija";
            this.txtRegistracija.Size = new System.Drawing.Size(131, 22);
            this.txtRegistracija.TabIndex = 8;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(176, 463);
            this.txtAdresa.MaxLength = 40;
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(247, 22);
            this.txtAdresa.TabIndex = 9;
            // 
            // txtKomentar
            // 
            this.txtKomentar.Location = new System.Drawing.Point(176, 519);
            this.txtKomentar.MaxLength = 200;
            this.txtKomentar.Multiline = true;
            this.txtKomentar.Name = "txtKomentar";
            this.txtKomentar.Size = new System.Drawing.Size(247, 65);
            this.txtKomentar.TabIndex = 10;
            // 
            // BtnInsertKlijenti
            // 
            this.BtnInsertKlijenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInsertKlijenti.Location = new System.Drawing.Point(429, 545);
            this.BtnInsertKlijenti.Name = "BtnInsertKlijenti";
            this.BtnInsertKlijenti.Size = new System.Drawing.Size(146, 39);
            this.BtnInsertKlijenti.TabIndex = 11;
            this.BtnInsertKlijenti.Text = "Dodaj klijenta";
            this.BtnInsertKlijenti.UseVisualStyleBackColor = true;
            this.BtnInsertKlijenti.Click += new System.EventHandler(this.BtnInsertKlijenti_Click);
            // 
            // GridServisi
            // 
            this.GridServisi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridServisi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridServisi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridServisi.DefaultCellStyle = dataGridViewCellStyle20;
            this.GridServisi.Location = new System.Drawing.Point(801, 54);
            this.GridServisi.Name = "GridServisi";
            this.GridServisi.ReadOnly = true;
            this.GridServisi.RowHeadersVisible = false;
            this.GridServisi.RowTemplate.Height = 24;
            this.GridServisi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridServisi.Size = new System.Drawing.Size(709, 347);
            this.GridServisi.TabIndex = 12;
            this.GridServisi.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridServisi_CellMouseClick);
            // 
            // txtUsluga
            // 
            this.txtUsluga.Location = new System.Drawing.Point(884, 462);
            this.txtUsluga.MaxLength = 40;
            this.txtUsluga.Name = "txtUsluga";
            this.txtUsluga.Size = new System.Drawing.Size(292, 22);
            this.txtUsluga.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(813, 466);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Usluga:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(798, 494);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Klijent ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(816, 439);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 18);
            this.label8.TabIndex = 13;
            this.label8.Text = "Datum:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(794, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 42);
            this.label9.TabIndex = 19;
            this.label9.Text = "Servisi";
            // 
            // BtnSelectServisi
            // 
            this.BtnSelectServisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSelectServisi.Location = new System.Drawing.Point(1370, 9);
            this.BtnSelectServisi.Name = "BtnSelectServisi";
            this.BtnSelectServisi.Size = new System.Drawing.Size(140, 39);
            this.BtnSelectServisi.TabIndex = 20;
            this.BtnSelectServisi.Text = "Osveži listu";
            this.BtnSelectServisi.UseVisualStyleBackColor = true;
            this.BtnSelectServisi.Click += new System.EventHandler(this.BtnSelectServisi_Click);
            // 
            // BtnInsertServisi
            // 
            this.BtnInsertServisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInsertServisi.Location = new System.Drawing.Point(884, 518);
            this.BtnInsertServisi.Name = "BtnInsertServisi";
            this.BtnInsertServisi.Size = new System.Drawing.Size(146, 39);
            this.BtnInsertServisi.TabIndex = 21;
            this.BtnInsertServisi.Text = "Dodaj servis";
            this.BtnInsertServisi.UseVisualStyleBackColor = true;
            this.BtnInsertServisi.Click += new System.EventHandler(this.BtnInsertServisi_Click);
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(884, 435);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(292, 22);
            this.datePicker.TabIndex = 22;
            // 
            // txtKlijentFK
            // 
            this.txtKlijentFK.Location = new System.Drawing.Point(884, 490);
            this.txtKlijentFK.MaxLength = 4;
            this.txtKlijentFK.Name = "txtKlijentFK";
            this.txtKlijentFK.Size = new System.Drawing.Size(52, 22);
            this.txtKlijentFK.TabIndex = 23;
            // 
            // BtnUpdateKlijent
            // 
            this.BtnUpdateKlijent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdateKlijent.Location = new System.Drawing.Point(429, 435);
            this.BtnUpdateKlijent.Name = "BtnUpdateKlijent";
            this.BtnUpdateKlijent.Size = new System.Drawing.Size(292, 39);
            this.BtnUpdateKlijent.TabIndex = 24;
            this.BtnUpdateKlijent.Text = "Izmeni podatke o klijentu";
            this.BtnUpdateKlijent.UseVisualStyleBackColor = true;
            this.BtnUpdateKlijent.Click += new System.EventHandler(this.BtnUpdateKlijent_Click);
            // 
            // BtnUpdateServis
            // 
            this.BtnUpdateServis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdateServis.Location = new System.Drawing.Point(1182, 435);
            this.BtnUpdateServis.Name = "BtnUpdateServis";
            this.BtnUpdateServis.Size = new System.Drawing.Size(292, 39);
            this.BtnUpdateServis.TabIndex = 25;
            this.BtnUpdateServis.Text = "Izmeni podatke o servisu";
            this.BtnUpdateServis.UseVisualStyleBackColor = true;
            this.BtnUpdateServis.Click += new System.EventHandler(this.BtnUpdateServis_Click);
            // 
            // txtKlijentID
            // 
            this.txtKlijentID.Location = new System.Drawing.Point(176, 407);
            this.txtKlijentID.MaxLength = 40;
            this.txtKlijentID.Name = "txtKlijentID";
            this.txtKlijentID.ReadOnly = true;
            this.txtKlijentID.Size = new System.Drawing.Size(44, 22);
            this.txtKlijentID.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(90, 411);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 18);
            this.label10.TabIndex = 26;
            this.label10.Text = "Klijent ID:";
            // 
            // txtServisID
            // 
            this.txtServisID.Location = new System.Drawing.Point(885, 407);
            this.txtServisID.MaxLength = 40;
            this.txtServisID.Name = "txtServisID";
            this.txtServisID.ReadOnly = true;
            this.txtServisID.Size = new System.Drawing.Size(52, 22);
            this.txtServisID.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(798, 411);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 18);
            this.label11.TabIndex = 28;
            this.label11.Text = "Servis ID:";
            // 
            // BtnDeleteKlijent
            // 
            this.BtnDeleteKlijent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteKlijent.Location = new System.Drawing.Point(581, 545);
            this.BtnDeleteKlijent.Name = "BtnDeleteKlijent";
            this.BtnDeleteKlijent.Size = new System.Drawing.Size(140, 39);
            this.BtnDeleteKlijent.TabIndex = 30;
            this.BtnDeleteKlijent.Text = "Obriši klijenta";
            this.BtnDeleteKlijent.UseVisualStyleBackColor = true;
            this.BtnDeleteKlijent.Click += new System.EventHandler(this.BtnDeleteKlijent_Click);
            // 
            // BtnDeleteServis
            // 
            this.BtnDeleteServis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteServis.Location = new System.Drawing.Point(1036, 518);
            this.BtnDeleteServis.Name = "BtnDeleteServis";
            this.BtnDeleteServis.Size = new System.Drawing.Size(140, 39);
            this.BtnDeleteServis.TabIndex = 31;
            this.BtnDeleteServis.Text = "Obriši servis";
            this.BtnDeleteServis.UseVisualStyleBackColor = true;
            this.BtnDeleteServis.Click += new System.EventHandler(this.BtnDeleteServis_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1522, 596);
            this.Controls.Add(this.BtnDeleteServis);
            this.Controls.Add(this.BtnDeleteKlijent);
            this.Controls.Add(this.txtServisID);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtKlijentID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.BtnUpdateServis);
            this.Controls.Add(this.BtnUpdateKlijent);
            this.Controls.Add(this.txtKlijentFK);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.BtnInsertServisi);
            this.Controls.Add(this.BtnSelectServisi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtUsluga);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.GridServisi);
            this.Controls.Add(this.BtnInsertKlijenti);
            this.Controls.Add(this.txtKomentar);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.txtRegistracija);
            this.Controls.Add(this.txtKijent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnSelectKlijenti);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridKlijenti);
            this.Name = "FormMain";
            this.Text = "Servis automobila";
            ((System.ComponentModel.ISupportInitialize)(this.GridKlijenti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridServisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridKlijenti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSelectKlijenti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKijent;
        private System.Windows.Forms.TextBox txtRegistracija;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtKomentar;
        private System.Windows.Forms.Button BtnInsertKlijenti;
        private System.Windows.Forms.DataGridView GridServisi;
        private System.Windows.Forms.TextBox txtUsluga;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnSelectServisi;
        private System.Windows.Forms.Button BtnInsertServisi;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.TextBox txtKlijentFK;
        private System.Windows.Forms.Button BtnUpdateKlijent;
        private System.Windows.Forms.Button BtnUpdateServis;
        private System.Windows.Forms.TextBox txtKlijentID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtServisID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BtnDeleteKlijent;
        private System.Windows.Forms.Button BtnDeleteServis;
    }
}

