using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Work
{
    internal class One
    {
        public double abc = 0;
        public double one()
        {   for (int i=1; i<=10;i++)
            {
                abc = Math.Pow(i, 2);
                if (abc <=25)
                MessageBox.Show(Convert.ToString(abc), "Цикл", MessageBoxButtons.OK);
            }
            return abc;
        }
        
    }
}
