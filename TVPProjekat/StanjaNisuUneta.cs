using iTextSharp.text.pdf;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVPProjekat
{
    public partial class StanjaNisuUneta : Form
    {
        public int idzaposlenog = -1;
        public double utrosaknize = 0, utrosakvise = 0, ukupnonize = 0, ukupnovise = 0;
        public double zelenaniza = 0, plavaniza = 0, crvenaniza = 0;
        public double zelenavisa = 0, plavavisa = 0, crvenavisa = 0;
        public double zelenanizacena = 0, plavanizacena = 0, crvenanizacena = 0;
        public double zelenavisacena = 0, plavavisacena = 0, crvenavisacena = 0;
        public double ukupnozauplatunize = 0, ukupnozauplatvise = 0, ukunosve = 0;
        public double pdv = 0, akciza = 0;

        private void dgvStrujomer_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtBrojStrujomera.Text = dgvStrujomer.Rows[e.RowIndex].Cells[3].Value.ToString();
            selektovano = true;
        }

        private void dgvStrujomer_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ResetFields();
            selektovano = false;
        }

        private bool selektovan()
        {
            if (selektovano == false)
            {
                MessageBox.Show("Morate selektovati u tabeli.",
                    "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }

        StrujomerClass stc = new StrujomerClass();

       
        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {
            stc.PretragaNisuUnetaStanja(dgvStrujomer, bunifuTextbox1.text);
        }

        private void btnStampanje_Click(object sender, EventArgs e)
        {
            Stampanje();
        }

        CeneClass cc = new CeneClass();
        VlasniciClass vc = new VlasniciClass();
        bool selektovano = false;
        public StanjaNisuUneta()
        {
            InitializeComponent();
            stc.NisuUnetaStanja(dgvStrujomer);
            //stc.Popuni(stanjeStrujomeraDataGridView);
            RegistryKey regkey = Registry.CurrentUser.OpenSubKey(@"Control Panel\International", true);
            regkey.SetValue("sShortDate", "MM/dd/yyyy");
            if (dgvStrujomer.Rows.Count > 0)
            {
                txtBrojStrujomera.Visible = true;
                txtNovoNize.Visible = true;
                txtNovoVise.Visible = true;
                dgvStrujomer.Visible = true;
                bunifuTextbox1.Visible = true;
                lblNema.Visible = false;
                btnSacuvaj.Visible = true;
                btnStampanje.Visible = false;
            }
            else
            {
                lblNema.Visible = true;
                label1.Visible = false;
                bunifuTextbox1.Visible = false;
                lblNema.Text = "Sva stanja su uneta.";
            }
        }

        private void ResetFields()
        {
            txtBrojStrujomera.Text = "";
            txtNovoNize.Text = "";
            txtNovoVise.Text = "";
        }
        double trenutnonize = 0, novonize = 0;
        double trenutnovise = 0, novovise = 0;
        private void IzracunajUtrosak()
        {
            try
            {
                cc.ZaRacunanje();
                stc.ZaRacunanje(txtBrojStrujomera.Text);
                vc.ZaRacunanje(stc.idvlasnik);
                //MessageBox.Show(stc.idvlasnik.ToString());
                trenutnonize = Convert.ToDouble(stc.trenutnonize);
                novonize = Convert.ToDouble(stc.novonize);
                utrosaknize = novonize - trenutnonize;
                ukupnonize = utrosaknize;
                trenutnovise = Convert.ToDouble(stc.trenutnovise);
                novovise = Convert.ToDouble(stc.novovise);
                utrosakvise = novovise - trenutnovise;
                ukupnovise = utrosakvise;
                //MessageBox.Show(utrosaknize.ToString() + "\n" + utrosakvise.ToString());

                if (utrosaknize <= 350)//zelena zona
                {
                    zelenaniza = utrosaknize;
                }
                else
                {
                    zelenaniza = 350;
                    utrosaknize = utrosaknize - 350;
                    if (utrosaknize <= 1600) //plava
                        plavaniza = utrosaknize;
                    else
                    {
                        plavaniza = 1600; //crvena
                        utrosaknize = utrosaknize - 1600;
                        crvenaniza = utrosaknize;
                    }
                }

                if (utrosakvise <= 350)//zelena zona
                {
                    zelenavisa = utrosakvise;
                }
                else
                {
                    zelenavisa = 350;
                    utrosakvise = utrosakvise - 350;
                    if (utrosakvise <= 1600)
                        plavavisa = utrosakvise;
                    else
                    {
                        plavavisa = 1600;
                        utrosakvise = utrosakvise - 1600;
                        crvenavisa = utrosakvise;
                    }
                }
                zelenanizacena = zelenaniza * cc.nizazelena;
                plavanizacena = plavaniza * cc.nizaplava;
                crvenanizacena = crvenaniza * cc.nizacrvena;
                zelenavisacena = zelenavisa * cc.visazelena;
                plavavisacena = plavavisa * cc.visaplava;
                crvenavisacena = crvenavisa * cc.visacrvena;
                ukupnozauplatunize = zelenanizacena + plavanizacena + crvenanizacena;
                ukupnozauplatvise = zelenavisacena + plavavisacena + crvenavisacena;
                pdv = (ukupnozauplatunize + ukupnozauplatvise) * cc.pdv / 100;
                akciza = (ukupnozauplatunize + ukupnozauplatvise) * cc.akciza / 100;
                ukunosve = ukupnozauplatunize + ukupnozauplatvise + pdv + akciza;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public string ToUpperFirstLetterIme(string ime)
        {
            if (string.IsNullOrEmpty(ime))
                return string.Empty;
            // convert to char array of the string
            char[] imee = ime.ToCharArray();
            // upper case the first char
            imee[0] = char.ToUpper(imee[0]);

            // return the array made of the new char array
            return new string(imee);
        }

        private void Stampanje()
        {
            try
            {

                var lastmonth = DateTime.Today.AddMonths(-1);
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF file|*.pdf", ValidateNames = true })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        iTextSharp.text.Document racun = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4);
                        PdfWriter.GetInstance(racun, new FileStream(sfd.FileName, FileMode.Create));
                        racun.Open();
                        racun.Add(new iTextSharp.text.Paragraph("Račun za mesec " + lastmonth.ToString("MMMM") + "\n\n"));
                        racun.Add(new iTextSharp.text.Paragraph("Broj strujomera:    " + stc.brstrujomera));
                        racun.Add(new iTextSharp.text.Paragraph("Vlasnik:    " + ToUpperFirstLetterIme(vc.ime) + " " + ToUpperFirstLetterIme(vc.prezime)));
                        racun.Add(new iTextSharp.text.Paragraph("Datum:  " + DateTime.Now.ToString("dd.MM.yyyy")));
                        racun.Add(new iTextSharp.text.Paragraph("\n\n"));
                        racun.Add(new iTextSharp.text.Paragraph("Prethodno stanje: \n\n"));
                        racun.Add(new iTextSharp.text.Paragraph("Niža tarifa:   " + stc.trenutnonize + "  kWh"));
                        racun.Add(new iTextSharp.text.Paragraph("Viša tarifa:   " + stc.trenutnovise + "  kWh\n\n"));
                        racun.Add(new iTextSharp.text.Paragraph("Novo stanje: \n\n"));
                        racun.Add(new iTextSharp.text.Paragraph("Niža tarifa:   " + stc.novonize + "  kWh"));
                        racun.Add(new iTextSharp.text.Paragraph("Viša tarifa:   " + stc.novovise + "  kWh"));
                        racun.Add(new iTextSharp.text.Paragraph("\n"));
                        racun.Add(new iTextSharp.text.Paragraph("Utrošak po zonama:\n\n"));
                        racun.Add(new iTextSharp.text.Paragraph(" Niža tarifa:\n"));
                        racun.Add(new iTextSharp.text.Paragraph("  Ukupno:  " + ukupnonize + "  kWh\n"));
                        racun.Add(new iTextSharp.text.Paragraph("  Zelena zona:  " + zelenaniza + "  kWh     - Cena: " + cc.nizazelena + "  dinara po kWh\n"));
                        racun.Add(new iTextSharp.text.Paragraph("  Plava zona:  " + plavaniza + "  kWh       - Cena: " + cc.nizaplava + "  dinara po kWh\n"));
                        racun.Add(new iTextSharp.text.Paragraph("  Crvena zona:  " + crvenaniza + "  kWh     - Cena: " + cc.nizacrvena + "  dinara po kWh\n\n"));
                        racun.Add(new iTextSharp.text.Paragraph(" Viša tarifa:\n"));
                        racun.Add(new iTextSharp.text.Paragraph("  Ukupno:  " + ukupnovise + "  kWh\n"));
                        racun.Add(new iTextSharp.text.Paragraph("  Zelena zona:  " + zelenavisa + "  kWh     - Cena: " + cc.visazelena + "  dinara po kWh\n"));
                        racun.Add(new iTextSharp.text.Paragraph("  Plava zona:  " + plavavisa + "  kWh       - Cena: " + cc.visaplava + "  dinara po kWh\n"));
                        racun.Add(new iTextSharp.text.Paragraph("  Crvena zona:  " + crvenavisa + "  kWh     - Cena: " + cc.visacrvena + "  dinara po kWh\n\n"));
                        racun.Add(new iTextSharp.text.Paragraph("-------------------------------------------------------------------------------\n"));
                        racun.Add(new iTextSharp.text.Paragraph("A)       Ukupan dug po nižoj tarifi:  " + ukupnozauplatunize + "  dinara\n"));
                        racun.Add(new iTextSharp.text.Paragraph("B)       Ukupan dug po višoj tarifi:  " + ukupnozauplatvise + "  dinara\n"));
                        racun.Add(new iTextSharp.text.Paragraph("A+B)     Ukupan dug:  " + (ukupnozauplatunize + ukupnozauplatvise) + "  dinara\n"));
                        racun.Add(new iTextSharp.text.Paragraph("C)       PDV:  " + pdv + "  dinara   (" + cc.pdv + "%)\n"));
                        racun.Add(new iTextSharp.text.Paragraph("D)       Akciza:  " + akciza + "  dinara   (" + cc.akciza + "%)\n\n"));
                        racun.Add(new iTextSharp.text.Paragraph("A+B+C+D) Ukupno za uplatu:  " + ukunosve + "  dinara\n"));
                        racun.Close();
                        btnStampanje.Visible = false;

                        if (dgvStrujomer.Rows.Count > 0)
                        {
                            txtBrojStrujomera.Visible = true;
                            txtNovoNize.Visible = true;
                            txtNovoVise.Visible = true;
                            dgvStrujomer.Visible = true;
                            lblNema.Visible = false;
                            bunifuTextbox1.Visible = true;
                            btnSacuvaj.Visible = true;
                        }
                        else
                        {
                            txtBrojStrujomera.Visible = false;
                            txtNovoNize.Visible = false;
                            txtNovoVise.Visible = false;
                            dgvStrujomer.Visible = false;
                            btnSacuvaj.Visible = false;
                            bunifuTextbox1.Visible = false;
                            stanjeStrujomeraDataGridView.Visible = false;
                            lblNema.Visible = true;
                            lblNema.Text = "Sva stanja su uneta.";
                            label1.Visible = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool Validacija()
        {
            if (txtBrojStrujomera.Text == string.Empty)
            {
                MessageBox.Show("Morate uneti broj strujomera.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtNovoNize.Text == string.Empty)
            {
                MessageBox.Show("Morate uneti novo stanje niže tarife.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            Int32 novonize;
            bool broj = Int32.TryParse(txtNovoNize.Text, out novonize);
            if (!broj)
            {
                MessageBox.Show("U polje za unos unos stanja mogu se uneti samo cifre.",
                    "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtNovoVise.Text == string.Empty)
            {
                MessageBox.Show("Morate uneti novo stanje više tarife.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            Int32 novovise;
            bool broj1 = Int32.TryParse(txtNovoVise.Text, out novovise);
            if (!broj1)
            {
                MessageBox.Show("U polje za unos unos stanja mogu se uneti samo cifre.",
                    "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool Validacija2()
        {
            try
            {
                double trenutno1 = Convert.ToDouble(stc.trenutnonize);
                double trenutno2 = Convert.ToDouble(stc.trenutnovise);
                double novo1 = Convert.ToDouble(txtNovoNize.Text);
                double novo2 = Convert.ToDouble(txtNovoVise.Text);

                if (trenutno1 > novo1)
                {
                    MessageBox.Show("Morate uneti novo stanje niže tarife. Novo stanje ne može biti manje od prethodnog.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (trenutno2 > novo2)
                {
                    MessageBox.Show("Morate uneti novo stanje više tarife. Novo stanje ne može biti manje od prethodnog.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return true;
        }

        private void dodelaVrednosti()
        {
            try
            {
                stc.idzaposleni = idzaposlenog;
                stc.PretraziBrojStujomera(txtBrojStrujomera.Text);
                stc.novonize = txtNovoNize.Text;
                stc.novovise = txtNovoVise.Text;
                stc.datum = DateTime.Now;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (selektovan())
                {
                    if (Validacija())
                    {
                        stc.brstrujomera = txtBrojStrujomera.Text;
                        if (stc.NemaStrujomer())
                        {
                            dodelaVrednosti();
                            if (Validacija2())
                            {
                                stc.UnesiStanje();
                                stc.DodajStanjeStrujomeru();
                                ResetFields();
                                stc.NisuUnetaStanja(dgvStrujomer);
                                stc.Popuni(stanjeStrujomeraDataGridView);
                                IzracunajUtrosak();
                                btnStampanje.Visible = true;
                                
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
