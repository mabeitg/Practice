using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice
{
    public partial class Stapel : UserControl
    {
        public int Max { get; set; }

        public Stapel()
        {
            Max = 81;
            InitializeComponent();
        }

        public Stapel(int max)
        {
            InitializeComponent();
            Max = max;
        }

        public void Nollställ()
        {
            panel1.Height = 200;
        }
        public void Minska()
        {
            panel1.Height -= Height / Max;
//            panel1.Top += Height / Max;
        }

        public void Öka()
        {
            panel1.Height += Height / Max;
//            panel1.Top -= Height / Max;
        }

    }
}
