using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BeerShop.Data
{
  
    class EmptyDataGrid : Exception
    {
        public string value = " неможливе, в таблиці відсутні дані";
        public EmptyDataGrid(string value)
        {
            value += this.value;
        }
    }
    public class FoodWeightException : Exception
    {
        public string value;
        public FoodWeightException(string Value)
        {
            this.value = Value;
        }
    }
    public class BeerStrenghtException : Exception
    {
        public string value;
        public BeerStrenghtException(string value)
        {
            this.value = value;
        }
    }
    public class PriceException : Exception
    {
        public string value;
        public PriceException(string value)
        {
            this.value = value;
        }
    }
    public class FoodTypeError : Exception
    {
        public string value;
        public FoodTypeError(string value)
        {
            this.value = value;
        }
    }
}