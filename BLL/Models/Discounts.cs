using BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class Discounts
    {
        public Discounts(int val)
        {
            _value = val;
        }

        private int _value = 0;
        public int Value { get { return _value; } }

        public int GetDiscountedPrice(int sum)
        {
            if (DateTime.Now.Day == 1)
                return sum - sum * _value;
            return sum;
        }
    }
}
