using SCE.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCE.Domain.Entities
{
    public class Estoque : Validable
    {
        public Guid Id { get; private set; }
        public Produto Produto { get; private set; }
        public int EstoqueInicial { get; private set; }
        public int Entrada { get; private set; }
        public int Saida { get; private set; }
        public int Quantidade { get; private set; }


        public Estoque Cadastrar(Produto produto, int estoqueInicial = 0)
        {
            Id = Guid.NewGuid();
            Produto = produto;
            EstoqueInicial = estoqueInicial;
            CalculaQuantidadeTotal();
            return this;
        }

        public Estoque Atualizar(Estoque estoque, string perfil)
        {
            if (perfil != "Admin")
            {
                AddNotification("Perfil", "O usuário não tem permissão para executar essa ação.");

            }

            EstoqueInicial = estoque.EstoqueInicial;
            Entrada = estoque.Entrada;
            CalculaQuantidadeTotal();


            Validate();

            return this;
        }

        public Estoque SaidaEstoque(int saida)
        {
            Saida = saida;
            Quantidade = Quantidade - Saida;

            return this;
        }

        public Estoque EntradaEstoque(int entrada)
        {
            Entrada = entrada;
            Quantidade = Quantidade - Entrada;

            return this;
        }

        public override bool Validate()
        {
            if (NumberValidation.InteiroNaoPodeSerNulo(EstoqueInicial))
                AddNotification("EstoqueInicial", "O estoque inicial não pode ser uma nulo.");

            return (Notifications.Count == 0);

        }

        public void CalculaQuantidadeTotal()
        {
            Quantidade = (EstoqueInicial + Entrada) - Saida;
        }

    }
}
