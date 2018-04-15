using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Sparrow s1 = new Sparrow("Bob");
            Sparrow s2 = new Sparrow("John");

            Dialog d = new Dialog(s1,s2);


        }
    }
    public class Dialog
    {
        public Sparrow speaker1, speaker2;
        private string[] replicBase = new string[] {
            "Иди своей дорогой сталкер",
            "Ути Собачкеа! Ути Котя! Ути Миша! Уйди отсюда мерское двуногое! Ути Миша!",
            "Го кс 1 на 1",
            "Ёхохо и бутылка пельмений"
        };

        public Dialog(Sparrow Man1, Sparrow Man2)
        {
            speaker1 = Man1;
            speaker2 = Man2;

            sayHello(speaker1);
            sayHello(speaker2);
            Random r = new Random();

            for (short i = 0; i <= 5; i++)
            {
                sayReplic(speaker1, replicBase[r.Next(replicBase.Length - 1)]);
            }
            sayReplic(speaker1, "Kurlic-Kurlic");
            sayReplic(speaker2, "Chiric-Chiric");
        }
        public void sayHello(Sparrow speaker)
        {
            Console.WriteLine("{0}: Hello!", speaker.name);
        }
        public void sayReplic(Sparrow speaker, string replic)
        {
            Console.WriteLine("{0}: {1}", speaker.name, replic);
        }
    }
    public class Sparrow
    {
        public string name;
        public Sparrow(string n) {
            this.name = n;
        }           
    }
}

