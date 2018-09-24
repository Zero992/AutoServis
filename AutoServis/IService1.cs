using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AutoServis
{
    [ServiceContract]
    public interface ISistem
    {
        [OperationContract]
        void Korisnik(string korisnicko_ime, string password);
        [OperationContract]
        void Automobil(int id_automobila, string podaci, string status, double cena_popravke, string korisnicko_ime, int id_popravke);
        [OperationContract]
        void Popravka(int id_popravke, string deo, double cena_dela);
        [OperationContract]
        void brisiAuto(int id_automobila);
        [OperationContract]
        void brisiKorisnika(string korisnicko_ime);
        [OperationContract]
        void brisiPopravke(int id_popravke);
        [OperationContract]
        void AzuriranjeCene(string deo, int cena_dela);
        [OperationContract]
        PodaciAutomobila UkupniTroskovi();
        [OperationContract]
        bool LogInAdministrator(string korisnicko_ime, string password);
        [OperationContract]
        string UkupniTroskoviString();

    }

    [ServiceContract]
    public interface IOperater
    {
        [OperationContract(Name = "OperaterLogin")]
        bool LogInOperater(string korisnicko_ime, string password);
        [OperationContract(Name = "OperaterAzuriranjeCene")]
        void AzuriranjeCene(string deo, int cena_dela);
        [OperationContract(Name = "OperaterKorisnik")]
        void Korisnik(string korisnicko_ime, string password);
        [OperationContract(Name = "OperaterAutomobil")]
        void Automobil(int id_automobila, string podaci, string status, double cena_popravke, string korisnicko_ime, int id_popravke);
        [OperationContract(Name = "OperaterPopravka")]
        void Popravka(int id_popravke, string deo, double cena_dela);
    }
    [ServiceContract]
    public interface IKlijent
    {
        [OperationContract]
        bool LogInKorisnik(string korisnicko_ime, string password);
        [OperationContract]
        void Uplati(string korisnicko_ime);
        [OperationContract]
        string PrikazKorisniku(string korisnicko_ime);
    }


    [DataContract]
    public class PodatakKorisnik
    {
        [DataMember]
        public string korisnicko_ime { get; set; }
        [DataMember]
        public string password { get; set; }
    }

    [DataContract]
    public class PodatakAutomobila
    {
        [DataMember]
        public int id_automobila { get; set; }
        [DataMember]
        public string podaci { get; set; }
        [DataMember]
        public string status { get; set; }
        [DataMember]
        public double cena_popravke { get; set; }
        [DataMember]
        public string korisnicko_ime { get; set; }
        [DataMember]
        public int id_popravke { get; set; }
    }

    [DataContract]
    public class PodatakPopravke
    {
        [DataMember]
        public int id_popravke { get; set; }
        [DataMember]
        public string deo { get; set; }
        [DataMember]
        public double cena_dela { get; set; }
    }

    [DataContract]
    public class PodatakPlacenePopravke
    {
        [DataMember]
        public string korisnicko_ime { get; set; }
        [DataMember]
        public double cena_popravke { get; set; }
    }

    [DataContract]
    public class PodatakAutomobilaUK
    {
        [DataMember]
        public int id_automobila { get; set; }
        [DataMember]
        public string podaci { get; set; }
        [DataMember]
        public string status { get; set; }
        [DataMember]
        public double cena_popravkeuk { get; set; }
        [DataMember]
        public string korisnicko_ime { get; set; }
        [DataMember]
        public int id_popravke { get; set; }
    }

    [CollectionDataContract]
    public class PodaciKorisnika : List<PodatakKorisnik> { }
    [CollectionDataContract]
    public class PodaciAutomobila : List<PodatakAutomobila> { }
    [CollectionDataContract]
    public class PodaciPopravke : List<PodatakPopravke> { }
    [CollectionDataContract]
    public class PodaciPlacenePopravke : List<PodatakPlacenePopravke> { }
}