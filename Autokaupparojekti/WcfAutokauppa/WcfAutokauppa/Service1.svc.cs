using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data.SqlClient;

namespace WcfAutokauppa
{
    public class Service1 : IService1
    {
        string yhteysTiedot = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Autokauppa;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection dbYhteys = new SqlConnection();
        public bool connectDatabase()
        {

            dbYhteys.ConnectionString = yhteysTiedot;

            try
            {
                dbYhteys.Open();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Virheilmoitukset:" + e);
                dbYhteys.Close();
                return false;

            }

        }

        public void disconnectDatabase()
        {
            dbYhteys.Close();
        }

        public bool saveAutoIntoDatabase(Kulkuneuvo newAuto)
        {
            bool palaute = false;
            connectDatabase();
            string haku = "INSERT INTO auto (Hinta,Rekisteri_paivamaara,Moottorin_tilavuus,Mittarilukema,AutonMerkkiID,AutonMalliID,VaritID,PolttoaineID)VALUES(@hinta , @pvm , @moottori , @mittari , @merkki , @malli , @vari , @polttoaine)";
            SqlCommand käsky = new SqlCommand(haku, dbYhteys);
            käsky.Parameters.Add(new SqlParameter("hinta", newAuto.Hinta));
            käsky.Parameters.Add(new SqlParameter("pvm", newAuto.Rekisteröiti_päivämäärä));
            käsky.Parameters.Add(new SqlParameter("moottori", newAuto.Moottorintilavuus));
            käsky.Parameters.Add(new SqlParameter("mittari", newAuto.Mittarilukema));
            käsky.Parameters.Add(new SqlParameter("merkki", newAuto.AutonMerkkiID));
            käsky.Parameters.Add(new SqlParameter("malli", newAuto.AutonMalliID));
            käsky.Parameters.Add(new SqlParameter("vari", newAuto.VaritID));
            käsky.Parameters.Add(new SqlParameter("polttoaine", newAuto.PolttoaineID));

            int tulos = käsky.ExecuteNonQuery();
            disconnectDatabase();

            if (tulos == 1)
            {
                palaute = true;
            }

            return palaute;
        }

        public List<Autonmerkki> GetAllAutoMakersFromDatabase()
        {

            List<Autonmerkki> palaute = new List<Autonmerkki>();
            string haku = "SELECT * FROM AutonMerkki";
            connectDatabase();
            string merkkinimi, ID_string;
            int ID;
            SqlCommand käsky = new SqlCommand(haku, dbYhteys);
            SqlDataReader Lukija = käsky.ExecuteReader();

            while (Lukija.Read())
            {
                Autonmerkki haeMerkki = new Autonmerkki();
                ID_string = string.Format("{0}", Lukija[0]);
                ID = int.Parse(ID_string);
                haeMerkki.ID = ID;
                merkkinimi = string.Format("{0}", Lukija[1]);
                haeMerkki.MerkkiNimi =merkkinimi;
                palaute.Add(haeMerkki);
            }

            disconnectDatabase();
            return palaute;

        }
        
        public List<Autonmallit> GetAutoModelsByMakerId(int makerId)
        {
            List<Autonmallit> palaute = new List<Autonmallit>();
            string haku = "SELECT * FROM AutonMallit WHERE AutonMerkkiID=" + makerId;
            connectDatabase();
            string malli, ID_string;
            int ID;
            SqlCommand käsky = new SqlCommand(haku, dbYhteys);
            SqlDataReader Lukija = käsky.ExecuteReader();

            while (Lukija.Read())
            {
                Autonmallit haeMallit = new Autonmallit();
                ID_string = string.Format("{0}", Lukija[0]);
                ID = int.Parse(ID_string);
                haeMallit.ID = ID;
                malli = string.Format("{0}", Lukija[1]);
                haeMallit.MalliNimi =malli;
                palaute.Add(haeMallit);
            }

            disconnectDatabase();
            return palaute;
        }
        
        public List<Polttoaine> HaePolttoaine()
        {
            List<Polttoaine> palaute = new List<Polttoaine>();
            string haku = "SELECT * FROM Polttoaine";
            connectDatabase();
            int id;
            string polttoaine, ID_string;
            SqlCommand käsky = new SqlCommand(haku, dbYhteys);
            SqlDataReader Lukija = käsky.ExecuteReader();

            while (Lukija.Read())
            {
                Polttoaine haePolttoaineet = new Polttoaine();
                ID_string = string.Format("{0}", Lukija[0]);
                id = int.Parse(ID_string);
                polttoaine = string.Format("{0}", Lukija[1]);
                haePolttoaineet.Polttoaineet= polttoaine;
                haePolttoaineet.ID = id;
                palaute.Add(haePolttoaineet);
            }
            disconnectDatabase();
            return palaute;
        }
        
