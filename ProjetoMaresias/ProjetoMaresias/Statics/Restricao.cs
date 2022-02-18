using System.Media;
using System.Windows.Forms;

namespace ProjetoMaresias.Statics
{
    public static class Restricao
    {
        public static void BotaoEspaco(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.SuppressKeyPress = true;
                SystemSounds.Beep.Play();
            }
        }
        public static void SomenteNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

    }
}
