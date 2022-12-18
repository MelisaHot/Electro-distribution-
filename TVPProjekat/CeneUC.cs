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
    public partial class CeneUC : UserControl
    {
        CeneClass c;
        int idCene = -1;

        public CeneUC()
        {
            c = new CeneClass();
            InitializeComponent();
            c.Fill(ceneDataGridView);
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;

            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
           


        }

        private void ceneBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ceneBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tVPProjekatDataSet);

        }

        private void txNizaZel_OnValueChanged(object sender, EventArgs e)
        {
            if (txNizaZel.Text.Equals(""))  //ukoliko je prazno
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

        private void txtNizaPlava_OnValueChanged(object sender, EventArgs e)
        {
            if (txtNizaPlava.Text.Equals(""))  //ukoliko je prazno
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

        private void txtNizaCrvena_OnValueChanged(object sender, EventArgs e)
        {
            if (txtNizaCrvena.Text.Equals(""))  //ukoliko je prazno
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

        private void txtVisaZel_OnValueChanged(object sender, EventArgs e)
        {
            if (txtVisaZel.Text.Equals(""))  //ukoliko je prazno
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

        private void txtVisaPlava_OnValueChanged(object sender, EventArgs e)
        {
            if (txtVisaPlava.Text.Equals(""))  //ukoliko je prazno
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

        private void txtVisaCrvena_OnValueChanged(object sender, EventArgs e)
        {
            if (txtVisaCrvena.Text.Equals(""))  //ukoliko je prazno
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

        private void txtPDV_OnValueChanged(object sender, EventArgs e)
        {
            if (txtPDV.Text.Equals(""))  //ukoliko je prazno
            {

                label8.Visible = true;
                label8.ForeColor = Color.Red;
                label8.Text = "Popunite polje!";

            }
            else
            {

                label8.Visible = false;
            }
        }

        private void txtAkciza_OnValueChanged(object sender, EventArgs e)
        {
            if (txtAkciza.Text.Equals(""))  //ukoliko je prazno
            {

                label9.Visible = true;
                label9.ForeColor = Color.Red;
                label9.Text = "Popunite polje!";

            }
            else
            {

                label9.Visible = false;
            }
        }

        private bool Validation()
        {
            if (txNizaZel.Text == "" || txtNizaPlava.Text == "" || txtNizaCrvena.Text == "" || txtVisaZel.Text == "" || txtVisaPlava.Text == "" || txtVisaCrvena.Text == "" || txtPDV.Text == "" || txtAkciza.Text == "")
            {
               MessageBox.Show("Morate popuniti sva polja!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (idCene == -1)
            {
                MessageBox.Show("Morate izabrati cene iz tabele!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
             return true;
        }

        private void resetFields()
        {
            txNizaZel.Text = "";
            txtNizaPlava.Text = "";
            txtNizaCrvena.Text = "";
            txtVisaZel.Text = "";
            txtVisaPlava.Text = "";
            txtVisaCrvena.Text = "";
            txtPDV.Text = "";
            txtAkciza.Text = "";
            idCene = -1;

            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            

        }

       

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                //MessageBox.Show("Morate popuniti sva polja.", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                c.AzurirajCenu(float.Parse(txNizaZel.Text), float.Parse(txtNizaPlava.Text), float.Parse(txtNizaCrvena.Text), float.Parse(txtVisaZel.Text), float.Parse(txtVisaPlava.Text), float.Parse(txtVisaCrvena.Text), float.Parse(txtPDV.Text), float.Parse(txtAkciza.Text), idCene);
                MessageBox.Show("Uspešno ažurirane cene.");
                c.Fill(ceneDataGridView);
                resetFields();
            }
           
                
            }

        private void ceneDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                idCene = Convert.ToInt32(ceneDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                txNizaZel.Text = ceneDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtNizaPlava.Text = ceneDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtNizaCrvena.Text = ceneDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtVisaZel.Text= ceneDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtVisaPlava.Text = ceneDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtVisaCrvena.Text = ceneDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtPDV.Text = ceneDataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtAkciza.Text = ceneDataGridView.Rows[e.RowIndex].Cells[8].Value.ToString();


                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;

                label10.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                label13.Visible = true;
                label14.Visible = true;
                label15.Visible = true;
                label16.Visible = true;
                label17.Visible = true;
           

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ceneDataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            resetFields();
        }

        private void txNizaZel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',';
        }
    }
}
