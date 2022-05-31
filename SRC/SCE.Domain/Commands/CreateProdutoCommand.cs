using SCE.Domain.Contracts.Commands;
using SCE.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCE.Domain.Commands
{
    /// <summary>
    /// Comando que vai ser persistido no banco, informando o nome do produto e o modelo
    /// </summary>
    public class CreateProdutoCommand : Validable, ICommand
    {
        public CreateProdutoCommand(string nome, string modelo)
        {
            Nome = nome;
            Modelo = modelo;
        }

        public string Nome { get; set; }
        public string Modelo { get; set; }
        public override bool Validate()
        {
            if (StringValidation.NaoPodeSerNulo(Nome))
                AddNotification("Nome", "O nome do produto não pode ser nulo.");

            if (StringValidation.QuantidadeMaximaCaracteres(Nome, 20))
                AddNotification("Nome", "O nome do produto não pode ter mais que 20 caracteres.");

            if (StringValidation.NaoPodeSerNulo(Modelo))
                AddNotification("Modelo", "O modelo do produto não pode ser nulo.");

            if (StringValidation.QuantidadeMaximaCaracteres(Modelo, 20))
                AddNotification("Modelo", "O modelo do produto não pode ter mais que 20 caracteres.");

            return (Notifications.Count == 0);

        }
    }
}
