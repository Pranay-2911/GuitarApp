using GuitarApp.Types;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp.Models
{
    internal class GuitarSpec
    {
        public Builder Builder { get; set; }
        public string Model { get; set; }
        public Types.Types Type { get; set; }
        public Wood BackWood { get; set; }
        public Wood TopWood { get; set; }
        private int _numString;

        public GuitarSpec(Builder builder, string model, int numString, Types.Types type, Wood backWood, Wood topWood)
        {
            Builder = builder;
            Model = model;
            _numString = numString;
            Type = type;
            BackWood = backWood;
            TopWood = topWood;
        }
        public Builder GetBuilder()
        {
            return Builder;
        }

        public string GetModel()
        {
            return Model;
        }

        public Types.Types GetType()
        {
            return Type;
        }

        public Wood GetBackWood()
        {
            return BackWood;
        }

        public Wood GetTopWood()
        {
            return TopWood;
        }
        public int GetNumberString()
        {
            return _numString;
        }

        public bool Matche(GuitarSpec searchGuitar)
        {
            if ((searchGuitar.GetBuilder() == Builder) 
                    && (searchGuitar.GetModel() == Model)
                    && (searchGuitar.GetType() == Type) 
                    && (searchGuitar.GetNumberString() == _numString)
                    && (searchGuitar.GetBackWood() == BackWood)
                    && (searchGuitar.GetTopWood() == TopWood))
            {
                return true;
            }
            return false;
        }
    }
}
