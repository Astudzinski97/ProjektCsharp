using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektCplotek
{
    public partial class ZapiszWynik : Form
    {
        int wynik;
        public ZapiszWynik(int wynik)
        {
            InitializeComponent();
            this.wynik = wynik;
        }

        private void zapisz(object sender, EventArgs e)
        {
            StreamWriter streamWriter1;
            bool b = false;
            streamWriter1 = File.AppendText("Wyniki.txt");
            if (!b)
            { streamWriter1.WriteLine("Nazwa Gracza ; Data ; Wynik"); };
            string textToFile = this.textBox1.Text + " ; " + (System.DateTime.Today).ToString() + " ; " + this.wynik;
            streamWriter1.WriteLine(textToFile);
            streamWriter1.Close();
            this.Close();
        }
    }
}
