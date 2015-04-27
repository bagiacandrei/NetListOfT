using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetListOfT
{
    /*public class MyListCollection : Collection<MyList>
    {
        public MyListCollection(IEnumerable<MyList> bands) : base(bands.ToList()) { }
        protected override void RemoveItem(int index)
        {
            var bandToBeRemoved = Items[index].Name;
            if (index < 0 || index > Count)
                throw new ArgumentOutOfRangeException("");

            base.RemoveItem(index);

            var newBandAtIndex = index >= Items.Count ? "it was the last band" : String.Format("now {0} is at index {1}", Items[index].Name, index);

            Console.WriteLine("Removed {0}, {1}", bandToBeRemoved, newBandAtIndex);
        }

        protected override void ClearItems()
        {
            base.ClearItems();
        }
    }*/




}
