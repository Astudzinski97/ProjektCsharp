using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektCplotek
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Wyjscie(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NowaGra(object sender, EventArgs e)
        {
            Gierka nowa;
            nowa = new Gierka();
            nowa.Show();
        }

        private void ins(object sender, EventArgs e)
        {
            Instrukcja instr;
            instr = new Instrukcja();
            instr.Show();
        }
    }
}
