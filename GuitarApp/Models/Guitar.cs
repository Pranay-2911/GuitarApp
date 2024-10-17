
using GuitarApp.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp.Models
{
    internal class Guitar
    {
        public string SerialNumber { get; set; }
        public double Price { get; set; }
       
        public GuitarSpec Spec { get; set; }

        public Guitar(string serialNumber, double price, GuitarSpec spec)
        {
            SerialNumber = serialNumber;
            Price = price;
            Spec = spec;
        }
        public GuitarSpec GetSpec()
        {
            
            return Spec;
            
        }
        public string GetSerialNumber()
        {
            return SerialNumber;
        }

        public double GetPrice()
        {
            return Price;
        }

        public void SetPrice(double price)
        {
            Price = price;
        }

        
        public  string PrintDetails()
        {
            return $"Guitar Deatils\n" +
                $"Serial no : {SerialNumber}\n" +
                $"Price : {Price}\n" +
                $"Builder: {Spec.Builder}\n" +
                $"Model : {Spec.Model}\n" +
                $"Type : {Spec.Type}\n" +
                $"Number of String : {Spec.GetNumberString()}\n" +
                $"Backwood : {Spec.BackWood}\n" +
                $"Topwood : {Spec.TopWood}\n";
        }

    }
}
