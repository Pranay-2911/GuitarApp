using GuitarApp.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp.Models
{
    internal class Inventory
    {
        static List<Guitar> guitars = new List<Guitar>();


        public void AddGuitar(String serialno, double price, Builder builder, string model, int numString, Types.Types type, Wood backwood, Wood topwood)
        {
            GuitarSpec spec = new GuitarSpec(builder, model, numString, type, backwood, topwood);
            Guitar guitar = new Guitar(serialno, price, spec);
            guitars.Add(guitar);
        }

        public Guitar GetGuitar(String serialno)
        {
            Guitar guitar = guitars.Where(g => g.SerialNumber == serialno).FirstOrDefault();
            if (guitar != null)
            {
                return guitar;
            }
            return null;
        }

        public static List<Guitar> SearchGuitar(GuitarSpec searchGuitar)
        {
            List<Guitar> similarGuitaras = new List<Guitar>();

            foreach (Guitar guitar in guitars)
            {
                GuitarSpec specs = guitar.GetSpec();
                if (guitar.GetSpec().Matche(searchGuitar))
                {
                    similarGuitaras.Add(guitar);
                }


            }
            return similarGuitaras;
        }
    }
}
