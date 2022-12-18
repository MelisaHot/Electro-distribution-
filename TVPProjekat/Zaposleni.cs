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
    class Zaposleni
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.TVPProjekatConnectionString);
        SqlCommand cmd;
        SqlDataAdapter da; //prenosi podatke izmedju baze podataka i dataseta
        SqlDataReader dr; //cita podatke uzete iz baze 
        DataTable dt;  //tabela iz dataseta
        DataSet ds; //lokalna kopija baze podataka

        public static string tip;
        public int idZaposlenog = -1; 

        public void Fill(DataGridView dgv) // za popunjavanje tabele sa svim podacima
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM Zaposleni", conn);
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

        public void AutoCompleteZaposleni(string jmbg, TextBox txt) //autocomplete polja 
        {
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT JMBG FROM Zaposleni WHERE JMBG LIKE '" + jmbg + "%'", conn);
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

        public string Hash(string lozinka) // za hashovanje lozinke
        {
            var bytes = new UTF8Encoding().GetBytes(lozinka);
            var hashlozinka = System.Security.Cryptography.MD5.Create().ComputeHash(bytes);
            return Convert.ToBase64String(hashlozinka);
        }

        public bool Prijava(string korisnickoime, string lozinka)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM Zaposleni WHERE  Korisnickoime='" + korisnickoime + "'AND Lozinka='" + Hash(lozinka) + "'", conn);
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);
                int i = ds.Tables[0].Rows.Count; // da proverimo koliko redova iz baze je pokupljeno
                if (i == 1)
                {
                    //nasao korisnika
                    dr = cmd.ExecuteReader(); // da procita zaposlenog kojeg je nasao
                    while (dr.Read())
                    {
                        //uzimamo tip zbog privilegija
                        tip = dr["Tip"].ToString();
                        idZaposlenog = Convert.ToInt32(dr["Id"]);
                    }
                    conn.Close();
                    return true;
                }
                else
                {
                    conn.Close();
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

        public void DodajNovogZaposlenog(string ime, string prezime, string adresa, string broj, string tip, string korime, string loz, string jmbg)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("INSERT INTO Zaposleni (Ime, Prezime, Adresa, Telefon, Tip, Korisnickoime, Lozinka, JMBG) VALUES ('"+ime+"','"+prezime+"','"+adresa+"','"+broj+"','"+tip+"','"+korime+"','"+loz+"','"+jmbg+"')", conn);
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

        public bool PretraziJMBG(string jmbg) // posto jmbg mora da bude jedinstven proveravamo da li vec postoji
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM Zaposleni WHERE JMBG='" + jmbg + "'", conn);
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);
                int i = ds.Tables[0].Rows.Count;
                if (i > 0)
                {
                    conn.Close();
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

        public void Pretrazi(DataGridView dgv, string pretraga) // pretraga po imenu prezimenu, jmbg-u
        {
          try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM Zaposleni WHERE CONCAT (Ime, Prezime, JMBG ) LIKE  '%" + pretraga + "%'", conn);
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

        public bool PretraziKorisnicko(string korisnicko) // korisnicko ime mora da bude jedinstveno pa pretrazujemo da li vec postoji
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM Zaposleni WHERE Korisnickoime='" + korisnicko + "'", conn);
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);
                int i = ds.Tables[0].Rows.Count;
                if (i > 0)
                {
                    conn.Close();
                    MessageBox.Show("Korisničko ime već postoji.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public void AzurirajZaposlenog(string ime, string prezime, string adresa, string telefon, string tip, string korisnicko, string lozinka, string jmbg, int id) 
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("UPDATE Zaposleni SET Ime=@ime, Prezime=@prezime, Adresa=@adresa, Telefon=@telefon, Tip=@tip, Korisnickoime=@korisnicko, Lozinka=@lozinka, JMBG=@jmbg WHERE Id=@id",conn);
                cmd.Parameters.AddWithValue("ime", ime);
                cmd.Parameters.AddWithValue("prezime", prezime);
                cmd.Parameters.AddWithValue("adresa", adresa);
                cmd.Parameters.AddWithValue("telefon", telefon);
                cmd.Parameters.AddWithValue("tip", tip);
                cmd.Parameters.AddWithValue("korisnicko", korisnicko);
                cmd.Parameters.AddWithValue("lozinka", Hash(lozinka));
                cmd.Parameters.AddWithValue("jmbg", jmbg);
                cmd.Parameters.AddWithValue("id", id);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch(Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        public void AzurirajZaposlenog(string ime, string prezime, string adresa, string telefon, string tip, string korisnicko, string jmbg, int id) 
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("UPDATE Zaposleni SET Ime=@ime, Prezime=@prezime, Adresa=@adresa, Telefon=@telefon, Tip=@tip, Korisnickoime=@korisnicko, JMBG=@jmbg WHERE Id=@id", conn);
                cmd.Parameters.AddWithValue("ime", ime);
                cmd.Parameters.AddWithValue("prezime", prezime);
                cmd.Parameters.AddWithValue("adresa", adresa);
                cmd.Parameters.AddWithValue("telefon", telefon);
                cmd.Parameters.AddWithValue("tip", tip);
                cmd.Parameters.AddWithValue("korisnicko", korisnicko);
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

        public void ObrisiZaposlenog(int id)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("DELETE FROM Zaposleni WHERE Id="+id+"", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        public bool NadjiZaposlenog(string jmbg) // da nadje zaposlenog sa unetim jmbg-om je nam trebaju podaci iz tabele zaposleni za strujomer
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM Zaposleni WHERE  JMBG='" + jmbg + "'", conn);
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);
                int i = ds.Tables[0].Rows.Count; // da proverimo koliko redova iz baze je pokupljeno
                if (i == 1)
                {
                    dr = cmd.ExecuteReader(); // da procita zaposlenog kojeg je nasao
                    while (dr.Read())
                    {
                        idZaposlenog = Convert.ToInt32(dr["Id"]);
                    }
                    conn.Close();
                    return true;
                }
                else
                {
                    conn.Close();
                    MessageBox.Show("Ne postoji odabrani zaposleni.");
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