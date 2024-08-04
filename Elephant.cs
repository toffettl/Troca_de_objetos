using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tiipos_e_referências
{
    internal class Elephant
    {
        public string Name;
        public int EarSize;

        public void WhoIam()
        {
            MessageBox.Show("Minhas orelhas tem " + EarSize + " centimetros de tamanho. Disse " + Name);
        }
        public void TellMe(string message, Elephant whoSaidIt)
        {
            MessageBox.Show(whoSaidIt.Name + " says: " + message);
        }
        public void SpeakTo(Elephant whoToTalkTo, string message)
        {
            whoToTalkTo.TellMe(message, this);
        }
    }
}
