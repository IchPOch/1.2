using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практика
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            int x, y, ch;
            if (Chis.Text == "") Max.Text = "Неккоректно введено число";
            else {
                ch = Convert.ToInt32(Chis.Text);
                if (ch < 100 || ch > 999)
                    Max.Text = "Неккоректно введено число";
                else
                {
                    x = ch / 100;
                    y = ch % 10;
                    if (x == y)
                        Max.Text = "Числа равны";
                    else
                    {
                        if (x > y)
                            Max.Text = "Первое больше";
                        else
                            Max.Text = "Последнее больше";

                    }
                }
            }
        }

    }
}
