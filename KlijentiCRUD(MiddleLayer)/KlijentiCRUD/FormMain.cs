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
    public partial class FormMain : Form
    {                           
        public FormMain()
        {
            InitializeComponent();
        }

        //OPEN INSERT DIALOG
        private void BtnInsert_Click(object sender, EventArgs e)
        {
            FormInsert formInsert = new FormInsert();
            formInsert.ShowDialog();
            BtnRefresh_Click(null, null);
        }

        //OPEN UPDATE DIALOG
        public void BtnUpdate_Click(object sender, EventArgs e)
        {
            FormUpdate formUpdate = new FormUpdate(this);

            try
            {
                if (GridKlijenti.Rows.Count == 0) // Prebrojava redove u gridu
                {
                    MessageBox.Show("Niste odabrali klijenta za ažuriranje.",
                                    "Ažuriranje klijenta",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                else
                {
                    formUpdate.txtID.Text = GridKlijenti.CurrentRow.Cells[0].Value.ToString();
                    formUpdate.txtIme.Text = GridKlijenti.CurrentRow.Cells[1].Value.ToString();
                    formUpdate.txtKontakt.Text = GridKlijenti.CurrentRow.Cells[2].Value.ToString();
                    formUpdate.txtGrad.Text = GridKlijenti.CurrentRow.Cells[3].Value.ToString();
                    formUpdate.txtZemlja.Text = GridKlijenti.CurrentRow.Cells[4].Value.ToString();
                    formUpdate.Show();
                }
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            } 
        }

        //DELETE
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            KlijentiMiddleLayer.ClsDataAccess KlijentiDelete = new KlijentiMiddleLayer.ClsDataAccess();

            try
            {
                if (GridKlijenti.Rows.Count == 0) // Prebrojava redove u gridu
                {
                    MessageBox.Show("Niste odabrali klijenta za brisanje.",
                                    "Ažuriranje klijenta",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                else
                {
                    var gridSlog = GridKlijenti.SelectedRows[0].Cells[0].Value;

                    var result = MessageBox.Show("Da li ste sigurni da želite obrisati klijenta?",
                                                 "Brisanje klijenta",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        KlijentiDelete.Dbo_KlijentiDelete(Convert.ToInt32(gridSlog));
                        BtnRefresh_Click(null, null);
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        //READ
        public void BtnRefresh_Click(object sender, EventArgs e)
        {
            KlijentiMiddleLayer.ClsDataAccess KlijentiRead = new KlijentiMiddleLayer.ClsDataAccess();

            try
            {
                GridKlijenti.DataSource = KlijentiRead.Dbo_KlijentiRead();
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }          
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            KlijentiMiddleLayer.ClsDataAccess Clear = new KlijentiMiddleLayer.ClsDataAccess();
            GridKlijenti.DataSource = Clear.Clear();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}