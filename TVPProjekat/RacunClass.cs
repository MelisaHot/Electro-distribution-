using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVPProjekat
{
    class RacunClass
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.TVPProjekatConnectionString);
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataTable dt;
        DataSet ds;

        public int id = -1, idstrujomera = -1, idvlasnika = -1, idcene = -1;
        public string utrosaknize = "", utrosakvise = "";
        public string zelenavise = "", zelenanize = "", plavanize = "", plavavise = "", crvenanize = "", crvenavise = "";
        public string ukupnosve = "";

        public void Fill(DataGridView dgv) //da mozemo da proverimo da l vrsi insert
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM Racun", conn);
                cmd.ExecuteNonQuery();
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       /* public void DodajRacun()
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("INSERT INTO Racun (IdStrujomera, IdVlasnika, IdCene, UtrosakNize, UtrosakVise, ZelenaNiza, PlavaNiza, CrvenaNiza, ZelenaVisa, PlavaVisa, CrvenaVisa, VrednostRacuna, DatumStampanja) VALUES (" + idstrujomera + "," + idvlasnika + "," + idcene + ", '" + utrosaknize + "',+ utrosaknize + "')", conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }*/
    }
}
