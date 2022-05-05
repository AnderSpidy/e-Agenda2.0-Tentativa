using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoTarefas.WinApp
{
    [Serializable]

    public class Contato : EntidadeBase
    {
        private string nome;
        public string email;
        public string telefone;
        public string empresa;
        public string cargo;
        public bool compromisso;

        public string Nome { get => nome; set => nome = value; }

        public override string ToString()
        {
            return $"Nome: {nome} | Email: {email} | Telefone: {telefone} | Empresa:{empresa} | Cargo:{cargo}";
        }
        public string Validar()
        {
            StringBuilder sb = new StringBuilder();

            if (string.IsNullOrEmpty(Nome))
                sb.AppendLine("O nome do contato é obrigatório!");

            if (EmailEstaValido(ValidarEmail) == false)
                sb.AppendLine("Insira um endereço de email válido! (Ex: contato@gmail.com)");

            if (TelefoneEstaValido() == false)
                sb.AppendLine("O número precisa seguir um dos seguintes formatos: 99999-0000 ou 99999 0000 ou 999990000");

            if (string.IsNullOrEmpty(empresa))
                sb.AppendLine("O nome da empresa é obrigatório!");

            if (string.IsNullOrEmpty(cargo))
                sb.AppendLine("O nome do cargo é obrigatório!");

            if (sb.Length == 0)
                sb.Append("REGISTRO_VALIDO");

            return sb.ToString();
        }
        private bool EmailEstaValido(Func<bool> validacaoSelecionada)
        {
            bool emailEstaValido = validacaoSelecionada();

            return emailEstaValido;
        }
        private bool TelefoneEstaValido()
        {
            bool telefoneEstaValido = false;

            // utilizando o método Replace() para remover caracteres especiais da string
            string telefoneProcessado = telefone.Replace("-", string.Empty)
                                                .Replace(" ", string.Empty);

            if (telefoneProcessado.Length < 9)
                return telefoneEstaValido;

            telefoneEstaValido = System.Text.RegularExpressions.Regex.IsMatch(telefoneProcessado, @"^[0-9]*$");

            return telefoneEstaValido;
        }
        private bool ValidarEmail()
        {
            // podemos utilizar o valor discard (representado pelo _ (underscore))
            // para descartar argumento out do método
            //bool emailEstaValido = System.Net.Mail.MailAddress.TryCreate(email, out _);

            //return emailEstaValido;

            //bool emailEstaValido = System.Text.RegularExpressions.Regex.IsMatch(email, @"^[^@\s] +@[^@\s] +\.[^@\s]+$", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            
                try
                {
                    var addr = new System.Net.Mail.MailAddress(email);
                    return addr.Address == email;
                }
                catch
                {
                    return false;
                }
            
            //return emailEstaValido;
        }

    }
}
