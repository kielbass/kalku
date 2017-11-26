using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalku
{
    class Memory
    {
        private decimal _value;
        public decimal Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
            }
        }
        public void MR()
        {
            _value = 0;
        }
        public Memory()
        {
                
        }
        public override string ToString()
        {
            return  string.Format(_value.ToString());
        }
        public void Change(string s,bool add)
        {
            decimal.TryParse(s, out decimal a);
            if (add)
            {
                _value += a;
            }
            else
            {
                _value -= a;
            }
        }

    }
}
