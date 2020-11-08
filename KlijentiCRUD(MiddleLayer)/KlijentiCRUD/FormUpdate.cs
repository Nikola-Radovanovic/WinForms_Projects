using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace KlijentiCRUD
{
    public partial class FormUpdate : Form
    {
        public FormUpdate()
        {
            InitializeComponent();
        }

        FormMain fMain;
        public FormUpdate(FormMain formMain) // Prosledjivanje kroz konstruktor(auto-refresh grida)
        {
            InitializeComponent();
            fMain = formMain;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            KlijentiMiddleLayer.ClsDataAccess KlijentiUpdate = new KlijentiMiddleLayer.ClsDataAccess();

            try
            {
                KlijentiUpdate.Dbo_KlijentiUpdate(Convert.ToInt32(txtID.Text),
                                                                  txtIme.Text,
                                                                  txtKontakt.Text,
                                                                  txtGrad.Text,
                                                                  txtZemlja.Text);

                var result = MessageBox.Show("Uspešno ste izmenili informacije o klijentu.",
                                             "Ažuriranje klijenta",
                                             MessageBoxButtons.OK, 
                                             MessageBoxIcon.Asterisk);
                
                if (result == DialogResult.OK)
                {
                    fMain.BtnRefresh_Click(null, null);
                    this.Close();
                } 
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            FormUpdate formUpdate = new FormUpdate();
            this.Close();
        }

        //CURRENCY MANAGER
        private void BtnFirst_Click(object sender, EventArgs e)
        {
            //Cmng.Position = 0;
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            //Cmng.Position--;
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            //Cmng.Position++;
        }

        private void BtnLast_Click(object sender, EventArgs e)
        {
            //KlijentiMiddleLayer.ClsDataAccess KlijentiUpdate = new KlijentiMiddleLayer.ClsDataAccess();
            //Cmng.Position = KlijentiUpdate.Rows.Count - 1;
        }

        private void TB_Scroll(object sender, EventArgs e)
        {
            //Cmng.Position = TB.Value;
        }
    }
}