        public List<Vari> haeVari()
        {
            List<Vari> palaute = new List<Vari>();
            string haku = "SELECT * FROM Varit";
            connectDatabase();
            int id;
            string Vari, ID_string;
            SqlCommand käsky = new SqlCommand(haku, dbYhteys);
            SqlDataReader Lukija = käsky.ExecuteReader();

            while (Lukija.Read())
            {
                Vari haeVarit = new Vari();
                ID_string = string.Format("{0}", Lukija[0]);
                id = int.Parse(ID_string);
                Vari = string.Format("{0}", Lukija[1]);
                haeVarit.Varit= Vari;
                haeVarit.ID =id;
                palaute.Add(haeVarit);
            }

            disconnectDatabase();
            return palaute;
        }

        public Kulkuneuvo SeuraavaAutoTietokannassa(int nykyinen)
        {
            Kulkuneuvo auto = new Kulkuneuvo();
            string haku = "SELECT TOP 1 * FROM auto WHERE auto.ID > @nykyinenID";
            connectDatabase();
            SqlCommand käsky = new SqlCommand(haku, dbYhteys);
            käsky.Parameters.Add(new SqlParameter("nykyinenID", nykyinen));
            SqlDataReader Lukija = käsky.ExecuteReader();

            while (Lukija.Read())
            {

                auto.Id = int.Parse(string.Format("{0}", Lukija[0]));
                auto.Hinta = decimal.Parse(string.Format("{0}", Lukija[1]));
                auto.Rekisteröiti_päivämäärä = DateTime.Parse(string.Format("{0}", Lukija[2]));
                auto.Moottorintilavuus = decimal.Parse(string.Format("{0}", Lukija[3]));
                auto.Mittarilukema = int.Parse(string.Format("{0}", Lukija[4]));
                auto.AutonMerkkiID = int.Parse(string.Format("{0}", Lukija[5]));
                auto.AutonMalliID = int.Parse(string.Format("{0}", Lukija[6]));
                auto.VaritID = int.Parse(string.Format("{0}", Lukija[7]));
                auto.PolttoaineID = int.Parse(string.Format("{0}", Lukija[8]));
            }
            disconnectDatabase();
            if (auto.AutonMalliID == 0)
            {
                auto = Seuraavavara();
            }
            return auto;
        }
        public Kulkuneuvo Seuraavavara()
        {
            Kulkuneuvo auto = new Kulkuneuvo();
            string haku = "SELECT TOP 1 * FROM auto ORDER BY ID ASC";
            connectDatabase();
            SqlCommand käsky = new SqlCommand(haku, dbYhteys);
            SqlDataReader Lukija = käsky.ExecuteReader();
            while (Lukija.Read())
            {

                auto.Id = int.Parse(string.Format("{0}", Lukija[0]));
                auto.Hinta = decimal.Parse(string.Format("{0}", Lukija[1]));
                auto.Rekisteröiti_päivämäärä = DateTime.Parse(string.Format("{0}", Lukija[2]));
                auto.Moottorintilavuus = decimal.Parse(string.Format("{0}", Lukija[3]));
                auto.Mittarilukema = int.Parse(string.Format("{0}", Lukija[4]));
                auto.AutonMerkkiID = int.Parse(string.Format("{0}", Lukija[5]));
                auto.AutonMalliID = int.Parse(string.Format("{0}", Lukija[6]));
                auto.VaritID = int.Parse(string.Format("{0}", Lukija[7]));
                auto.PolttoaineID = int.Parse(string.Format("{0}", Lukija[8]));
            }
            disconnectDatabase();
            return auto;
        }
        public Kulkuneuvo Edellinenvara()
        {
            Kulkuneuvo auto = new Kulkuneuvo();
            string haku = "SELECT TOP 1 * FROM auto ORDER BY ID DESC";
            connectDatabase();
            SqlCommand käsky = new SqlCommand(haku, dbYhteys);
            SqlDataReader Lukija = käsky.ExecuteReader();
            while (Lukija.Read())
            {
                auto.Id = int.Parse(string.Format("{0}", Lukija[0]));
                auto.Hinta = decimal.Parse(string.Format("{0}", Lukija[1]));
                auto.Rekisteröiti_päivämäärä = DateTime.Parse(string.Format("{0}", Lukija[2]));
                auto.Moottorintilavuus = decimal.Parse(string.Format("{0}", Lukija[3]));
                auto.Mittarilukema = int.Parse(string.Format("{0}", Lukija[4]));
                auto.AutonMerkkiID = int.Parse(string.Format("{0}", Lukija[5]));
                auto.AutonMalliID = int.Parse(string.Format("{0}", Lukija[6]));
                auto.VaritID = int.Parse(string.Format("{0}", Lukija[7]));
                auto.PolttoaineID = int.Parse(string.Format("{0}", Lukija[8]));
            }
            disconnectDatabase();
            return auto;
        }
        public Kulkuneuvo EdellinenAutoTietokannassa(int nykyinen)
        {
            Kulkuneuvo auto = new Kulkuneuvo();
            string haku = "SELECT TOP 1 * FROM auto WHERE auto.ID < @nykyinenID ORDER BY ID DESC";
            connectDatabase();
            SqlCommand käsky = new SqlCommand(haku, dbYhteys);
            käsky.Parameters.Add(new SqlParameter("nykyinenID", nykyinen));
            SqlDataReader Lukija = käsky.ExecuteReader();
            while (Lukija.Read())
            {
                auto.Id = int.Parse(string.Format("{0}", Lukija[0]));
                auto.Hinta = decimal.Parse(string.Format("{0}", Lukija[1]));
                auto.Rekisteröiti_päivämäärä = DateTime.Parse(string.Format("{0}", Lukija[2]));
                auto.Moottorintilavuus = decimal.Parse(string.Format("{0}", Lukija[3]));
                auto.Mittarilukema = int.Parse(string.Format("{0}", Lukija[4]));
                auto.AutonMerkkiID = int.Parse(string.Format("{0}", Lukija[5]));
                auto.AutonMalliID = int.Parse(string.Format("{0}", Lukija[6]));
                auto.VaritID = int.Parse(string.Format("{0}", Lukija[7]));
                auto.PolttoaineID = int.Parse(string.Format("{0}", Lukija[8]));
            }
            disconnectDatabase();
            if (auto.AutonMalliID == 0)
            {
                auto = Edellinenvara();
            }
            return auto;
        }
        public Autonmerkki HaeValmisMerkki(int merkkiID)
        {
            Autonmerkki haeMerkki = new Autonmerkki();
            string haku = "SELECT * FROM AutonMerkki WHERE ID =" + merkkiID;
            connectDatabase();
            string merkkinimi, ID_string;
            int ID;
            SqlCommand käsky = new SqlCommand(haku, dbYhteys);
            SqlDataReader Lukija = käsky.ExecuteReader();

            while (Lukija.Read())
            {
                ID_string = string.Format("{0}", Lukija[0]);
                ID = int.Parse(ID_string);
                haeMerkki.ID=ID;
                merkkinimi = string.Format("{0}", Lukija[1]);
                haeMerkki.MerkkiNimi=merkkinimi;
            }

            disconnectDatabase();
            return haeMerkki;
        }
        public Autonmallit HaeValmisMalli(int malliID)
        {
            Autonmallit haeMalli = new Autonmallit();
            string haku = "SELECT * FROM AutonMallit A WHERE ID =" + malliID;
            connectDatabase();
            string mallinimi, ID_string;
            int ID;
            SqlCommand käsky = new SqlCommand(haku, dbYhteys);
            SqlDataReader Lukija = käsky.ExecuteReader();

            while (Lukija.Read())
            {
                ID_string = string.Format("{0}", Lukija[0]);
                ID = int.Parse(ID_string);
                haeMalli.ID = ID;
                mallinimi = string.Format("{0}", Lukija[1]);
                haeMalli.MalliNimi = mallinimi;
            }

            disconnectDatabase();
            return haeMalli;
        }
        public Vari HaeValittuVäri(int VariID)
        {
            Vari haeVari = new Vari();
            string haku = "SELECT * FROM Varit A WHERE ID =" + VariID;
            connectDatabase();
            string Vari, ID_string;
            int ID;
            SqlCommand käsky = new SqlCommand(haku, dbYhteys);
            SqlDataReader Lukija = käsky.ExecuteReader();

            while (Lukija.Read())
            {
                ID_string = string.Format("{0}", Lukija[0]);
                ID = int.Parse(ID_string);
                haeVari.ID = ID;
                Vari = string.Format("{0}", Lukija[1]);
                haeVari.Varit = Vari;
            }

            disconnectDatabase();
            return haeVari;
        }
        public Polttoaine HaeValittuPolttoaine(int PolttoaineID)
        {
            Polttoaine haePolttoaine = new Polttoaine();
            string haku = "SELECT * FROM Polttoaine A WHERE ID =" + PolttoaineID;
            connectDatabase();
            string Polttoaine, ID_string;
            int ID;
            SqlCommand käsky = new SqlCommand(haku, dbYhteys);
            SqlDataReader Lukija = käsky.ExecuteReader();

            while (Lukija.Read())
            {
                ID_string = string.Format("{0}", Lukija[0]);
                ID = int.Parse(ID_string);
                haePolttoaine.ID=ID;
                Polttoaine = string.Format("{0}", Lukija[1]);
                haePolttoaine.Polttoaineet=Polttoaine;
            }
            disconnectDatabase();
            return haePolttoaine;
        }
    }
}
