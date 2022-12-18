using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using Microsoft.Win32;

namespace TVPProjekat
{
    public partial class StanjaStrujomera : UserControl
    {
        StrujomerClass sc = new StrujomerClass();
        public StanjaStrujomera()
        {

            InitializeComponent();
            /* DateTime dt1 = DateTime.Now;
             const string ftm = "MM/dd/yyyy";
             string strdt = dt1.ToString(ftm);
             DateTime now1 = DateTime.ParseExact(strdt, ftm, CultureInfo.InvariantCulture, DateTimeStyles.AssumeLocal);
             int mesec=now1.Month;
               */
            //  string sMonth = DateTime.Now.ToString("MM");
            // sc.PopuniPoMesecu(dataGridView1,Convert.ToInt32(sMonth));
            // sc.PopuniPoMesecu(dataGridView2, mesec);
            RegistryKey regkey = Registry.CurrentUser.OpenSubKey(@"Control Panel\International", true);
            regkey.SetValue("sShortDate", "MM/dd/yyyy");
            sc.Popuni(dataGridView2);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            
            //MessageBox.Show(sMonth);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                sc.PopuniPoMesecu(dataGridView2, comboBox1.SelectedIndex+1);
            
        }

        

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            StanjaNisuUneta snu = new StanjaNisuUneta();
            snu.ShowDialog();
        }

        private void stanjeStrujomeraBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.stanjeStrujomeraBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tVPProjekatDataSet);

        }
    }
}
