using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
namespace NetListOfT
{
    public class MyList:IEquatable<MyList>
    {
        public string Name { get; set; }
        public int StudioAlbums { get;  set; }
        public string Genre { get;  set; }
        public string Country { get; set; }

        public MyList()
        { }
        public MyList(string name, int studioAlbums, string genre, string country)
        {
            Name = name;
            StudioAlbums = studioAlbums;
            Genre = genre;
            Country = country;
        }
        public int Count { get {return Count;} }
        public void Add(MyList item)
        {

            item.Add(new MyList());
        }
        public MyList this[int index]
        {
            get { return this[index]; } 
            set{
                  if(index<0||index>Count)
                           throw new ArgumentOutOfRangeException("!!!");  
                } 
        }
        public bool Equals(MyList item)
        {
            if (this.Name == item.Name && this.StudioAlbums == item.StudioAlbums && this.Genre == item.Genre && this.Country == item.Country)
                return true;
            else
                return false;
            }
       public bool Contains(MyList item)
        {
           if(item.Contains(new MyList()))
               return true;
           else
               return false;
        }
       
        public override string ToString()
        {
            return "Name: " +Name  + ", Studio Albums: " + StudioAlbums+", Genre:"+Genre+", Country:"+Country;
        }
       
    }
}
