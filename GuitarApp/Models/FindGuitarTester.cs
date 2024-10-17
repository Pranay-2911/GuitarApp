using GuitarApp.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp.Models
{
    internal class FindGuitarTester
    {
        public List<Guitar> FindGuitar()
        {
            GuitarSpec findGuitar = new GuitarSpec(Builder.COLLINGS, "model2", 7, Types.Types.ELECTRIC, Wood.ALDER, Wood.ALDER);
            List<Guitar> similarGuitars = Inventory.SearchGuitar(findGuitar);

            
            return similarGuitars ?? new List<Guitar>();
        }
    }
}
