using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace kalku
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string _value ="0";
        private string _expresion;
        private bool _point = false;
        public MainWindow()
        {
            InitializeComponent();
            SetValue();
        }
        private void SetValue()
        {
            txtDown.Text = _value;
            txtUp.Text = _expresion;
        }
        private bool ZeroCheck()
        {
            if(_value=="0" || _value=="")
            {
                _value = "";
                return true;
            }
            else
            {
                return false;
            }
        }

        #region NUMBERS
        private void btnOne_Click(object sender, RoutedEventArgs e)
        {
            ZeroCheck();
            _value += "1";
            SetValue();
        }

        private void btnTwo_Click(object sender, RoutedEventArgs e)
        {
            ZeroCheck();
            _value += "2";
            SetValue();
        }

        private void btnThree_Click(object sender, RoutedEventArgs e)
        {
            ZeroCheck();
            _value += "3";
            SetValue();
        }

        private void btnFour_Click(object sender, RoutedEventArgs e)
        {
            ZeroCheck();
            _value += "4";
            SetValue();
        }

        private void btnFive_Click(object sender, RoutedEventArgs e)
        {
            ZeroCheck();
            _value += "5";
            SetValue();
        }

        private void btnSix_Click(object sender, RoutedEventArgs e)
        {
            ZeroCheck();
            _value += "6";
            SetValue();
        }

        private void btnSeven_Click(object sender, RoutedEventArgs e)
        {
            ZeroCheck();
            _value += "7";
            SetValue();
        }

        private void btnEight_Click(object sender, RoutedEventArgs e)
        {
            ZeroCheck();
            _value += "8";
            SetValue();
        }

        private void btnNine_Click(object sender, RoutedEventArgs e)
        {
            ZeroCheck();
            _value += "9";
            SetValue();
        }

        private void btnZero_Click(object sender, RoutedEventArgs e)
        {
            ZeroCheck();
            _value += "0";
            SetValue();
        }

        private void btnPoint_Click(object sender, RoutedEventArgs e)
        {
            if (!_point)
            {
                _value += ".";
                _point = true;
            }
            SetValue();
        }
        #endregion
        #region SINGLE EXPRESIONS
        private void btnPlusMinus_Click(object sender, RoutedEventArgs e)
        {
            if (ZeroCheck())
            {
                _value = "0";
            }
            else
            {
                decimal.TryParse(_value, out decimal a);
                a *= -1;
                _value = a.ToString();
            }
            SetValue();
        }

        private void btnReciprocal_Click(object sender, RoutedEventArgs e)
        {
            if (ZeroCheck())
            {
                _value = "0";
            }
            else
            {
                decimal.TryParse(_value, out decimal a);
                a = 1 / a;
                _value = a.ToString();
            }
            SetValue();
        }

        private void btnSqrt_Click(object sender, RoutedEventArgs e)
        {
            if (ZeroCheck())
            {
                _value = "0";
            }
            else
            {
                double.TryParse(_value, out double a);
                a = Math.Sqrt(a);
                _value = ((decimal)a).ToString();
            }
            SetValue();
        }
        #endregion

        private void btnC_Click(object sender, RoutedEventArgs e)
        {
            _value = "0";
            _point = false;
            SetValue();
        }

        private void btnCE_Click(object sender, RoutedEventArgs e)
        {
            _value = "0";
            _expresion = "";
            _point = false;
            SetValue();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            ZeroCheck();
            if(!ZeroCheck())
            {
                _value = _value.Remove(_value.Count() - 1);
            }
            else
            {
                _value = "0";
            }
            if(_value.Count()==0)
                _value = "0";
            SetValue();
        }
    }
}
