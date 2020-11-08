using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KupciFakture_disconnected_
{
    public partial class Form1 : Form
    {
        private readonly DataSet Placanje = new DataSet("Placanje");
        private readonly DataTable Kupci = new DataTable("Kupci");
        private readonly DataTable Fakture = new DataTable("Fakture");
        private readonly DataTable FaktureStavke = new DataTable("FaktureStavke");

        public Form1()
        {
            InitializeComponent();

            //KUPCI
            DataColumn KupacID = new DataColumn("KupacID")
            {
                DataType = typeof(int),
                AutoIncrement = true,
                AutoIncrementSeed = 1,
                AutoIncrementStep = 1,
                AllowDBNull = false,
                ReadOnly = true
            };

            DataColumn NazivKupca = new DataColumn("NazivKupca")
            {
                DataType = typeof(string),
                MaxLength = 50,
                AllowDBNull = false,
                ReadOnly = true
            };

            DataColumn Adresa = new DataColumn("Adresa")
            {
                DataType = typeof(string),
                MaxLength = 200,
                AllowDBNull = true,
                ReadOnly = true
            };

            Kupci.Columns.Add(KupacID);
            Kupci.Columns.Add(NazivKupca);
            Kupci.Columns.Add(Adresa);
            Kupci.PrimaryKey = new DataColumn[] { KupacID };

            //Kupci DataBinding
            txtKupac.DataBindings.Clear();
            txtAdresa.DataBindings.Clear();

            txtKupac.DataBindings.Add("Text", Kupci, "NazivKupca");
            txtAdresa.DataBindings.Add("Text", Kupci, "Adresa");

            //DataSet
            Placanje.Tables.Add(Kupci);
            gridKupci.DataSource = Kupci;


            //FAKTURE
            DataColumn FakturaID = new DataColumn("FakturaID")
            {
                DataType = typeof(int),
                AutoIncrement = true,
                AutoIncrementSeed = 1,
                AutoIncrementStep = 1,
                AllowDBNull = false,
                ReadOnly = true
            };

            DataColumn KupacFK = new DataColumn("KupacID")
            {
                DataType = typeof(int),
                AllowDBNull = false,
                ReadOnly = true
            };

            DataColumn Datum = new DataColumn("Datum")
            {
                DataType = typeof(DateTime),
                AllowDBNull = false,
                DefaultValue = DateTime.Now,
                ReadOnly = true
            };

            Fakture.Columns.Add(FakturaID);
            Fakture.Columns.Add(KupacFK);
            Fakture.Columns.Add(Datum);
            Fakture.PrimaryKey = new DataColumn[] { FakturaID };

            comboKupac.DataBindings.Clear();
            dateTimeFaktura.DataBindings.Clear();

            comboKupac.DataBindings.Add("Text", Fakture, "KupacID");
            dateTimeFaktura.DataBindings.Add("Text", Fakture, "Datum");
            
            comboKupac.DataSource = Kupci;
            comboKupac.ValueMember = "KupacID";
            comboKupac.DisplayMember = "NazivKupca";

            Placanje.Tables.Add(Fakture);
            gridFakture.DataSource = Fakture;

            DataRelation RelacijaKupciFakture = new DataRelation("RelacijaKupciFakture",
                                                    Kupci.Columns["KupacID"],
                                                    Fakture.Columns["KupacID"], true);

            Placanje.Relations.Add(RelacijaKupciFakture);

            ForeignKeyConstraint FKconstraint1 = (ForeignKeyConstraint)Fakture.Constraints["RelacijaKupciFakture"];
            FKconstraint1.UpdateRule = Rule.None;
            FKconstraint1.DeleteRule = Rule.None;


            //FAKTURE-STAVKE
            DataColumn FakturaFK = new DataColumn("FakturaID")
            {
                DataType = typeof(int),
                AllowDBNull = false,
                ReadOnly = true
            };

            DataColumn NazivStavke = new DataColumn("NazivStavke")
            {
                DataType = typeof(string),
                MaxLength = 40,
                AllowDBNull = false,
                ReadOnly = true
            };

            DataColumn CenaStavke = new DataColumn("CenaStavke")
            {
                DataType = typeof(decimal),
                AllowDBNull = false,
                ReadOnly = true
            };

            FaktureStavke.Columns.Add(FakturaFK);
            FaktureStavke.Columns.Add(NazivStavke);
            FaktureStavke.Columns.Add(CenaStavke);
            FaktureStavke.PrimaryKey = new DataColumn[]  // Kompozitni primarni kljuc
            {
                FaktureStavke.Columns["FakturaID"],
                FaktureStavke.Columns["NazivStavke"]
            };

            comboFaktura.DataBindings.Clear();
            txtNazivStavke.DataBindings.Clear();
            txtCenaStavke.DataBindings.Clear();

            comboFaktura.DataBindings.Add("Text", FaktureStavke, "FakturaID");
            txtNazivStavke.DataBindings.Add("Text", FaktureStavke, "NazivStavke");
            txtCenaStavke.DataBindings.Add("Text", FaktureStavke, "CenaStavke");

            comboFaktura.DataSource = Fakture;
            comboFaktura.ValueMember = "FakturaID";
            comboFaktura.DisplayMember = "FakturaID";

            Placanje.Tables.Add(FaktureStavke);
            gridStavke.DataSource = FaktureStavke;

            DataRelation RelacijaFaktureStavke = new DataRelation("RelacijaFaktureStavke",
                                                    Fakture.Columns["FakturaID"],
                                                    FaktureStavke.Columns["FakturaID"], true);

            Placanje.Relations.Add(RelacijaFaktureStavke);

            ForeignKeyConstraint FKconstraint2 = (ForeignKeyConstraint)FaktureStavke.Constraints["RelacijaFaktureStavke"];
            FKconstraint2.UpdateRule = Rule.None;
            FKconstraint2.DeleteRule = Rule.None;
        }

        private void BtnDodajKupca_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtKupac.Text == string.Empty)
                {
                    MessageBox.Show("Unesite ime kupca.");
                }
                else
                {
                    Kupci.Rows.Add(null, txtKupac.Text, txtAdresa.Text);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void BtnDodajFakturu_Click(object sender, EventArgs e)
        {
            try
            {
                if (dateTimeFaktura.Value > DateTime.Now)
                {
                    MessageBox.Show("Uneti datum je neispravan!");
                }
                else
                {
                    Fakture.Rows.Add(null, comboKupac.SelectedValue, dateTimeFaktura.Text);
                }
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void BtnDodajStavku_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNazivStavke.Text == string.Empty || txtCenaStavke.Text == string.Empty)
                {
                    MessageBox.Show("Unesite naziv stavke i njenu cenu.");
                }
                else
                {
                    FaktureStavke.Rows.Add(comboFaktura.SelectedValue, txtNazivStavke.Text, txtCenaStavke.Text);
                }
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void BtnXMLfajl_Click(object sender, EventArgs e)
        {
            try
            {
                Placanje.WriteXml(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "//XMLdata.xml");
                MessageBox.Show("Sacuvan XML fajl.");
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void BtnXMLshema_Click(object sender, EventArgs e)
        {
            try
            {
                Placanje.WriteXmlSchema(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "//XMLschema.xsd");
                MessageBox.Show("Sacuvana XML schema.");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
    }
}
