using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfAutokauppa
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        bool connectDatabase();

        [OperationContract]
        bool saveAutoIntoDatabase(Kulkuneuvo tallenne);

        [OperationContract]
        List<Autonmerkki> GetAllAutoMakersFromDatabase();

        [OperationContract]
        Autonmallit HaeValmisMalli(int malliID);

        [OperationContract]
        Vari HaeValittuVäri(int VariID);

        [OperationContract]
        Polttoaine HaeValittuPolttoaine(int PolttoaineID);

        [OperationContract]
        List<Autonmallit> GetAutoModelsByMakerId(int makerId);

        [OperationContract]
        Autonmerkki HaeValmisMerkki(int merkkiID);

        [OperationContract]
        List<Polttoaine> HaePolttoaine();

        [OperationContract]
        List<Vari> haeVari();

        [OperationContract]
        Kulkuneuvo SeuraavaAutoTietokannassa(int nykyinen);

        [OperationContract]
        Kulkuneuvo EdellinenAutoTietokannassa(int nykyinen);

        [OperationContract]
        void disconnectDatabase();
    }


    [DataContract]
    public class Kulkuneuvo
    {
        
        private int id, mittarilukema, AutonMerkkiiD, AutonMalliiD, VaritiD, PolttoaineiD;
        private decimal hinta, moottorintilavuus;
        private DateTime rekisteröiti_päivämäärä;
        
        public Kulkuneuvo()
        {
        }
        [DataMember]
        public int Id { get => id; set => id = value; }
        [DataMember]
        public int Mittarilukema { get => mittarilukema; set => mittarilukema = value; }
        [DataMember]
        public int AutonMerkkiID { get => AutonMerkkiiD; set => AutonMerkkiiD = value; }
        [DataMember]
        public int AutonMalliID { get => AutonMalliiD; set => AutonMalliiD = value; }
        [DataMember]
        public int VaritID { get => VaritiD; set => VaritiD = value; }
        [DataMember]
        public int PolttoaineID { get => PolttoaineiD; set => PolttoaineiD = value; }
        [DataMember]
        public decimal Hinta { get => hinta; set => hinta = value; }
        [DataMember]
        public decimal Moottorintilavuus { get => moottorintilavuus; set => moottorintilavuus = value; }
        [DataMember]
        public DateTime Rekisteröiti_päivämäärä { get => rekisteröiti_päivämäärä; set => rekisteröiti_päivämäärä = value; }
    }

    [DataContract]
    public class Autonmerkki
    {
        int Id;
        string merkkiNimi;

        public Autonmerkki()
        {
        }
        [DataMember]
        public int ID { get => Id; set => Id = value; }
        [DataMember]
        public string MerkkiNimi { get => merkkiNimi; set => merkkiNimi = value; }
    }

    [DataContract]
    public class Autonmallit
    {
        private string malliNimi;
        private int merkkiId, Id;
        public Autonmallit()
        {
        }
        [DataMember]
        public string MalliNimi { get => malliNimi; set => malliNimi = value; }
        [DataMember]
        public int MerkkiId { get => merkkiId; set => merkkiId = value; }
        [DataMember]
        public int ID { get => Id; set => Id = value; }
    }

    [DataContract]
    public class Polttoaine
    {
        int iD;
        string polttoaineet;
        public Polttoaine()
        {
        }
        [DataMember]
        public string Polttoaineet { get => polttoaineet; set => polttoaineet = value; }
        [DataMember]
        public int ID { get => iD; set => iD = value; }
    }

    [DataContract]
    public class Vari
    {
        int id;
        string vari;
        public Vari()
        {
        }
        [DataMember]
        public int ID { get => id; set => id = value; }
        [DataMember]
        public string Varit { get => vari; set => vari = value; }
    }
}
