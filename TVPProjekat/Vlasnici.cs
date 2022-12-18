using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVPProjekat
{
    public partial class Vlasnici : UserControl
    {
        VlasniciClass v;
        int idVlasnika = -1;
        string stariJMBG = "";

        public Vlasnici()
        {
            v = new VlasniciClass(); 
         
            InitializeComponent();
            v.Fill(vlasnikDataGridView);

            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            
        }
        private void Vlasnici_Load(object sender, EventArgs e)
        {
            this.vlasnikTableAdapter.Fill(tVPProjekatDataSet.Vlasnik);
        }
        private void vlasnikBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vlasnikBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tVPProjekatDataSet);

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

        private void txtJMBG_OnValueChanged(object sender, EventArgs e)
        {
           if (txtJMBG.Text.Equals(""))  //ukoliko je prazno
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

        private void txtAdresa_OnValueChanged(object sender, EventArgs e)
        {
            if (txtAdresa.Text.Equals(""))  //ukoliko je prazno
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

        private void txtTelefon_OnValueChanged(object sender, EventArgs e)
        {
            if (txtTelefon.Text.Equals(""))  //ukoliko je prazno
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

        private bool Validation()
        {
            if (txtIme.Text == "" || txtPrezime.Text == "" || txtAdresa.Text == "" || txtTelefon.Text == ""  || txtJMBG.Text == "")
            {
                MessageBox.Show("Morate popuniti sva polja!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            if (txtJMBG.Text.Length != 13)
            {
                MessageBox.Show("JMBG mora imati 13 cifata!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
           
                return true;
        }

        private void resetFields()
        {
            txtIme.Text = "";
            txtPrezime.Text = "";
            txtAdresa.Text = "";
            txtTelefon.Text = "";
            txtJMBG.Text = "";
            idVlasnika = -1;
            
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validation())
                {
                   // MessageBox.Show("Morate popuniti sva polja.", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (v.PretraziJMBG(txtJMBG.Text))
                    {
                        v.DodajNovogVlasnika(txtIme.Text, txtPrezime.Text, txtAdresa.Text, txtTelefon.Text, txtJMBG.Text);
                        MessageBox.Show("Uspesno");
                        v.Fill(vlasnikDataGridView);
                        resetFields();
                    }
                    else
                    {
                        MessageBox.Show("JMBG već postoji. Unesite drugi JMBG.", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtJMBG.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtPretraga_KeyPress(object sender, EventArgs e)
        {
            v.PretraziVlasnika(vlasnikDataGridView, txtPretraga.text);
        }

        private void vlasnikDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                idVlasnika= Convert.ToInt32(vlasnikDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtIme.Text = vlasnikDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtPrezime.Text = vlasnikDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtJMBG.Text = vlasnikDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                stariJMBG = vlasnikDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtAdresa.Text = vlasnikDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtTelefon.Text = vlasnikDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
               

                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void vlasnikDataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            resetFields();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
          try
            {
                if (idVlasnika != -1 && !Validation())
                {
                    if (stariJMBG.ToLower() != txtJMBG.Text.ToLower())
                    {
                        if (v.PretraziJMBG(txtJMBG.Text))
                        {
                          v.AzurirajVlasnika(txtIme.Text, txtPrezime.Text, txtAdresa.Text, txtTelefon.Text, txtJMBG.Text, idVlasnika);
                            
                            MessageBox.Show("Uspešno ažuriranje!");
                            v.Fill(vlasnikDataGridView);
                            resetFields();
                        }
                    }
                    else
                    {
                        v.AzurirajVlasnika(txtIme.Text, txtPrezime.Text, txtAdresa.Text, txtTelefon.Text, txtJMBG.Text, idVlasnika);

                        MessageBox.Show("Uspešno ažuriranje!");
                        v.Fill(vlasnikDataGridView);
                        resetFields();
                    }

                }
                else
                    MessageBox.Show("Morate selektovati vlasnika u tabeli", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                if (idVlasnika != -1)
                {
                    v.ObrisiVlasnika(idVlasnika);
                    MessageBox.Show("Uspešno brisanje.");
                    v.Fill(vlasnikDataGridView);
                    resetFields();

                }
                else
                    MessageBox.Show("Morate selektovati vlasnika  u tabeli", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtJMBG_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

    }
}

