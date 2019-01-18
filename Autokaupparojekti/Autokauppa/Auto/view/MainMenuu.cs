using Auto.kauppaservice;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Auto;

namespace Auto.view
{
    public partial class MainMenuu : Form
    {
        Service1Client Rekisteri = new Service1Client();
        
        string virhe;
            public MainMenuu()
            {   
                InitializeComponent();
            }
            
 
        private void MainMenu_Load(object sender, EventArgs e)
        {
            Merkki_laatikko_haeMerkit(sender, e);
            Merkki_laatikko.SelectedIndex = 0;
            Malli_laatikko_haeMallit(sender, e);
            Polttoaine_laatikko_haePolttoaineet(sender,e);
            Vari_laatikko_haeVarit(sender,e);
            lbNykyinenID.Text = "0";
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
             Application.Exit();
        }

        private void testDbconnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string vastaus = "tietokantayhteys ei toimi";
            Form hyppy = new Form();
            bool testi=Rekisteri.connectDatabase();
            if (testi == true)
            {
                vastaus = "tietokantayhteys toimii";
            }
            string viesti = vastaus;
            string otsikko = "tietokantayhteyden testaus";
            MessageBoxButtons napit = MessageBoxButtons.OK;
            DialogResult tulos;
            tulos = MessageBox.Show(viesti,otsikko,napit);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Merkki_laatikko_haeMerkit(object sender, EventArgs e)
        {
            List<Autonmerkki> merkit = Rekisteri.GetAllAutoMakersFromDatabase();
            Merkki_laatikko.DataSource = merkit;
            Merkki_laatikko.DisplayMember = "MerkkiNimi";
            Merkki_laatikko.ValueMember="ID";
        }

        private void Malli_laatikko_haeMallit(object sender, EventArgs e)
        {
            string i= Merkki_laatikko.SelectedValue.ToString();
            if(int.TryParse(i, out int r))
            {
                int makerid = r;
                List<Autonmallit> mallit = Rekisteri.GetAutoModelsByMakerId(makerid);
                malli_laatikko.DataSource = mallit;
                malli_laatikko.DisplayMember = "MalliNimi";
                malli_laatikko.ValueMember = "ID";
            }
        
        }

        private void Polttoaine_laatikko_haePolttoaineet(object sender, EventArgs e)
        {
            List<Polttoaine> polttoaineet = Rekisteri.HaePolttoaine();
            Polttoaine_laatikko.DataSource = polttoaineet;
            Polttoaine_laatikko.DisplayMember = "Polttoaineet";
            Polttoaine_laatikko.ValueMember = "ID";
        }

        private void Vari_laatikko_haeVarit(object sender, EventArgs e)
        {
            List<Vari> Varit = Rekisteri.haeVari();
            Vari_laatikko.DataSource = Varit;
            Vari_laatikko.DisplayMember = "Varit";
            Vari_laatikko.ValueMember = "ID";
        }

    private void Mittarilukema_Text_TextChanged(object sender, EventArgs e)
        {
            string  mittari = Mittarilukema_Text.Text;
            int lukema;
            if (int.TryParse(mittari, out lukema))
            {
                Mittarilukema_Text.Text = mittari;
            }
            else if(mittari=="")
            {
            }
            else
            {
                virhe = "vain numeroita!";
                MessageBox.Show(virhe, virhe, MessageBoxButtons.OK);
            } 
        }

        private void Moottirintilavuus_text_TextChanged(object sender, EventArgs e)
        {
            string moottori = Moottori_text.Text;
            decimal lukema;
            if (decimal.TryParse(moottori, out lukema))
            {
              //  Moottorintilavuus_text.Text = moottori;
            }
            else if (moottori == "")
            {
            }
            else
            {
                virhe = "vain numeroita! desimaaliluku pilkulla";
                MessageBox.Show(virhe, virhe, MessageBoxButtons.OK);
            }
        }

        private void Hinta_Text_TextChanged(object sender, EventArgs e)
        {
            string raha = Hinta_text.Text;
            decimal lukema;
            if (decimal.TryParse(raha, out lukema))
            {
                Hinta_text.Text = raha;
            }
            else if (raha == "")
            {
            }
            else
            {
                virhe = "vain numeroita! desimaaliluku pilkulla";
                MessageBox.Show(virhe, virhe, MessageBoxButtons.OK);
            }
        }

