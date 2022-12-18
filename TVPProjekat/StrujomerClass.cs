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
    class StrujomerClass
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.TVPProjekatConnectionString);
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataTable dt;
        DataSet ds;

        public int id = -1, idvlasnik = -1, idzaposleni = -1;
        public string brstrujomera = "", trenutnonize = "", trenutnovise = "", novonize = "", novovise = "";
        public DateTime datum;

        public void Fill(DataGridView dgv)
        {
            try
            {
                conn.Open();                               
                cmd = new SqlCommand("SELECT Strujomer.Id, Strujomer.IdVlasnika, Strujomer.IdZaposlenog, Strujomer.BrojStrujomera AS 'Broj strujomera', Strujomer.TrenutnoNize AS 'Trenutno stanje niže tarife',"
                    + " Strujomer.TrenutnoVise AS 'Trenutno stanje više tarife', Strujomer.NovoNize AS 'Novo stanje niže tarife', "
                    + "Strujomer.NovoVise AS 'Novo stanje više tarife', Strujomer.Datum, Vlasnik.Ime AS 'Ime vlasnika', Vlasnik.Prezime AS 'Prezime vlasnika', Vlasnik.JMBG AS 'JMBG vlasnika', "
                    + "Zaposleni.Ime AS 'Ime zaposlenog', Zaposleni.Prezime AS 'Prezime zaposlenog', Zaposleni.JMBG AS 'JMBG zaposlenog' FROM Strujomer LEFT JOIN Vlasnik ON Strujomer.IdVlasnika=Vlasnik.Id "
                    + "LEFT JOIN Zaposleni ON Strujomer.IdZaposlenog=Zaposleni.Id", conn);
                cmd.ExecuteNonQuery();
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
                dgv.Columns[0].Visible = false;
                dgv.Columns[1].Visible = false;
                dgv.Columns[2].Visible = false;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DodajStrujomer()
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("INSERT INTO Strujomer (IdVlasnika, IdZaposlenog, BrojStrujomera, TrenutnoNize, TrenutnoVise, NovoNize, NovoVise, Datum) VALUES (" + idvlasnik + "," + idzaposleni + ",'" + brstrujomera + "', '0', '0', '0', '0', '" + datum + "')", conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        public void AzurirajStrujomer()
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("UPDATE Strujomer SET IdVlasnika=@idvlasnika, IdZaposlenog=@idzaposlenog, BrojStrujomera=@brstrujomera, TrenutnoNize=@trenutnonize, TrenutnoVise=@trenutnovise, NovoNize=@novonize, NovoVise=@novovise, Datum=@datum WHERE Id=@id", conn);
                cmd.Parameters.AddWithValue("idvlasnika", idvlasnik);
                cmd.Parameters.AddWithValue("idzaposlenog", idzaposleni);
                cmd.Parameters.AddWithValue("brstrujomera", brstrujomera);
                cmd.Parameters.AddWithValue("trenutnonize", trenutnonize);
                cmd.Parameters.AddWithValue("trenutnovise", trenutnovise);
                cmd.Parameters.AddWithValue("novonize", novonize);
                cmd.Parameters.AddWithValue("novovise", novovise);
                cmd.Parameters.AddWithValue("datum", datum);
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

        public void ObrisiZaposlenog()
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("DELETE FROM Strujomer WHERE Id=" + id + "", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        public void UnesiStanje()
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("UPDATE Strujomer SET IdZaposlenog=@idzaposlenog, TrenutnoNize=@trenutnonize, TrenutnoVise=@trenutnovise, NovoNize=@novonize, NovoVise=@novovise, Datum=@datum WHERE Id=@id", conn);
                cmd.Parameters.AddWithValue("idzaposlenog", idzaposleni);
                cmd.Parameters.AddWithValue("trenutnonize", trenutnonize);
                cmd.Parameters.AddWithValue("trenutnovise", trenutnovise);
                cmd.Parameters.AddWithValue("novonize", novonize);
                cmd.Parameters.AddWithValue("novovise", novovise);
                cmd.Parameters.AddWithValue("datum", datum);
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

        public bool ProveriBrojStrujomera()
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM Strujomer WHERE BrojStrujomera='" + brstrujomera + "'", conn);
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);
                int i = ds.Tables[0].Rows.Count;
                if (i > 0)
                {
                    conn.Close();
                    MessageBox.Show("Broj strujomera već postoji.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public bool NemaStrujomer()
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM Strujomer WHERE BrojStrujomera='" + brstrujomera + "'", conn);
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);
                int i = ds.Tables[0].Rows.Count;
                if (i == 0)
                {
                    conn.Close();
                    MessageBox.Show("Broj strujomera ne postoji.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public void PretraziBrojStujomera(string brojstrujomera)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM Strujomer WHERE BrojStrujomera = '" + brojstrujomera + "'", conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    id = Convert.ToInt32(Convert.ToInt32(dr["Id"]));
                    idvlasnik= Convert.ToInt32(Convert.ToInt32(dr["IdVlasnika"]));
                    trenutnonize = dr["NovoNize"].ToString();
                    trenutnovise= dr["NovoVise"].ToString();
                }
                conn.Close();
                //MessageBox.Show(idvlasnik.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        public void ZaRacunanje(string brojstrujomera)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT  * FROM Strujomer WHERE BrojStrujomera = '" + brojstrujomera + "'", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    id = Convert.ToInt32(dr["Id"]);
                    brstrujomera = dr["BrojStrujomera"].ToString();
                    trenutnonize = dr["TrenutnoNize"].ToString();
                    trenutnovise = dr["TrenutnoVise"].ToString();
                    novonize = dr["NovoNize"].ToString();
                    novovise = dr["NovoVise"].ToString();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        public void AutoCompleteBrojStrujomera(string br, TextBox txt)
        {
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT BrojStrujomera FROM Strujomer WHERE BrojStrujomera LIKE '" + br + "%'", conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    string sJMBG = dr.GetString(dr.GetOrdinal("BrojStrujomera"));
                    //MessageBox.Show(sJMBG);
                    string sImesPrezime =/* sIme + " " + sPrezimeme + " | " + */sJMBG;
                    coll.Add(sImesPrezime);
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

        public void PretraziStrujomer(DataGridView dgv, string pretraga)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT Strujomer.Id, Strujomer.IdVlasnika, Strujomer.IdZaposlenog, Strujomer.BrojStrujomera AS 'Broj strujomera', Strujomer.TrenutnoNize AS 'Trenutno stanje niže tarife', "
                    + " Strujomer.TrenutnoVise AS 'Trenutno stanje više tarife', Strujomer.NovoNize AS 'Novo stanje niže tarife', "
                    + "Strujomer.NovoVise AS 'Novo stanje više tarife', Strujomer.Datum, Vlasnik.Ime AS 'Ime vlasnika', Vlasnik.Prezime AS 'Prezime vlasnika', Vlasnik.JMBG AS 'JMBG vlasnika', "
                    + "Zaposleni.Ime AS 'Ime zaposlenog', Zaposleni.Prezime AS 'Prezime zaposlenog', Zaposleni.JMBG AS 'JMBG zaposlenog' FROM Strujomer LEFT JOIN Vlasnik ON Strujomer.IdVlasnika=Vlasnik.Id "
                    + "LEFT JOIN Zaposleni ON Strujomer.IdZaposlenog=Zaposleni.Id WHERE CONCAT (BrojStrujomera, Zaposleni.Ime, Zaposleni.Prezime, Vlasnik.Ime, Vlasnik.Prezime ) LIKE  '%" + pretraga + "%'", conn);
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

        public void DodajStanjeStrujomeru()
        {

            try
            {
                conn.Open();
                cmd = new SqlCommand("INSERT INTO StanjeStrujomera (IdVlasnika, BrojStrujomera, TrenutnoNize, TrenutnoVise, NovoNize, NovoVise, Datum, IdZaposlenog) VALUES ('" + idvlasnik + "','" + brstrujomera + "','" + trenutnonize + "','" + trenutnovise + "','" + novonize + "','" + novovise + "','" + datum + "','" + idzaposleni + "')", conn);
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

        

        public void Popuni(DataGridView dgv)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT StanjeStrujomera.BrojStrujomera AS 'Broj strujomera', StanjeStrujomera.TrenutnoNize AS 'Trenutno stanje niže tarife',"
                    + " StanjeStrujomera.TrenutnoVise AS 'Trenutno stanje više tarife', StanjeStrujomera.NovoNize AS 'Novo stanje niže tarife', "
                    + "StanjeStrujomera.NovoVise AS 'Novo stanje više tarife', StanjeStrujomera.Datum, Vlasnik.Ime AS 'Ime vlasnika', Vlasnik.Prezime AS 'Prezime vlasnika', Vlasnik.JMBG AS 'JMBG vlasnika', "
                    + "Zaposleni.Ime AS 'Ime zaposlenog', Zaposleni.Prezime AS 'Prezime zaposlenog', Zaposleni.JMBG AS 'JMBG zaposlenog' FROM StanjeStrujomera LEFT JOIN Vlasnik ON StanjeStrujomera.IdVlasnika=Vlasnik.Id "
                    + "LEFT JOIN Zaposleni ON StanjeStrujomera.IdZaposlenog=Zaposleni.Id", conn);
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

        public void PopuniPoMesecu(DataGridView dgv, int mesec)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT  StanjeStrujomera.BrojStrujomera AS 'Broj strujomera', StanjeStrujomera.TrenutnoNize AS 'Trenutno stanje niže tarife',"
                    + " StanjeStrujomera.TrenutnoVise AS 'Trenutno stanje više tarife', StanjeStrujomera.NovoNize AS 'Novo stanje niže tarife', "
                    + "StanjeStrujomera.NovoVise AS 'Novo stanje više tarife', StanjeStrujomera.Datum, Vlasnik.Ime AS 'Ime vlasnika', Vlasnik.Prezime AS 'Prezime vlasnika', Vlasnik.JMBG AS 'JMBG vlasnika', "
                    + "Zaposleni.Ime AS 'Ime zaposlenog', Zaposleni.Prezime AS 'Prezime zaposlenog', Zaposleni.JMBG AS 'JMBG zaposlenog' FROM StanjeStrujomera LEFT JOIN Vlasnik ON StanjeStrujomera.IdVlasnika=Vlasnik.Id "
                    + "LEFT JOIN Zaposleni ON StanjeStrujomera.IdZaposlenog=Zaposleni.Id WHERE MONTH(Datum) = "+ mesec, conn);
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

        public void NisuUnetaStanja(DataGridView dgv)
        {
            try //znaci ja treba da proverim da l je uneto od 1 do 10 ovog meseca
            //odnosno proveravam gde datum nije od 1 do 10 jer bi to znacilo da je uneto stanje
            //ja treba da nadjem one od 10 proslog meseca do 1 ovog meseca kojima nije uneto stanje
            {
                DateTime dt1 = new DateTime(DateTime.Now.Year, DateTime.Now.Month-1, 1);
                DateTime dt2 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM Strujomer WHERE Datum >'" + dt1 + "' AND DATUM <'" + dt2 + "'", conn);
                cmd.ExecuteNonQuery();
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
                dgv.Columns[0].Visible = false;
                dgv.Columns[1].Visible = false;
                dgv.Columns[2].Visible = false;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void PretragaNisuUnetaStanja(DataGridView dgv, string pretraga)
        {
            try //znaci ja treba da proverim da l je uneto od 1 do 10 ovog meseca
            //odnosno proveravam gde datum nije od 1 do 10 jer bi to znacilo da je uneto stanje
            //ja treba da nadjem one od 10 proslog meseca do 1 ovog meseca kojima nije uneto stanje
            {
                DateTime dt1 = new DateTime(DateTime.Now.Year, DateTime.Now.Month - 1, 1);
                DateTime dt2 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM Strujomer WHERE Datum >'" + dt1 + "' AND DATUM <'" + dt2 + "' AND BrojStrujomera LIKE  '" + pretraga + "%'", conn);
                cmd.ExecuteNonQuery();
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
                dgv.Columns[0].Visible = false;
                dgv.Columns[1].Visible = false;
                dgv.Columns[2].Visible = false;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
