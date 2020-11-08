using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO.NET_CRUD
{
    public partial class FormMain : Form
    {
        DbModel dbModel = new DbModel();

        public FormMain()
        {
            InitializeComponent();

            GridKlijenti.DataSource = dbModel.Klijenti.ToList<Klijent>();
            GridServisi.DataSource = dbModel.Servisi.ToList<Servis>();

            GridKlijenti.Columns[5].Visible = false;
            GridServisi.Columns[4].Visible = false;
        }
        
        // Refresh After Update Klijenti
        private void RefreshAfterUpdateKlijent()
        {
            txtKlijentID.Text = string.Empty;
            txtKijent.Text = string.Empty;
            txtRegistracija.Text = string.Empty;
            txtAdresa.Text = string.Empty;
            txtKomentar.Text = string.Empty;
        }

        // Refresh After Update Servisi
        private void RefreshAfterUpdateServisi()
        {
            txtServisID.Text = string.Empty;
            datePicker.Text = string.Empty;
            txtUsluga.Text = string.Empty;
            txtKlijentFK.Text = string.Empty;
        }

        // KLIJENTI

        // Select(Refresh)
        private void BtnSelectKlijenti_Click(object sender, EventArgs e)
        { 
            try
            {
                GridKlijenti.DataSource = dbModel.Klijenti.ToList<Klijent>();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        // Insert
        private void BtnInsertKlijenti_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtKijent.Text == string.Empty ||
                txtAdresa.Text == string.Empty ||
                txtRegistracija.Text == string.Empty)
                {
                    MessageBox.Show("Unesite ime klijenta, adresu i registraciju",
                                    "Obaveštenje",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                else
                {
                    Klijent dodajKlijenta = new Klijent
                    {
                        NazivKlijenta = txtKijent.Text,
                        RegistarskiBroj = txtRegistracija.Text,
                        Kontakt = txtAdresa.Text,
                        DodatniKomentar = txtKomentar.Text
                    };

                    dbModel.Klijenti.Add(dodajKlijenta);
                    dbModel.SaveChanges();
                    BtnSelectKlijenti_Click(null, null);
                    RefreshAfterUpdateKlijent();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            } 
        }

        // Update
        private void GridKlijenti_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indexRow = e.RowIndex;
            DataGridViewRow row = GridKlijenti.Rows[indexRow];

            txtKlijentID.Text = row.Cells[0].Value.ToString();
            txtKijent.Text = row.Cells[1].Value.ToString();
            txtRegistracija.Text = row.Cells[2].Value.ToString();
            txtAdresa.Text = row.Cells[3].Value.ToString();
            txtKomentar.Text = row.Cells[4].Value.ToString();
        }
        private void BtnUpdateKlijent_Click(object sender, EventArgs e)
        {
            try
            {
                int klijentID = Convert.ToInt32(txtKlijentID.Text);
                var klijentCompare = dbModel.Klijenti.SingleOrDefault(k => k.KlijentId == klijentID);

                if (klijentCompare != null)
                {
                    Klijent dodajKlijenta = new Klijent
                    {
                        KlijentId = Convert.ToInt32(txtKlijentID.Text),
                        NazivKlijenta = txtKijent.Text,
                        RegistarskiBroj = txtRegistracija.Text,
                        Kontakt = txtAdresa.Text,
                        DodatniKomentar = txtKomentar.Text
                    };

                    dbModel.Klijenti.AddOrUpdate(dodajKlijenta);
                    dbModel.SaveChanges();
                    BtnSelectKlijenti_Click(null, null);
                    RefreshAfterUpdateKlijent();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        // Delete
        private void BtnDeleteKlijent_Click(object sender, EventArgs e)
        {
            try
            {
                int klijentId = Convert.ToInt32(txtKlijentID.Text);
                var findKlijent = dbModel.Klijenti.Where(k => k.KlijentId == klijentId).FirstOrDefault();

                if (findKlijent != null)
                {
                    dbModel.Klijenti.Remove(findKlijent);
                    dbModel.SaveChanges();
                    BtnSelectKlijenti_Click(null, null);
                    RefreshAfterUpdateKlijent();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }


        // SERVISI

        // Select(Refresh)
        private void BtnSelectServisi_Click(object sender, EventArgs e)
        {
            try
            {
                GridServisi.DataSource = dbModel.Servisi.ToList<Servis>();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }                                
        }

        // Insert
        private void BtnInsertServisi_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsluga.Text == string.Empty ||
                txtKlijentFK.Text == string.Empty)
                {
                    MessageBox.Show("Unesite naziv usluge i ID klijenta",
                                    "Obaveštenje",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                else
                {
                    Servis dodajServis = new Servis
                    {
                        DatumServisa = Convert.ToDateTime(datePicker.Text),
                        OpisUsluge = txtUsluga.Text,
                        KlijentId = Convert.ToInt32(txtKlijentFK.Text)
                    };

                    // Provera validnosti KlijentFK
                    int klijentId = dodajServis.KlijentId;
                    var klijentCompare = dbModel.Klijenti.SingleOrDefault(k => k.KlijentId == klijentId);
                    
                    if (klijentCompare == null)
                    {
                        MessageBox.Show("Unesite validan ID klijenta", 
                                        "Obaveštenje", 
                                        MessageBoxButtons.OK, 
                                        MessageBoxIcon.Information);
                        return;
                    }

                    // Provera datuma
                    var datum = Convert.ToDateTime(datePicker.Text);
                    if (datum < DateTime.Now.Date)
                    {
                        MessageBox.Show("Unesite validan datum", 
                                        "Obaveštenje", 
                                        MessageBoxButtons.OK, 
                                        MessageBoxIcon.Information);
                        return;
                    }

                    dbModel.Servisi.Add(dodajServis);
                    dbModel.SaveChanges();
                    BtnSelectServisi_Click(null, null);
                    RefreshAfterUpdateServisi();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        // Update
        private void GridServisi_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {  
            int indexRow = e.RowIndex;
            DataGridViewRow row = GridServisi.Rows[indexRow];

            txtServisID.Text = row.Cells[0].Value.ToString();
            datePicker.Text = row.Cells[1].Value.ToString();
            txtUsluga.Text = row.Cells[2].Value.ToString();
            txtKlijentFK.Text = row.Cells[3].Value.ToString();
        }
        private void BtnUpdateServis_Click(object sender, EventArgs e)
        {
            try
            {
                var servisID = Convert.ToInt32(txtServisID.Text);
                var servisCompare = dbModel.Servisi.SingleOrDefault(s => s.ServisId == servisID);

                if (servisCompare == null)
                {
                    MessageBox.Show("Servis ne postoji!",
                                            "Obaveštenje",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    Servis dodajServis = new Servis
                    {
                        ServisId = Convert.ToInt32(txtServisID.Text),
                        DatumServisa = Convert.ToDateTime(datePicker.Text),
                        OpisUsluge = txtUsluga.Text,
                        KlijentId = Convert.ToInt32(txtKlijentFK.Text)
                    };

                    // Provera validnosti KlijentFK
                    var klijentId = dodajServis.KlijentId;
                    var klijentCompare = dbModel.Klijenti.SingleOrDefault(k => k.KlijentId == klijentId);

                    if (klijentCompare == null)
                    {
                        MessageBox.Show("Unesite validan ID klijenta",
                                        "Obaveštenje",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        return;
                    }

                    // Provera datuma
                    var datum = Convert.ToDateTime(datePicker.Text);
                    if (datum < DateTime.Now.Date)
                    {
                        MessageBox.Show("Unesite validan datum",
                                        "Obaveštenje",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        return;
                    }

                    dbModel.Servisi.AddOrUpdate(dodajServis);
                    dbModel.SaveChanges();
                    BtnSelectServisi_Click(null, null);
                    RefreshAfterUpdateServisi();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        // Delete
        private void BtnDeleteServis_Click(object sender, EventArgs e)
        {
            try
            {
                var servisId = Convert.ToInt32(txtServisID.Text);
                var findServis = dbModel.Servisi.Where(s => s.ServisId == servisId).FirstOrDefault();

                if (findServis != null)
                {
                    dbModel.Servisi.Remove(findServis);
                    dbModel.SaveChanges();
                    BtnSelectServisi_Click(null, null);
                    RefreshAfterUpdateServisi();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        } 
    }
}
