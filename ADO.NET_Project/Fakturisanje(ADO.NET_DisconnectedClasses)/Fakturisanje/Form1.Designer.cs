namespace KupciFakture_disconnected_
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gridKupci = new System.Windows.Forms.DataGridView();
            this.gridFakture = new System.Windows.Forms.DataGridView();
            this.BtnDodajKupca = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnDodajFakturu = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCenaStavke = new System.Windows.Forms.TextBox();
            this.txtNazivStavke = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gridStavke = new System.Windows.Forms.DataGridView();
            this.comboKupac = new System.Windows.Forms.ComboBox();
            this.dateTimeFaktura = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKupac = new System.Windows.Forms.TextBox();
            this.comboFaktura = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.BtnDodajStavku = new System.Windows.Forms.Button();
            this.BtnXMLfajl = new System.Windows.Forms.Button();
            this.BtnXMLshema = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridKupci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFakture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridStavke)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(209, 151);
            this.txtAdresa.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdresa.MaxLength = 200;
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(299, 22);
            this.txtAdresa.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kupac:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(125, 154);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Adresa:";
            // 
            // gridKupci
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridKupci.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridKupci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridKupci.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridKupci.Location = new System.Drawing.Point(517, 54);
            this.gridKupci.Margin = new System.Windows.Forms.Padding(4);
            this.gridKupci.Name = "gridKupci";
            this.gridKupci.RowHeadersWidth = 51;
            this.gridKupci.RowTemplate.Height = 24;
            this.gridKupci.Size = new System.Drawing.Size(740, 193);
            this.gridKupci.TabIndex = 4;
            // 
            // gridFakture
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridFakture.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridFakture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridFakture.DefaultCellStyle = dataGridViewCellStyle4;
            this.gridFakture.Location = new System.Drawing.Point(517, 294);
            this.gridFakture.Margin = new System.Windows.Forms.Padding(4);
            this.gridFakture.Name = "gridFakture";
            this.gridFakture.RowHeadersWidth = 51;
            this.gridFakture.RowTemplate.Height = 24;
            this.gridFakture.Size = new System.Drawing.Size(740, 191);
            this.gridFakture.TabIndex = 5;
            // 
            // BtnDodajKupca
            // 
            this.BtnDodajKupca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDodajKupca.Location = new System.Drawing.Point(209, 182);
            this.BtnDodajKupca.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDodajKupca.Name = "BtnDodajKupca";
            this.BtnDodajKupca.Size = new System.Drawing.Size(189, 62);
            this.BtnDodajKupca.TabIndex = 7;
            this.BtnDodajKupca.Text = "Dodaj kupca";
            this.BtnDodajKupca.UseVisualStyleBackColor = true;
            this.BtnDodajKupca.Click += new System.EventHandler(this.BtnDodajKupca_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(509, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kupci";
            // 
            // BtnDodajFakturu
            // 
            this.BtnDodajFakturu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDodajFakturu.Location = new System.Drawing.Point(209, 423);
            this.BtnDodajFakturu.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDodajFakturu.Name = "BtnDodajFakturu";
            this.BtnDodajFakturu.Size = new System.Drawing.Size(189, 62);
            this.BtnDodajFakturu.TabIndex = 13;
            this.BtnDodajFakturu.Text = "Dodaj fakturu";
            this.BtnDodajFakturu.UseVisualStyleBackColor = true;
            this.BtnDodajFakturu.Click += new System.EventHandler(this.BtnDodajFakturu_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(131, 391);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Datum:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 357);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Izaberite kupca:";
            // 
            // txtCenaStavke
            // 
            this.txtCenaStavke.Location = new System.Drawing.Point(209, 625);
            this.txtCenaStavke.Margin = new System.Windows.Forms.Padding(4);
            this.txtCenaStavke.MaxLength = 10;
            this.txtCenaStavke.Name = "txtCenaStavke";
            this.txtCenaStavke.Size = new System.Drawing.Size(188, 22);
            this.txtCenaStavke.TabIndex = 15;
            // 
            // txtNazivStavke
            // 
            this.txtNazivStavke.Location = new System.Drawing.Point(209, 591);
            this.txtNazivStavke.Margin = new System.Windows.Forms.Padding(4);
            this.txtNazivStavke.MaxLength = 40;
            this.txtNazivStavke.Name = "txtNazivStavke";
            this.txtNazivStavke.Size = new System.Drawing.Size(299, 22);
            this.txtNazivStavke.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(509, 251);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 32);
            this.label8.TabIndex = 19;
            this.label8.Text = "Fakture";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(509, 489);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(210, 32);
            this.label9.TabIndex = 20;
            this.label9.Text = "Stavke fakture";
            // 
            // gridStavke
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridStavke.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gridStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridStavke.DefaultCellStyle = dataGridViewCellStyle6;
            this.gridStavke.Location = new System.Drawing.Point(517, 530);
            this.gridStavke.Margin = new System.Windows.Forms.Padding(4);
            this.gridStavke.Name = "gridStavke";
            this.gridStavke.RowHeadersWidth = 51;
            this.gridStavke.RowTemplate.Height = 24;
            this.gridStavke.Size = new System.Drawing.Size(740, 191);
            this.gridStavke.TabIndex = 21;
            // 
            // comboKupac
            // 
            this.comboKupac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboKupac.FormattingEnabled = true;
            this.comboKupac.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboKupac.Location = new System.Drawing.Point(209, 352);
            this.comboKupac.Margin = new System.Windows.Forms.Padding(4);
            this.comboKupac.Name = "comboKupac";
            this.comboKupac.Size = new System.Drawing.Size(299, 24);
            this.comboKupac.TabIndex = 22;
            this.comboKupac.Tag = "";
            // 
            // dateTimeFaktura
            // 
            this.dateTimeFaktura.Location = new System.Drawing.Point(209, 389);
            this.dateTimeFaktura.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimeFaktura.Name = "dateTimeFaktura";
            this.dateTimeFaktura.Size = new System.Drawing.Size(299, 22);
            this.dateTimeFaktura.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(139, 593);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Naziv:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(141, 628);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Cena:";
            // 
            // txtKupac
            // 
            this.txtKupac.Location = new System.Drawing.Point(209, 117);
            this.txtKupac.Margin = new System.Windows.Forms.Padding(4);
            this.txtKupac.MaxLength = 50;
            this.txtKupac.Name = "txtKupac";
            this.txtKupac.Size = new System.Drawing.Size(299, 22);
            this.txtKupac.TabIndex = 26;
            // 
            // comboFaktura
            // 
            this.comboFaktura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFaktura.FormattingEnabled = true;
            this.comboFaktura.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboFaktura.Location = new System.Drawing.Point(209, 554);
            this.comboFaktura.Margin = new System.Windows.Forms.Padding(4);
            this.comboFaktura.Name = "comboFaktura";
            this.comboFaktura.Size = new System.Drawing.Size(299, 24);
            this.comboFaktura.TabIndex = 27;
            this.comboFaktura.Tag = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(49, 559);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 20);
            this.label10.TabIndex = 28;
            this.label10.Text = "Izaberite fakturu:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(149, 11);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(157, 39);
            this.label11.TabIndex = 29;
            this.label11.Text = "Plaćanje";
            // 
            // BtnDodajStavku
            // 
            this.BtnDodajStavku.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDodajStavku.Location = new System.Drawing.Point(209, 660);
            this.BtnDodajStavku.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDodajStavku.Name = "BtnDodajStavku";
            this.BtnDodajStavku.Size = new System.Drawing.Size(189, 62);
            this.BtnDodajStavku.TabIndex = 30;
            this.BtnDodajStavku.Text = "Dodaj stavku";
            this.BtnDodajStavku.UseVisualStyleBackColor = true;
            this.BtnDodajStavku.Click += new System.EventHandler(this.BtnDodajStavku_Click);
            // 
            // BtnXMLfajl
            // 
            this.BtnXMLfajl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnXMLfajl.Location = new System.Drawing.Point(1276, 572);
            this.BtnXMLfajl.Margin = new System.Windows.Forms.Padding(4);
            this.BtnXMLfajl.Name = "BtnXMLfajl";
            this.BtnXMLfajl.Size = new System.Drawing.Size(189, 62);
            this.BtnXMLfajl.TabIndex = 31;
            this.BtnXMLfajl.Text = "XML Fajl";
            this.BtnXMLfajl.UseVisualStyleBackColor = true;
            this.BtnXMLfajl.Click += new System.EventHandler(this.BtnXMLfajl_Click);
            // 
            // BtnXMLshema
            // 
            this.BtnXMLshema.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnXMLshema.Location = new System.Drawing.Point(1276, 657);
            this.BtnXMLshema.Margin = new System.Windows.Forms.Padding(4);
            this.BtnXMLshema.Name = "BtnXMLshema";
            this.BtnXMLshema.Size = new System.Drawing.Size(189, 62);
            this.BtnXMLshema.TabIndex = 32;
            this.BtnXMLshema.Text = "XML Shema";
            this.BtnXMLshema.UseVisualStyleBackColor = true;
            this.BtnXMLshema.Click += new System.EventHandler(this.BtnXMLshema_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1655, 731);
            this.Controls.Add(this.BtnXMLshema);
            this.Controls.Add(this.BtnXMLfajl);
            this.Controls.Add(this.BtnDodajStavku);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboFaktura);
            this.Controls.Add(this.txtKupac);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimeFaktura);
            this.Controls.Add(this.comboKupac);
            this.Controls.Add(this.gridStavke);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCenaStavke);
            this.Controls.Add(this.txtNazivStavke);
            this.Controls.Add(this.BtnDodajFakturu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnDodajKupca);
            this.Controls.Add(this.gridFakture);
            this.Controls.Add(this.gridKupci);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAdresa);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Plaćanje";
            ((System.ComponentModel.ISupportInitialize)(this.gridKupci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFakture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridStavke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridKupci;
        private System.Windows.Forms.DataGridView gridFakture;
        private System.Windows.Forms.Button BtnDodajKupca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnDodajFakturu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCenaStavke;
        private System.Windows.Forms.TextBox txtNazivStavke;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView gridStavke;
        private System.Windows.Forms.ComboBox comboKupac;
        private System.Windows.Forms.DateTimePicker dateTimeFaktura;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtKupac;
        private System.Windows.Forms.ComboBox comboFaktura;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BtnDodajStavku;
        private System.Windows.Forms.Button BtnXMLfajl;
        private System.Windows.Forms.Button BtnXMLshema;
    }
}

