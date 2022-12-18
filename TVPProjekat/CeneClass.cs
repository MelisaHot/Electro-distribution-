using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace TVPProjekat
{
    class CeneClass
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.TVPProjekatConnectionString);
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataTable dt;
        DataSet ds;


        public double nizazelena = 0, nizaplava = 0, nizacrvena = 0;
        public double visazelena = 0, visaplava = 0, visacrvena = 0;
        public double pdv = 0, akciza = 0;
        public void Fill(DataGridView dgv)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM Cene", conn);
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


        /* public void DodajNovuCenu(float nizazelena, float nizaplava, float nizacrvena, float visazelena, float visaplava, float visacrvena, float pdv, float akciza )
         {

             try
             {
                 conn.Open();
                 cmd = new SqlCommand("INSERT INTO Zaposleni (NizaZelena, NizaPlava, NizaCrvena, VisaZelena, VisaPlava, VisaCrvena, PDV, Akciza) VALUES ('" + nizazelena + "','" + nizaplava + "','" + nizacrvena + "','" + visazelena + "','" + visaplava + "','" + visacrvena + "','" + pdv + "','" + akciza + "')", conn);
                 cmd.ExecuteNonQuery();

                 conn.Close();
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
                 conn.Close();
             }
             conn.Close();
         }
         */
        public void AzurirajCenu(float nizazelena, float nizaplava, float nizacrvena, float visazelena, float visaplava, float visacrvena, float pdv, float akciza, int id)

        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("UPDATE Cene SET NizaZelena=@nizazelena, NizaPlava=@nizaplava, NizaCrvena=@nizacrvena, VisaZelena=@visazelena, VisaPlava=@visaplava, VisaCrvena=@visacrvena, PDV=@pdv, Akciza=@akciza WHERE Id=@id", conn);
                cmd.Parameters.Add("nizazelena", nizazelena);
                cmd.Parameters.Add("nizaplava", nizaplava);
                cmd.Parameters.Add("nizacrvena", nizacrvena);
                cmd.Parameters.Add("visazelena", visazelena);
                cmd.Parameters.Add("visaplava", visaplava);
                cmd.Parameters.Add("visacrvena", visacrvena);
                cmd.Parameters.Add("pdv", pdv);
                cmd.Parameters.Add("akciza", akciza);
                cmd.Parameters.Add("id", id);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        /* public void ObrisiCenu(int id)
         {
             try
             {
                 conn.Open();
                 cmd = new SqlCommand("DELETE FROM Cene WHERE Id=" + id + "", conn);
                 cmd.ExecuteNonQuery();
                 conn.Close();
             }
             catch (Exception ex)
             {
                 conn.Close();
                 MessageBox.Show(ex.Message);
             }
         }*/

        public void ZaRacunanje()
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM Cene WHERE Id = " + 1 + "", conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    //string sIme = dr.GetString(dr.GetOrdinal("Ime"));
                    //string sPrezimeme = dr.GetString(dr.GetOrdinal("Prezime"));
                    nizazelena = Convert.ToDouble(dr["NizaZelena"]);
                    nizaplava = Convert.ToDouble(dr["NizaPlava"]);
                    nizacrvena = Convert.ToDouble(dr["NizaCrvena"]);
                    visazelena = Convert.ToDouble(dr["VisaZelena"]);
                    visaplava = Convert.ToDouble(dr["VisaPlava"]);
                    visacrvena = Convert.ToDouble(dr["VisaCrvena"]);
                    pdv = Convert.ToDouble(dr["PDV"]);
                    akciza = Convert.ToDouble(dr["Akciza"]);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }
    }
}
