using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVPProjekat
{
    public partial class LogInForm : Form
    {
        Zaposleni z;
        DateTime dt;
        int day;
        public LogInForm()
        {
            z = new Zaposleni();
            InitializeComponent();
            dt = DateTime.Now;
            day = dt.Day;
            RegistryKey regkey = Registry.CurrentUser.OpenSubKey(@"Control Panel\International", true);
            regkey.SetValue("sShortDate", "MM/dd/yyyy");

        }

        private void LogInForm_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;

            label3.AutoSize = false;
            label3.Width = 300;
            label3.Height = 20;
            label3.Text="DOBRODOŠLI!";
            

        }

        private void txtKorisnicko_OnValueChanged(object sender, EventArgs e) //za promenu vrednosti u polju
        {
            if (txtKorisnicko.Text.Equals(""))  //ukoliko je prazno
            {
                label1.Visible = true;
                label1.ForeColor = Color.Red;
                label1.Text = "Popunite polje!";
            }
            else
            {
                label1.Visible = false;
            }
        }

        private void txtLozinka_OnValueChanged(object sender, EventArgs e)
        {
            if (txtLozinka.Text.Equals(""))  //ukoliko je prazno
            {
                label2.Visible = true;
                label2.ForeColor = Color.Red;
                label2.Text = "Popunite polje!";
            }
            else
            {
                label2.Visible = false;
                txtLozinka.isPassword = true;
            }
        }
        public void resetFields()
        {
            txtKorisnicko.Text = "";
            txtLozinka.Text = "";
        }
        public bool Validacija()
        {
            if (txtKorisnicko.Text == "")
            {
                MessageBox.Show("Morate uneti korisničko ime.", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                resetFields();
                return false;
            }

            if (txtLozinka.Text == "")
            {
                MessageBox.Show("Morate uneti lozinku.", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                resetFields();
                return false;
            }
            return true;
        }

        private void PrijaviSe()
        {
            try
            {
                if (Validacija()) // da li su popunjena polja
                {
                    if (z.Prijava(txtKorisnicko.Text, txtLozinka.Text))
                    {
                         if (Zaposleni.tip == "Radnik") 
                        {
                            if (day < 10)
                            {
                                MessageBox.Show("Uspešno ste se prijavili.", "Prijava!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide();
                                RadnikForma fm2 = new RadnikForma(z.idZaposlenog);
                                fm2.ShowDialog();
                                System.Environment.Exit(0);
                            }
                            else
                                MessageBox.Show("Radnici se mogu prijaviti samo izmedju 1. i 10. dana u mesecu.");
                        }
                        else
                        {
                            MessageBox.Show("Uspešno ste se prijavili.", "Prijava!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            Form3 fm3 = new Form3();
                            fm3.ShowDialog();
                            System.Environment.Exit(0);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Uneli ste pogrešne podatke.", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        resetFields();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtKorisnicko_KeyDown(object sender, KeyEventArgs e) //za prijavu na enter
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    PrijaviSe();
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void bunifuThinButton21_Click(object sender, EventArgs e) // za prijavu na dugme
        {
            PrijaviSe();
        }  
    }
}
