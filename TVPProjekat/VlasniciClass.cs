using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Windows.Forms;

namespace TVPProjekat
{
    class VlasniciClass
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.TVPProjekatConnectionString);
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataTable dt;
        DataSet ds;

        public int idVlasnika = -1;
        public string ime = "", prezime = "";

        public void Fill(DataGridView dgv)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM Vlasnik", conn);
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

        public void AutoCompleteVlasnik(string jmbg, TextBox txt)
        {
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT JMBG FROM Vlasnik WHERE JMBG LIKE '"+jmbg+"%'", conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    string sJMBG = dr.GetString(dr.GetOrdinal("JMBG"));
                    coll.Add(sJMBG);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
            txt.AutoCompleteCustomSource = coll;
            conn.Close();
        }

        public void DodajNovogVlasnika(string ime, string prezime, string adresa, string broj,  string jmbg)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("INSERT INTO Vlasnik (Ime, Prezime, JMBG, Adresa, Telefon) VALUES ('" + ime + "','" + prezime + "','" + jmbg+ "','" + adresa + "','" + broj + "')", conn);
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


        public void PretraziVlasnika(DataGridView dgv, string pretraga)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM Vlasnik WHERE CONCAT (Ime, Prezime, JMBG ) LIKE  '%" + pretraga + "%'", conn);
                //cmd.ExecuteNonQuery();
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

        public bool PretraziJMBG(string jmbg)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM Vlasnik WHERE JMBG='" + jmbg+ "'", conn);
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);
                int i = ds.Tables[0].Rows.Count;
                if (i > 0)
                {
                    conn.Close();
                    MessageBox.Show("JMBG već postoji. Unesite novi JMBG", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    conn.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return true;
        }


        public void AzurirajVlasnika(string ime, string prezime, string adresa, string telefon, string jmbg, int id) 
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("UPDATE Vlasnik SET Ime=@ime, Prezime=@prezime, JMBG=@jmbg, Adresa=@adresa, Telefon=@telefon WHERE Id=@id", conn);
                cmd.Parameters.AddWithValue("ime", ime);
                cmd.Parameters.AddWithValue("prezime", prezime);
                cmd.Parameters.AddWithValue("adresa", adresa);
                cmd.Parameters.AddWithValue("telefon", telefon);
                cmd.Parameters.AddWithValue("jmbg", jmbg);
                cmd.Parameters.AddWithValue("id", id);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        public void ZaRacunanje(int id)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM Vlasnik WHERE Id = " + id + "", conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    ime = dr["Ime"].ToString();
                    prezime = dr["Prezime"].ToString();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        public void ObrisiVlasnika(int id)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("DELETE FROM Vlasnik WHERE Id=" + id + "", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        public bool NadjiVlasnika(string jmbg)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM Vlasnik WHERE  JMBG='" + jmbg + "'", conn);
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);
                int i = ds.Tables[0].Rows.Count; // da proverimo koliko redova iz baze je pokupljeno
                if (i == 1)
                {
                    dr = cmd.ExecuteReader(); // da procita zaposlenog kojeg je nasao

                    while (dr.Read())
                    {
                        idVlasnika = Convert.ToInt32(dr["Id"]);
                    }
                    conn.Close();
                    return true;
                }
                else
                {
                    conn.Close();
                    MessageBox.Show("Ne postoji odabrani vlasnik.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            return true;
        }
    }
}
