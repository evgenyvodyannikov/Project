using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Urok_11_Vodyannikov_Primeri_1_3
{
    public partial class Zadanie1 : Form
    {
        public Zadanie1()
        {
            InitializeComponent();
        }
        //ggtyhyh
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode >= Keys.A && e.KeyCode <= Keys.Z)
            { label1.Text = "Введена буква"; label1.ForeColor = Color.LimeGreen; }
            else { label1.Text = "Введен символ,\nне являющийся буквой"; label1.ForeColor = Color.DeepPink; }
            if (e.Alt && e.KeyCode == Keys.E)
            { label1.Text = "Нажата комбинация Alt+E"; label1.ForeColor = Color.Blue; }
        }
        //hrhrh
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case 'G':
                    { label1.Text = "Введена бувка G1"; label1.ForeColor = Color.Lime; }
                    break;
                case 'g':
                    { label1.Text = "Введена буква g"; label1.ForeColor = Color.Lime; }
                    break;
                case 'П': //rfhrhrhrhrh
                    { label1.Text = "Введена буква П"; label1.ForeColor = Color.Lime; }
                    break;
                case 'п':
                    { label1.Text = "Введена буква п"; label1.ForeColor = Color.Lime; }
                    break;
                case 'э':
                    { label1.Text = "Введена буква пэ"; label1.ForeColor = Color.Lime; }
                    break;
            }
        }
    }
    ////rehryh5454yhrtht
}
