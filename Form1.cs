using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tiipos_e_referências
{
    public partial class Form1 : Form
    {
        Elephant lucinda;
        Elephant lloyd;
        public Form1()
        {
            InitializeComponent();
            lucinda = new Elephant()
            {
                Name = "Lucinda", 
                EarSize = 33
            };
            lloyd = new Elephant()
            {
                Name = "lloyd",
                EarSize = 40
            };
        }

        private void btLloyd_Click(object sender, EventArgs e)
        {
            lloyd.WhoIam();
        }

        private void btLucinda_Click(object sender, EventArgs e)
        {
            lucinda.WhoIam();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lloyd.TellMe("Hi", lucinda);
        }

        private void btSwap_Click(object sender, EventArgs e)
        {
            Elephant holder;
            holder = lloyd;
            lloyd = lucinda;
            lucinda = holder;
            MessageBox.Show("Objetos trocados!");
        }
    }
}
