using System;

namespace Olio_tehtävä_9
{

    class Televisio
    {
        private string text;
        private string kanava;
        private int volume;
        public static int laskuri = 0;
    
        public Televisio()
        {
            text = "";
            kanava = "";
            volume = 0;
            laskuri++;
            Console.WriteLine("Käytit oletuskonstruktoria");
        }

        public Televisio (string u_text, string u_kanava, int u_volume)
        {
            text = u_text;
            kanava = u_kanava;
            volume = u_volume;
            laskuri++;
            Console.WriteLine("Käytit ylikuormitettua konstruktoria");
        }

        public string Text
        {
            set { Console.WriteLine("Käytit setteriä"); text = value;}
            get { Console.WriteLine("Käytit getteriä"); return text;}
        }

        public string Kanava
        {
            set { Console.WriteLine("Käytit setteriä"); kanava = value;}
            get { Console.WriteLine("Käytit getteriä"); return kanava;}
        }

        public int Volume
        {
            set { Console.WriteLine("Käytit setteriä"); volume = value;}
            get { Console.WriteLine("Käytit getteriä"); return volume;}
        }

        public string Tekstitys()
        {
            Console.WriteLine("Tekstitys metodia käytetty");
            Console.Write("Minkä tekstityksen haluaisit: ");
            text = Console.ReadLine();
            return text;
        }

        public string KanavanVaihdos()
        {
            int kanavanimi;
            Console.WriteLine("KanavanVaihdos metodia käytetty");
            Console.Write("Mitä Kanavaa haluaisit katsoa: ");
            kanavanimi = int.Parse(Console.ReadLine());
            Alku:

            switch (kanavanimi)
            {
                case 1:
                    if (kanavanimi == 1)
                    kanava = "Yle Ykkönen";
                    break;
                case 2:
                    if (kanavanimi == 2)
                    kanava = "Yle Kakkonen";
                    break;
                case 3:
                    if (kanavanimi == 3)
                    kanava = "MTV3";
                    break;
                case 4:
                    if (kanavanimi == 4)
                    kanava = "Nelonen";
                    break;
                case 5:
                    if (kanavanimi == 5)
                    kanava = "Yle Fem";
                    break;
                case 6:
                    if (kanavanimi == 6)
                    kanava = "Sub";
                    break;
                default:
                    Console.WriteLine("En voi näyttää ohjelmia tuolta kanavalta!\nValitse kanavista 1-6: ");
                    kanavanimi = int.Parse(Console.ReadLine());
                    goto Alku;
            }
            return kanava;
        }

        public int AanenMuutos()
        {
            Console.WriteLine("AanenMuutos metodia käyetty");
            Console.Write("Haluatko vaihtaa äänen tasoa: ");
            volume = int.Parse(Console.ReadLine());
            return volume;
        }

        public void TeleKatselu()
        {
            Console.WriteLine("------------\n" + "Tekstitys asetettu: " + Text + "\nKatsot kanavaa: " + Kanava + "\nÄänen taso on: " + Volume + "%" + "\n------------");
        }
    }

    internal class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arttu Mäkelä / Olio tehtävä 9");

            Televisio teevee1 = new Televisio();

            teevee1.Text = "Englanti";
            teevee1.Kanava = "";
            teevee1.Volume = 0;
            teevee1.TeleKatselu();

            string u_text = "";
            string u_kanava = "";
            int u_volume = 0;

            Televisio teevee2 = new Televisio(u_text, u_kanava, u_volume);
            string vastaus;
            loop:

            Console.WriteLine("Haluatko vaihtaa asetuksia tai kanavaa? (K/E)" );
            vastaus = Console.ReadLine();

            if (vastaus == "K" || vastaus == "k")
            {
                teevee2.Tekstitys();
                teevee2.KanavanVaihdos();
                teevee2.AanenMuutos();
                teevee2.TeleKatselu();
                goto loop;
            }

            else
            {
                teevee2.TeleKatselu();
                Console.WriteLine("Loit {0} oliota.", Televisio.laskuri);
            }
        }
    }
}