﻿using System;
using System.Xml.Serialization;
using windows = System.Windows;

namespace cAlgo.API.Alert.Models
{
    public class FontWeightModel
    {
        #region Fields

        private string _name;

        #endregion Fields

        #region Properites

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;

                Weight = (windows.FontWeight)typeof(windows.FontWeights).GetProperty(_name).GetValue(null);
            }
        }

        [XmlIgnore]
        public windows.FontWeight Weight { get; set; }

        #endregion Properites

        #region Methods

        public static bool operator !=(FontWeightModel obj1, FontWeightModel obj2)
        {
            if (obj1 is null)
            {
                return obj2 is object;
            }

            return !obj1.Equals(obj2);
        }

        public static bool operator ==(FontWeightModel obj1, FontWeightModel obj2)
        {
            if (obj1 is null)
            {
                return obj2 is null;
            }

            return obj1.Equals(obj2);
        }

        public override bool Equals(object obj)
        {
            if (!(obj is FontWeightModel))
            {
                return false;
            }

            return Equals((FontWeightModel)obj);
        }

        public bool Equals(FontWeightModel other)
        {
            return other != null && Name.Equals(other.Name, StringComparison.InvariantCultureIgnoreCase);
        }

        public override int GetHashCode()
        {
            int hash = 17;

            hash += (hash * 31) + (!string.IsNullOrEmpty(Name) ? Name.GetHashCode() : 0);

            return hash;
        }

        #endregion Methods
    }
}