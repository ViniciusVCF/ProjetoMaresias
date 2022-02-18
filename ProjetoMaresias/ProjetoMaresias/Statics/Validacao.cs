using System.Windows.Forms;

namespace ProjetoMaresias.Statics
{
    public static class Validacao
    {
        public static bool DadosVazios(ErrorProvider errorProvider, Control painel)
        {
            bool vazio = false;
            errorProvider.Clear();
            foreach (Control control in painel.Controls)
                if (control is TextBox)
                {
                    TextBox textBox = control as TextBox;
                    if (string.IsNullOrWhiteSpace(textBox.Text) && textBox.Enabled)
                    {
                        errorProvider.SetError(textBox, "Preenchimento obrigatório!");
                        vazio = true;
                    }
                }
                else if (control is MaskedTextBox)
                {
                    MaskedTextBox maskedTextBox = control as MaskedTextBox;
                    if (string.IsNullOrWhiteSpace(maskedTextBox.Text) && maskedTextBox.Enabled)
                    {
                        errorProvider.SetError(maskedTextBox, "Preenchimento obrigatório!");
                        vazio = true;
                    }
                }
                else if (control is ComboBox)
                {
                    ComboBox comboBox = control as ComboBox;
                    if (string.IsNullOrWhiteSpace(comboBox.Text) && comboBox.Enabled)
                    {
                        errorProvider.SetError(comboBox, "Preenchimento obrigatório!");
                        vazio = true;
                    }
                }
            return vazio;
        }
        public static bool DadosInvalidos(ErrorProvider errorProvider, Control painel)
        {
            foreach (Control control in painel.Controls)
                if (control is TextBox)
                {
                    TextBox textBox = control as TextBox;
                    if (errorProvider.GetError(textBox) != "" && textBox.Enabled)
                    {
                        return true;
                    }
                }
                else if (control is MaskedTextBox)
                {
                    MaskedTextBox maskedTextBox = control as MaskedTextBox;
                    if (errorProvider.GetError(maskedTextBox) != "" && maskedTextBox.Enabled)
                    {
                        return true;
                    }
                }
                else if (control is DateTimePicker)
                {
                    DateTimePicker dateTimePicker = control as DateTimePicker;
                    if (errorProvider.GetError(dateTimePicker) != "" && dateTimePicker.Enabled)
                    {
                        return true;
                    }
                }
            return false;
        }
        public static bool ValidaCPF(string cpf)
        {
            int[] verificaDigito1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] verificaDigito2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string cpf1, cpf2;
            int soma = 0, resultado = 0;

            if (cpf.Length != 11)
            {
                return false;
            }
            cpf1 = cpf.Substring(0, 10);

            for (int i = 0; i < 9; i++)
            {
                soma += int.Parse(cpf[i].ToString()) * verificaDigito1[i];
            }
            resultado = soma % 11;

            if (resultado < 2)
            {
                resultado = 0;
            }
            else
            {
                resultado = 11 - resultado;
            }
            cpf2 = resultado.ToString();
            cpf1 += cpf2;

            soma = 0;
            for (int i = 0; i < 10; i++)
            {
                soma += int.Parse(cpf[i].ToString()) * verificaDigito2[i];
            }
            resultado = soma % 11;
            if (resultado < 2)
            {
                resultado = 0;
            }
            else
            {
                resultado = 11 - resultado;
            }
            cpf2 += resultado.ToString();

            return cpf.EndsWith(cpf2);
        }
        public static bool ValidaEmail(string email)
        {
            if (email.Contains("@") && email.Contains(".com"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
