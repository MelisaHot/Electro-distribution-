using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace TVPProjekat
{
    public partial class StrujomerUCcs : UserControl
    {
        StrujomerClass stc = new StrujomerClass();
        VlasniciClass vls = new VlasniciClass();
        Zaposleni zap = new Zaposleni();
        private bool selektovano = false;
        private int id = -1;
        string staribrstujomera = "";
        public StrujomerUCcs()
        {
            InitializeComponent();
            stc.Fill(strujomerdataGridView);
            txtVlasnik.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtVlasnik.AutoCompleteSource = AutoCompleteSource.CustomSource;
            vls.AutoCompleteVlasnik(txtVlasnik.Text, txtVlasnik);
            txtZaposleni.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtZaposleni.AutoCompleteSource = AutoCompleteSource.CustomSource;
            zap.AutoCompleteZaposleni(txtZaposleni.Text, txtZaposleni);
            

            RegistryKey regkey = Registry.CurrentUser.OpenSubKey(@"Control Panel\International", true);
            regkey.SetValue("sShortDate", "MM/dd/yyyy");

            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
           
            lbltn.Visible = false;
            lbltv.Visible = false;
            lblnn.Visible = false;
            lblnv.Visible = false;
            lblZap.Visible = false;

            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;

        }

        private void strujomerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.strujomerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tVPProjekatDataSet);

        }

        private bool selektovan()
        {
            if (selektovano == false)
                return false;
            else
                return true;
        }


        private bool dodelaVrednostiNovi()
        {
            try
            {
                stc.brstrujomera = txtBrojStrujomera.Text;
                if (vls.NadjiVlasnika(txtVlasnik.Text))
                    stc.idvlasnik = vls.idVlasnika;
                else
                    return false;
                stc.idzaposleni = -1;
                stc.datum = dateTimePicker1.Value;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return true;
        }

        private bool dodelaVrednostiAzuriraj()
        {
            try
            {
                stc.id = id;
                stc.brstrujomera = txtBrojStrujomera.Text;
                if (vls.NadjiVlasnika(txtVlasnik.Text))
                    stc.idvlasnik = vls.idVlasnika;
                else
                    return false;
                if (zap.NadjiZaposlenog(txtZaposleni.Text))
                    stc.idzaposleni = zap.idZaposlenog;
                else
                    return false;
                stc.datum = dateTimePicker1.Value;

                stc.trenutnonize = txtTrenutnoNize.Text;
                stc.trenutnovise = txtTrenutnoVise.Text;
                stc.novonize = txtNovoNize.Text;
                stc.novovise = txtNovoVise.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return true;
        }

        private bool ValidationDodaj()
        {
            if(txtBrojStrujomera.Text==string.Empty)
            {
                MessageBox.Show("Morate uneti broj strujomera", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
            }
            if(txtVlasnik.Text == string.Empty)
            {
                MessageBox.Show("Morate uneti vlasnika. ","Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool ValidacijaAzuriraj()
        {
            if (txtBrojStrujomera.Text == string.Empty)
            {
                MessageBox.Show("Morate uneti broj strujomera", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtVlasnik.Text == string.Empty)
            {
                MessageBox.Show("Morate uneti vlasnika. ", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(txtZaposleni.Text == string.Empty)
            {
                MessageBox.Show("Morate uneti zaposlenog", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(txtTrenutnoNize.Text==string.Empty)
            {
                MessageBox.Show("Morate uneti trenutno stanje niže tarife.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtTrenutnoVise.Text == string.Empty)
            {
                MessageBox.Show("Morate uneti trenutno stanje više tarife.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtNovoNize.Text == string.Empty)
            {
                MessageBox.Show("Morate uneti novo stanje niže tarife.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtNovoVise.Text == string.Empty)
            {
                MessageBox.Show("Morate uneti novo stanje više tarife.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void resetFields()
        {
            id = -1;
            txtBrojStrujomera.Text = "";
            txtVlasnik.Text = "";
            txtZaposleni.Text = "";
            txtNovoNize.Text = "";
            txtNovoVise.Text = "";
            txtTrenutnoNize.Text = "";
            txtTrenutnoVise.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            txtTrenutnoVise.Visible = false;
            txtTrenutnoNize.Visible = false;
            txtNovoNize.Visible = false;
            txtNovoVise.Visible = false;
            txtZaposleni.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
           
            lbltn.Visible = false;
            lbltv.Visible = false;
            lblnn.Visible = false;
            lblnv.Visible = false;
            lblZap.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;


        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                if(ValidationDodaj())
                {
                    if (dodelaVrednostiNovi())
                    {
                        if (stc.ProveriBrojStrujomera())
                        {
                            stc.DodajStrujomer();
                            
                            MessageBox.Show("Uspesno");
                            resetFields();
                            stc.Fill(strujomerdataGridView);
                        }
                    }
                }  
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtVlasnik_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtZaposleni_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void strujomerdataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selektovano = true;
            id = Convert.ToInt32(strujomerdataGridView.Rows[e.RowIndex].Cells[0].Value);
            txtBrojStrujomera.Text = strujomerdataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            staribrstujomera = txtBrojStrujomera.Text;
            txtTrenutnoNize.Text = strujomerdataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtTrenutnoVise.Text = strujomerdataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtNovoNize.Text = strujomerdataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtNovoVise.Text = strujomerdataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(strujomerdataGridView.Rows[e.RowIndex].Cells[8].Value.ToString()); //debil
            txtVlasnik.Text = strujomerdataGridView.Rows[e.RowIndex].Cells[11].Value.ToString();
            txtZaposleni.Text = strujomerdataGridView.Rows[e.RowIndex].Cells[14].Value.ToString();

            txtTrenutnoVise.Visible = true;
            txtTrenutnoNize.Visible = true;
            txtNovoNize.Visible = true;
            txtNovoVise.Visible = true;
            txtZaposleni.Visible = true;

            lbltn.Visible = true;
            lbltv.Visible = true;
            lblnn.Visible = true;
            lblnv.Visible = true;
            lblZap.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = true;


        }

        private void strujomerdataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selektovano = false;
            resetFields();
      
            
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (selektovan())
            {
                stc.id = id;
                stc.ObrisiZaposlenog();
                MessageBox.Show("Uspesno");
                stc.Fill(strujomerdataGridView);
                resetFields();
            }

        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidacijaAzuriraj())
                {
                    if (dodelaVrednostiAzuriraj())
                    {
                        if (staribrstujomera.ToLower() != txtBrojStrujomera.Text.ToLower())
                        {
                            if (stc.ProveriBrojStrujomera())
                            {
                                stc.AzurirajStrujomer();
                                MessageBox.Show("Uspesno");
                                resetFields();
                                stc.Fill(strujomerdataGridView);
                            }
                        }
                        else
                        {
                            stc.AzurirajStrujomer();
                            MessageBox.Show("Uspesno");
                            resetFields();
                            stc.Fill(strujomerdataGridView);
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtPretraga_KeyPress(object sender, EventArgs e)
        {
            stc.PretraziStrujomer(strujomerdataGridView, txtPretraga.text);
        }

        private void txtBrojStrujomera_OnValueChanged(object sender, EventArgs e)
        {
            if (txtBrojStrujomera.Text.Equals(""))  //ukoliko je prazno
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

        private void txtVlasnik_TextChanged(object sender, EventArgs e)
        {
            if (txtVlasnik.Text.Equals(""))  //ukoliko je prazno
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

        private void txtZaposleni_TextChanged(object sender, EventArgs e)
        {
            if (txtZaposleni.Text.Equals(""))  //ukoliko je prazno
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
    }
}
