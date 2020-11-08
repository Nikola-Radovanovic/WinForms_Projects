using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlijentiCRUD
{
    public partial class FormInsert : Form
    {
        public FormInsert()
        {
            InitializeComponent();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            KlijentiMiddleLayer.ClsDataAccess KlijentiInsert = new KlijentiMiddleLayer.ClsDataAccess();

            try
            {
                if(txtIme.Text == string.Empty || txtKontakt.Text == string.Empty || 
                   txtGrad.Text == string.Empty || txtZemlja.Text == string.Empty)
                {
                    MessageBox.Show("Molimo popunite sva polja.");
                }
                else
                {
                    KlijentiInsert.Dbo_KlijentiInsert(txtIme.Text,
                                                      txtKontakt.Text,
                                                      txtGrad.Text,
                                                      txtZemlja.Text);

                    var result = MessageBox.Show("Uspešno ste dodali klijenta.",
                                                 "Dodavanje klijenta",
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Asterisk);

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
            FormInsert formInsert = new FormInsert();
            this.Close();
        }
    }                                                      
}