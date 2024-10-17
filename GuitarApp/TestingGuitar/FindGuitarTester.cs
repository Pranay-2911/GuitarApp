using GuitarApp.Exceptions;
using GuitarApp.Models;
using GuitarApp.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp.TestingGuitar
{
    internal class FindGuitarTester
    {
        public List<Guitar> FindGuitar()
        {
            GuitarSpec findGuitar = new GuitarSpec(Builder.COLLINGS, "model2", 7, Types.Types.ELECTRIC, Wood.ALDER, Wood.ALDER);
            List<Guitar> similarGuitars = Inventory.SearchGuitar(findGuitar);

            if (similarGuitars == null || similarGuitars.Count == 0)
            {
                throw new NoGuitarFounndException("No guitars matched your search specifications.");
            }

            return similarGuitars;
        }
    }
}
