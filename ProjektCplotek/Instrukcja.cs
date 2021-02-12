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
    public partial class Instrukcja : Form
    {
        public Instrukcja()
        {
            InitializeComponent();
        }

        private void zamknij(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