        private void rekisteri_PVM_ValueChanged(object sender, EventArgs e)
        {
        }
        public bool UusiAuto()
        {
            bool palaute;
            Kulkuneuvo tallennettavaAuto = new kauppaservice.Kulkuneuvo();
      
            tallennettavaAuto.AutonMalliID = (int)malli_laatikko.SelectedValue;
            tallennettavaAuto.AutonMerkkiID = (int)Merkki_laatikko.SelectedValue;
            tallennettavaAuto.PolttoaineID = (int)Polttoaine_laatikko.SelectedValue;
            tallennettavaAuto.VaritID = (int)Vari_laatikko.SelectedValue;
            tallennettavaAuto.Mittarilukema = int.Parse(Mittarilukema_Text.Text);
            tallennettavaAuto.Moottorintilavuus = decimal.Parse(Moottori_text.Text);
            tallennettavaAuto.Hinta = decimal.Parse(Hinta_text.Text);
            tallennettavaAuto.Rekisteröiti_päivämäärä = rekisteri_PVM.Value;
            palaute = Rekisteri.saveAutoIntoDatabase(tallennettavaAuto);
            return palaute;
        }
        private void Uusi_tietue_nappi_Click(object sender, EventArgs e)
        {
            Merkki_laatikko.Text = "";
            malli_laatikko.Text = "";
            Polttoaine_laatikko.Text = "";
            Vari_laatikko.Text = "";
            Mittarilukema_Text.Text = "";
            Moottori_text.Text = "";
            Hinta_text.Text = "";
            rekisteri_PVM.Value = DateTime.Today;
        }
        private void Tallenna_nappi_Click(object sender, EventArgs e)
        {
            if (Merkki_laatikko.Text != "" && malli_laatikko.Text != "" && Polttoaine_laatikko.Text != "" && Vari_laatikko.Text != "" && Mittarilukema_Text.Text != "" && Hinta_text.Text != "")
            {
                string viesti, palkki = "auton lisäys"; ;
                bool palaute =UusiAuto();
                if (palaute == true)
                {
                    viesti = "auton lisäys onnistui!";
                    MessageBox.Show(viesti, palkki, MessageBoxButtons.OK);
                }
                else
                {
                    viesti = "auton lisäys ei onnistunut.";
                    MessageBox.Show(viesti, palkki, MessageBoxButtons.OK);
                }
            }
            else
            {
                virhe = "Täytä kaikki kentät";
                MessageBox.Show(virhe, virhe, MessageBoxButtons.OK);
            }
        }
        
        private void Seuraava_Click(object sender, EventArgs e)
        {
            int tamanHetkenID,autonID;
            bool onnistui = int.TryParse(lbNykyinenID.Text, out tamanHetkenID);

            if (onnistui)
            {
                autonID = SeuraavanAutonhaku(tamanHetkenID);
                lbNykyinenID.Text = autonID.ToString();
            }
            else
            {
                tamanHetkenID = SeuraavanAutonhaku(0);
                lbNykyinenID.Text = "1";
            }
        }

        private void Edellinen_Click(object sender, EventArgs e)
        {
            int tamanHetkenID, autonID;
            bool onnistui = int.TryParse(lbNykyinenID.Text, out tamanHetkenID);

            if (onnistui)
            {
                autonID = EdellisenAutonhaku(tamanHetkenID);
                lbNykyinenID.Text = autonID.ToString();
            }
            else
            {
                tamanHetkenID = EdellisenAutonhaku(0);
                lbNykyinenID.Text = "1";
            }
        }

        private int SeuraavanAutonhaku(int nykyinenID)
        {
            Kulkuneuvo auto = Rekisteri.SeuraavaAutoTietokannassa(nykyinenID);
            Mittarilukema_Text.Text = auto.Mittarilukema.ToString();
            Moottori_text.Text = auto.Moottorintilavuus.ToString();
            Hinta_text.Text = auto.Hinta.ToString();
            rekisteri_PVM.Value = auto.Rekisteröiti_päivämäärä;
            Autonmerkki merkki = Rekisteri.HaeValmisMerkki(auto.AutonMerkkiID);
            Autonmallit malli = Rekisteri.HaeValmisMalli(auto.AutonMalliID);
            Vari vari = Rekisteri.HaeValittuVäri(auto.VaritID);
            Polttoaine polttoaine = Rekisteri.HaeValittuPolttoaine(auto.PolttoaineID);
            Merkki_laatikko.SelectedIndex = Merkki_laatikko.FindStringExact(merkki.MerkkiNimi);
            malli_laatikko.SelectedIndex = malli_laatikko.FindStringExact(malli.MalliNimi);
            Vari_laatikko.SelectedIndex = Vari_laatikko.FindStringExact(vari.Varit);
            Polttoaine_laatikko.SelectedIndex = Polttoaine_laatikko.FindStringExact(polttoaine.Polttoaineet);
            return auto.Id;
        }

        private int EdellisenAutonhaku(int nykyinenID)
        {

            Kulkuneuvo auto = Rekisteri.EdellinenAutoTietokannassa(nykyinenID);
            Mittarilukema_Text.Text = auto.Mittarilukema.ToString();
            Moottori_text.Text = auto.Moottorintilavuus.ToString();
            Hinta_text.Text = auto.Hinta.ToString();
            rekisteri_PVM.Value = auto.Rekisteröiti_päivämäärä;
            Autonmerkki merkki = Rekisteri.HaeValmisMerkki(auto.AutonMerkkiID);
            Autonmallit malli = Rekisteri.HaeValmisMalli(auto.AutonMalliID);
            Vari vari = Rekisteri.HaeValittuVäri(auto.VaritID);
            Polttoaine polttoaine = Rekisteri.HaeValittuPolttoaine(auto.PolttoaineID);
            Merkki_laatikko.SelectedIndex = Merkki_laatikko.FindStringExact(merkki.MerkkiNimi);
            malli_laatikko.SelectedIndex = malli_laatikko.FindStringExact(malli.MalliNimi);
            Vari_laatikko.SelectedIndex = Vari_laatikko.FindStringExact(vari.Varit);
            Polttoaine_laatikko.SelectedIndex = Polttoaine_laatikko.FindStringExact(polttoaine.Polttoaineet);
            return auto.Id;
        }


    }
}
