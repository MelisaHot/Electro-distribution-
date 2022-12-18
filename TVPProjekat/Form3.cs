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
using Microsoft.Win32;

namespace TVPProjekat
{
    public partial class Form3 : Form
    {
        Zaposleni z;
        int idzaposlenog = -1; //stavilasam -1 jer indeksi pocinju id 0
        string starokorisnicko = ""; //za proveru da l je promenjeno korisnicko ime posto mora da je jedinstveno
        Vlasnici ucv;
        StrujomerUCcs ucs;
        CeneUC ucc;
        string stariJMBG = "";
        public Form3()
        {
            z = new Zaposleni();
            InitializeComponent();
            RegistryKey regkey = Registry.CurrentUser.OpenSubKey(@"Control Panel\International", true);
            regkey.SetValue("sShortDate", "MM/dd/yyyy");
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tVPProjekatDataSet.Zaposleni' table. You can move, or remove it, as needed.
            this.zaposleniTableAdapter.Fill(this.tVPProjekatDataSet.Zaposleni); 
            z.Fill(zaposleniDataGridView);
            ucv = new Vlasnici();
            cbTip.SelectedIndex = 1;

            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;

            panel2.Visible = false;
        


        }

        private bool Validation()
        {
            if (txtIme.Text == "" || txtPrezime.Text == "" || txtAdresa.Text == "" || txtTelefon.Text == "" || txtKorisnicko.Text == "" || txtJMBG.Text == "" )
            {
                MessageBox.Show("Morate popuniti sva polja!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtJMBG.Text.Length != 13) {
                MessageBox.Show("JMBG mora imati 13 cifata!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }

        private void resetFields()
        {
            txtIme.Text = "";
            txtPrezime.Text = "";
            txtAdresa.Text = "";
            txtTelefon.Text = "";
            txtJMBG.Text = "";
            txtLozinka.Text = "";
            txtKorisnicko.Text = "";
            cbTip.SelectedIndex = 1;
            idzaposlenog = -1;
            starokorisnicko = "";
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validation() || txtLozinka.Text == "" )
                {
                   // MessageBox.Show("Morate popuniti sva polja.", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else  
                {
                    if (z.PretraziKorisnicko(txtKorisnicko.Text))
                    {
                        if (z.PretraziJMBG(txtJMBG.Text))
                        {
                            z.DodajNovogZaposlenog(txtIme.Text, txtPrezime.Text, txtAdresa.Text, txtTelefon.Text, cbTip.GetItemText(cbTip.SelectedItem), txtKorisnicko.Text, z.Hash(txtLozinka.Text), txtJMBG.Text);
                            MessageBox.Show("Uspešno dodavanje novog zaposlenog.");
                            z.Fill(zaposleniDataGridView);
                            resetFields();
                        } else
                        {
                            MessageBox.Show("JMBG već postoji. Unesite drugi JMBG.", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtJMBG.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Korisničko ime već postoji. Unesite drugo korisničko ime.", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtKorisnicko.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtJMBG_KeyPress(object sender, KeyPressEventArgs e) // da moze da unosi samo brojeve
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void zaposleniBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.zaposleniBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tVPProjekatDataSet);
        }

        private void zaposleniDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e) // da popuni polja klikom u tabelu
        {
            try
            {
                idzaposlenog = Convert.ToInt32(zaposleniDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtIme.Text = zaposleniDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtPrezime.Text = zaposleniDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtAdresa.Text = zaposleniDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtTelefon.Text = zaposleniDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                string tip = zaposleniDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                if (tip == "Administrator")
                    cbTip.Text = "Administrator";
                else
                    cbTip.Text = "Radnik";
                txtKorisnicko.Text = zaposleniDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                starokorisnicko= zaposleniDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtJMBG.Text = zaposleniDataGridView.Rows[e.RowIndex].Cells[8].Value.ToString();

                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void zaposleniDataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            resetFields();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            try
            {
                if (idzaposlenog != -1 || Validation()) 
                {
                    if (starokorisnicko.ToLower() != txtKorisnicko.Text.ToLower())
                    {
                        if (z.PretraziKorisnicko(txtKorisnicko.Text))
                        {
                            if (stariJMBG.ToLower() != txtJMBG.Text.ToLower())
                            {
                                if (z.PretraziJMBG(txtJMBG.Text))
                                {
                                    if (txtLozinka.Text != string.Empty)
                                    {
                                        z.AzurirajZaposlenog(txtIme.Text, txtPrezime.Text, txtAdresa.Text, txtTelefon.Text, cbTip.Text, txtKorisnicko.Text, txtLozinka.Text, txtJMBG.Text, idzaposlenog);
                                    }
                                    else
                                    {
                                        z.AzurirajZaposlenog(txtIme.Text, txtPrezime.Text, txtAdresa.Text, txtTelefon.Text, cbTip.Text, txtKorisnicko.Text, txtJMBG.Text, idzaposlenog);
                                    }
                                    MessageBox.Show("Uspešno ažuriranje podataka o zaposlenom.");
                                    z.Fill(zaposleniDataGridView);
                                    resetFields();
                                }
                            }
                        }
                    }
                    else
                    {
                        if (txtLozinka.Text != string.Empty)
                        {
                            z.AzurirajZaposlenog(txtIme.Text, txtPrezime.Text, txtAdresa.Text, txtTelefon.Text, cbTip.Text, txtKorisnicko.Text, txtLozinka.Text, txtJMBG.Text, idzaposlenog);
                        }
                        else
                        {
                            z.AzurirajZaposlenog(txtIme.Text, txtPrezime.Text, txtAdresa.Text, txtTelefon.Text, cbTip.Text, txtKorisnicko.Text, txtJMBG.Text, idzaposlenog);
                        }
                        MessageBox.Show("Uspešno ažuriranje podataka o zaposlenom.");
                        z.Fill(zaposleniDataGridView);
                        resetFields();
                    }
                }
                else
                    MessageBox.Show("Morate selektovati zaposlenog u tabeli", "Greška",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e) //funkcija za brisanje zaposlenog
        {
            try
            {
                if (idzaposlenog != -1) 
                {
                    z.ObrisiZaposlenog(idzaposlenog);
                    MessageBox.Show("Uspešno brisanje podataka o zaposlenom.");
                    z.Fill(zaposleniDataGridView);
                    resetFields();
                }
                else
                    MessageBox.Show("Morate selektovati zaposlenog u tabeli", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtIme_OnValueChanged(object sender, EventArgs e)
        {
            if (txtIme.Text.Equals(""))  //ukoliko je prazno
            {

                label2.Visible = true;
                label2.ForeColor = Color.Red;
                label2.Text = "Popunite polje!";

            }
            else
            {
                label2.Visible = false;
            }
        }

        private void txtPrezime_OnValueChanged(object sender, EventArgs e)
        {
            if (txtPrezime.Text.Equals(""))  //ukoliko je prazno
            {

                label3.Visible = true;
                label3.ForeColor = Color.Red;
                label3.Text = "Popunite polje!";

            }
            else
            {

                label3.Visible = false;
            }
        }

        private void txtAdresa_OnValueChanged(object sender, EventArgs e)
        {
            if (txtAdresa.Text.Equals(""))  //ukoliko je prazno
            {
                label4.Visible = true;
                label4.ForeColor = Color.Red;
                label4.Text = "Popunite polje!";
            }
            else
            {
                label4.Visible = false;
            }
        }

        private void txtTelefon_OnValueChanged(object sender, EventArgs e)
        {
            if (txtTelefon.Text.Equals(""))  //ukoliko je prazno
            {
                label5.Visible = true;
                label5.ForeColor = Color.Red;
                label5.Text = "Popunite polje!";
            }
            else
            {
                label5.Visible = false;
            }
        }

        private void txtJMBG_OnValueChanged(object sender, EventArgs e)
        {
            if (txtJMBG.Text.Equals(""))  //ukoliko je prazno
            {
                label6.Visible = true;
                label6.ForeColor = Color.Red;
                label6.Text = "Popunite polje!";
            }
            else
            {
                label6.Visible = false;
            }
        }

        private void txtKorisnicko_OnValueChanged(object sender, EventArgs e)
        {
            if (txtKorisnicko.Text.Equals(""))  //ukoliko je prazno
            {

                label7.Visible = true;
                label7.ForeColor = Color.Red;
                label7.Text = "Popunite polje!";

            }
            else
            {

                label7.Visible = false;
            }
        }

        private void txtLozinka_OnValueChanged(object sender, EventArgs e)
        {
            if (txtLozinka.Text.Equals(""))  //ukoliko je prazno
            {

                label8.Visible = true;
                label8.ForeColor = Color.Red;
                label8.Text = "Popunite polje!";

            }
            else
            {

                label8.Visible = false;
                txtLozinka.isPassword = true;
            }

        }

        private void btnVlasnici_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            ucv = new Vlasnici();
            //ucv.Dock = DockStyle.Fill;
            panel2.Controls.Clear();
            panel2.Controls.Add(ucv);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Visible = false;
            panel1.Visible = true;
        }

        private void btnStrujomeri_Click(object sender, EventArgs e)
        {
            ucs = new StrujomerUCcs();
            panel2.Visible = true;
            panel2.Controls.Clear();
            panel2.Controls.Add(ucs);
        }

        private void btnCene_Click(object sender, EventArgs e)
        {
            ucc = new CeneUC();
            panel2.Visible = true;
            panel2.Controls.Clear();
            panel2.Controls.Add(ucc);
        }

        private void txtPretraga_KeyPress(object sender, EventArgs e)
        {
            z.Pretrazi(zaposleniDataGridView, txtPretraga.text);
        }
        StanjaStrujomera ucstanja;
        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            ucstanja = new StanjaStrujomera();
            panel2.Visible = true;
            panel2.Controls.Clear();
            panel2.Controls.Add(ucstanja);
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogInForm fm1 = new LogInForm();
            fm1.ShowDialog();
            System.Environment.Exit(0);
        }
    }

    
}


