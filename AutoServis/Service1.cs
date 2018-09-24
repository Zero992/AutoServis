using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AutoServis
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single,
        ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class AutoServis : ISistem, IOperater, IKlijent
    {
        List<PodatakAutomobila> pauto;
        List<PodatakKorisnik> pkori;
        List<PodatakPopravke> ppop;
        List<PodatakPlacenePopravke> pplp;
        List<PodatakAutomobilaUK> pautou;

        public AutoServis()
        {
            pauto = new List<PodatakAutomobila>();
            pkori = new List<PodatakKorisnik>();
            ppop = new List<PodatakPopravke>();
            pplp = new List<PodatakPlacenePopravke>();
            pautou = new List<PodatakAutomobilaUK>();
        }

        public void Korisnik(string korisnicko_ime, string password)
        {
            PodatakKorisnik k = new PodatakKorisnik();
            k.korisnicko_ime = korisnicko_ime;
            k.password = password;
            pkori.Add(k);
        }

        public void Automobil(int id_automobila, string podaci, string status, double cena_popravke, string korisnicko_ime, int id_popravke)
        {
            PodatakAutomobila a = new PodatakAutomobila();
            a.id_automobila = id_automobila;
            a.podaci = podaci;
            a.status = status;
            a.cena_popravke = cena_popravke;
            a.korisnicko_ime = korisnicko_ime;
            a.id_popravke = id_popravke;
            pauto.Add(a);
        }
        public void Popravka(int id_popravke, string deo, double cena_dela)
        {
            PodatakPopravke p = new PodatakPopravke();
            p.id_popravke = id_popravke;
            p.deo = deo;
            p.cena_dela = cena_dela;
        }


        public PodaciAutomobila UkupniTroskovi()
        {
            PodaciAutomobila podaci = new PodaciAutomobila();
            foreach (PodatakAutomobila podatak in pauto)
            {
                if (podaci.SingleOrDefault(p => p.korisnicko_ime == podatak.korisnicko_ime) != null)
                    continue;
                double ukupno = pauto.Where(p => p.korisnicko_ime == podatak.korisnicko_ime).Sum(p => p.cena_popravke);
                PodatakAutomobila novi = new PodatakAutomobila();
                novi.id_automobila = podatak.id_automobila;
                novi.podaci = podatak.podaci;
                novi.status = podatak.status;
                novi.cena_popravke = ukupno;
                novi.korisnicko_ime = podatak.korisnicko_ime;
                novi.id_popravke = podatak.id_popravke;
                podaci.Add(novi);
            }
            return podaci;
        }
        public void brisiAuto(int id_automobila)
        {
            int b = 0;
            foreach (PodatakAutomobila podatak in pauto)
            {
                if (id_automobila == podatak.id_automobila) { pauto.Remove(podatak); break; }
                b++;
            }
        }
        public void brisiKorisnika(string korisnicko_ime)
        {
            int b = 1;
            foreach (PodatakKorisnik podatak in pkori)
            {
                if (korisnicko_ime == podatak.korisnicko_ime) { pkori.Remove(podatak); break; }
                b++;
            }
        }
        public void brisiPopravke(int id_popravke)
        {
            int b = 0;
            foreach (PodatakPopravke podatak in ppop)
            {
                if (id_popravke == podatak.id_popravke) { ppop.Remove(podatak); break; }
                b++;
            }

        }

        public bool LogInOperater(string korisnicko_ime, string password)
        {
            if (korisnicko_ime == "operater" && password == "operater") return true;
            else return false;

        }
        public bool LogInAdministrator(string korisnicko_ime, string password)
        {
            if (korisnicko_ime == "admin" && password == "admin") return true; else return false;

        }
        public bool LogInKorisnik(string korisnicko_ime, string password)
        {
            foreach (PodatakKorisnik podatak in pkori)
            {
                if ((korisnicko_ime == podatak.korisnicko_ime) && (password == podatak.password)) return true;
            }
            return false;

        }
        public void AzuriranjeCene(string deo, int cena_dela)
        {
            int b = 0;
            foreach (PodatakPopravke podatak in ppop)
            {
                if (deo == podatak.deo && cena_dela!=podatak.cena_dela)
                {
                    PodatakPopravke novi = new PodatakPopravke();
                    novi.id_popravke = podatak.id_popravke;
                    novi.deo = podatak.deo;
                    novi.cena_dela = cena_dela;
                    ppop.RemoveAt(b);
                    ppop.Add(novi);
                    b++;
                }
                b++;
            }
        }


        public void Uplati(string korisnicko_ime)
        {
            var q = from p in pauto
                    group p by p.korisnicko_ime into g
                    select new PodatakAutomobila
                    {
                        korisnicko_ime = g.Key,
                        cena_popravke = g.Sum(x => x.cena_popravke)
                    };
            PodaciAutomobila pod = new PodaciAutomobila();
            pod.AddRange(q);
            foreach (PodatakAutomobila podatak in pod)
            {
                if (korisnicko_ime == podatak.korisnicko_ime)
                {
                    PodatakPlacenePopravke novi = new PodatakPlacenePopravke();
                    novi.korisnicko_ime = podatak.korisnicko_ime;
                    novi.cena_popravke = podatak.cena_popravke;
                    pplp.Add(novi);
                }
            }
            
        }

        public string UkupniTroskoviString()
        {
            var q = from p in pauto
                    group p by p.korisnicko_ime into g
                    select new PodatakAutomobila
                    {
                        korisnicko_ime = g.Key,
                        cena_popravke = g.Sum(x => x.cena_popravke)
                    };
            PodaciAutomobila pod = new PodaciAutomobila();
            pod.AddRange(q);
            string celi="";
            foreach (PodatakAutomobila podatak in pod) 
            {
                celi += podatak.korisnicko_ime + " " + podatak.cena_popravke + "@";
            }
            celi = celi.Replace("@", "@" + System.Environment.NewLine);
            return celi;
        }

        public string PrikazKorisniku(string korisnicko_ime)
        {
            var q = from p in pauto
                    group p by p.korisnicko_ime into g
                    select new PodatakAutomobila
                    {
                        korisnicko_ime = g.Key,
                        cena_popravke = g.Sum(x => x.cena_popravke)
                    };
            PodaciAutomobila pod = new PodaciAutomobila();
            pod.AddRange(q);
            string celi = "";
            foreach (PodatakAutomobila podatak in pod)
            {
                if (korisnicko_ime == podatak.korisnicko_ime)
                {
                    celi += podatak.korisnicko_ime + " " + podatak.cena_popravke + "@";
                }
            }
            celi = celi.Replace("@", "@" + System.Environment.NewLine);
            return celi;
        }
    }
}
