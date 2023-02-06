using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Work
{
    internal class Tel
    {
        public int days;
        public double time;
        private double price=5;
        public void prices(double tim)
        {
            if (days == 6 || days == 7)
                price = tim * (price * 0.9);
            else price = tim * price;
        }
        public bool Day(double days)
        {
            if (days < 0 || days > 7)
                return false;
            else return true;
        }
        public double money()
        {
            return price;
        }
    }
}
