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

        /// <summary>
        /// Método para atualizar o estoque cadastrado.
        /// </summary>
        /// <param name="estoque">Passar o estoque</param>
        /// <param name="perfil">Passar o perfil</param>
        /// <returns></returns>
        public Estoque AtualizarEstoqueInicial(int estoqueInicial, string perfil)
        {
            if (perfil != "Admin")
            {
                AddNotification("Perfil", "O usuário não tem permissão para executar essa ação.");
            }

            if (Entrada != 0 || Saida != 0)
            {
                AddNotification("EstoqueInicial", "Não é permitido atualizar o estoque inicial. Já foi dado entrada ou saida.");
            }

            EstoqueInicial = estoqueInicial;
            CalculaQuantidadeTotal();

            Validate();
            return this;
        }

        public Estoque SaidaEstoque(int saida)
        {
            Saida = saida;
            Quantidade = Quantidade - Saida;

            if (Quantidade < 0)
            {
                AddNotification("SaidaEstoque", "Não é permitido estoque negativo.");
            }

            Validate();
            return this;
        }

        public Estoque EntradaEstoque(int entrada)
        {
            Entrada =+ entrada;
            Quantidade = Quantidade + Entrada;

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
