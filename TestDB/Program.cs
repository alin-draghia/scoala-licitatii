using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LicitatiiDAL;

namespace TestDB
{
    class Program
    {
        static void Main(string[] args)
        {

            AdaugareVanzatori();
            //ListareVanzatori();
            //AdaugareCumparatori();
            //ListareCumparatori();
            Console.ReadLine();
        }

        private static void ListareVanzatori()
        {
            using (var ctx = new LicitatiiContext())
            {
                Console.WriteLine("Listare vanzatori");
                var vanzatori = ctx.Utilizatori.OfType<Vanzator>().ToList();
                foreach (var vanzator in vanzatori)
                {
                    Console.WriteLine(vanzator);
                }
            }
        }

        private static void AdaugareVanzatori()
        {
            using (var ctx = new LicitatiiContext())
            {

                try
                {
                    ctx.Utilizatori.Add(
                        new Vanzator()
                        {
                            Adresa = "Brasov, Brasov, Paraului nr. 5",
                            Nume = "Draghia",
                            Prenume = "Alin",
                            Username = "alin2",
                            Password = "login"
                        }
                    );



                    ctx.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        private static void ListareCumparatori()
        {
            using (var ctx = new LicitatiiContext())
            {
                Console.WriteLine("Listare cumparatori");
                var cumparatori = ctx.Utilizatori.OfType<Cumparator>().ToList();
                foreach (var cumparator in cumparatori)
                {
                    Console.WriteLine(cumparator.ToString());
                }
            }
        }

        private static void AdaugareCumparatori()
        {
            using (var ctx = new LicitatiiContext())
            {

                ctx.Utilizatori.Add(
                    new Cumparator()
                    {                        
                        Nume = "Popa",
                        Prenume = "Vasile",
                        Username = "vasile",
                        Password = "login",
                        CNP = "1xxxxxxxxxxxx",
                        Telefon = "07********"
                    }
                );

                ctx.Utilizatori.Add(
                    new Cumparator()
                    {
                        Nume = "Popescu",
                        Prenume = "Ana-Maria",
                        Username = "anamari",
                        Password = "login",
                        CNP = "2xxxxxxxxxxxx",
                        Telefon = "07********"
                    }
                );

                ctx.SaveChanges();

            }
        }
    }
}
