using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetListOfT
{
    class Program
    {
        public static void Main()
        {
            List<MyList> bands = new List<MyList>();
           bands.Add(new MyList() { Name = "Led Zeppelin", StudioAlbums = 9, Genre = "Hard Rock", Country = "England" });
           bands.Add(new MyList() { Name = "Judas Priest", StudioAlbums = 17, Genre = "Heavy Metal", Country = "England" });
           bands.Add(new MyList() { Name = "Phoenix", StudioAlbums = 10, Genre = "Rock", Country = "Romania" });
           bands.Add(new MyList() { Name = "Black Sabbath", StudioAlbums = 19, Genre = "Heavy Metal", Country = "England" });
           bands.Add(new MyList() { Name = "Rammstein", StudioAlbums = 6, Genre = "Industrial Metal", Country = "Germany" });
            Console.WriteLine();
            foreach (MyList band in bands)
            {
                Console.WriteLine(band);
            }
            Console.WriteLine(); 
            Console.WriteLine("\nCount :{0}", bands.Count());//nr de elemente din lista
                 
            Console.WriteLine();
            
            var formatie = new MyList() { Name = "Abba", StudioAlbums = 20, Genre = "Soft Rock", Country = "SUA" };
            bands.Add(formatie);//adaugarea unui element la sfarsitul listei;

            foreach (MyList band in bands)
            {
                Console.WriteLine(band);
            }
          
            Console.WriteLine("\nElementul cautat in functie de index:\n{0}", bands[3]);
            Console.WriteLine("\nContains: {0}", bands.Contains(new MyList { Name = "Abba", StudioAlbums = 20, Genre = "Soft Rock", Country = "SUA" }));
            var bandsCollection = new MyListCollection(bands);
            Console.WriteLine("________________");
            bandsCollection.RemoveAt(2);
            foreach (MyList band in bands)
            {
                Console.WriteLine(band);
            }
             bands.Clear();//sterge toata lista

            Console.WriteLine("\nCount :{0}", bands.Count());

            Console.WriteLine("________________");
            foreach (MyList band in bands)
                Console.WriteLine(band.Name + " " + band.StudioAlbums + " " + band.Genre + " "+band.Country);
        }

        
        }
    }

