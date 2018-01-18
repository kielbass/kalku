using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalku
{/// <summary>
/// Klasa odpowiedzialna za działania matematyczne. 
/// </summary>
    class Expression
    {
        private string _value;
        public string Value
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
        private string _sign;
        public Expression()
        {
            
        }
        /// <summary>
        /// Zmiana wartosci przechowywanej przez klase.
        /// </summary>
        /// <param name="value">Wartość liczbowa.</param>
        /// <param name="sign">Znak działania matematycznego</param>
        public void Add(string value,string sign)
        {
            if(value=="0")
            {
                _sign = sign;
                return;
            }
            if(!string.IsNullOrEmpty(_value))
            {
                _value = Calculate(value).ToString();
                if(!string.IsNullOrEmpty(sign))
                {
                    _sign = sign;
                }
                else
                {
                    _sign = "";
                }
                return;
            }
            _value = value;
            _sign = sign;
        }
        public override string ToString()
        {
            return string.Format("{0} {1}",_value,_sign);
        }
        public void CE()
        {
            _value = "";
            _sign = "";
        }
        private decimal Calculate(string var)
        {
            decimal.TryParse(_value, out decimal a);
            decimal.TryParse(var, out decimal b);
            switch (_sign)
            {
                case "+":
                    {
                        a += b;
                    }
                    break;
                case "-":
                    {
                        a -= b;
                    }
                    break;
                case "*":
                    {
                        a *= b;
                    }
                    break;
                case "/":
                    {
                        a /= b;
                    }
                    break;
                case "%":
                    {
                        a %= b;
                        break;
                    }

            }
            return a;
        }
        //dla potegi 
        public void Pow(int j,string s)
        {
            decimal.TryParse(s, out decimal a);
            decimal b = a;
            for(int i=1;i<j;i++)
            {
                a *= b;
            }
            _value = a.ToString();
        }

        public MainWindow MainWindow
        {
            get => default(MainWindow);
            set
            {
            }
        }
    }
}
