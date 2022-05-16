using Microsoft.VisualStudio.TestTools.UnitTesting;
using SCE.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src.Testes.Entities
{
    [TestCategory("Estoque")]
    [TestClass]
    public class EstoqueTest
    {
        [TestMethod("Ao cadastrar um estoque corretamente retornar True")]
        public void CadastrarEstoqueCorretamenteTrue()
        {
            //Cadastrando novo produto
            Produto produto = new Produto().Cadastrar("SSD 120GB", "Samsung");
            
            //Validando o produto cadastrado
            Assert.IsTrue(produto.Validate());

            //Cadastrando o novo estoque passadno o produto e a quantidade de estoque inicial
            Estoque estoque = new Estoque().Cadastrar(produto, 10);
            
            Assert.IsTrue(estoque.Validate());
        }


        [TestMethod("Ao Atulizar um estoque corretamente retornar True")]
        public void AtualizarEstoqueCorretamenteTrue()
        {
            //Cadastrando novo produto
            Produto produto = new Produto().Cadastrar("SSD 120GB", "Samsung");

            //Validando o produto cadastrado
            Assert.IsTrue(produto.Validate());

            //Cadastrando o novo estoque passadno o produto e a quantidade de estoque inicial
            Estoque estoque = new Estoque().Cadastrar(produto, 10);
            Assert.IsTrue(estoque.Validate());
            Assert.AreEqual(estoque.Quantidade, 10);
            estoque.AtualizarEstoqueInicial(5, "Admin");
            Assert.IsTrue(estoque.Validate());
            Assert.AreEqual(estoque.Quantidade, 5);
                
        }

        [TestMethod("Ao dar saida do estoque corretamente deve retornar True")]
        public void CalcularSaidaEstoqueCorretamenteTrue()
        {
            //Cadastrando novo produto
            Produto produto = new Produto().Cadastrar("SSD 120GB", "Samsung");

            //Validando o produto cadastrado
            Assert.IsTrue(produto.Validate());

            //Cadastrando o novo estoque passadno o produto e a quantidade de estoque inicial
            Estoque estoque = new Estoque().Cadastrar(produto, 10);

            Assert.IsTrue(estoque.Validate());

            //Saida do estoque
            estoque.SaidaEstoque(1);

            //Validando o estoque após a saida
            Assert.IsTrue(estoque.Validate());

            //Validação com o valor esperado
            Assert.AreEqual(estoque.Quantidade, 9);

        }

        [TestMethod("Ao dar entrada no estoque corretamente deve retornar True")]
        public void CalcularEntradaEstoqueCorretamenteTrue()
        {
            //Cadastrando novo produto
            Produto produto = new Produto().Cadastrar("SSD 120GB", "Samsung");

            //Validando o produto cadastrado
            Assert.IsTrue(produto.Validate());

            //Cadastrando o novo estoque passadno o produto e a quantidade de estoque inicial
            Estoque estoque = new Estoque().Cadastrar(produto, 10);

            Assert.IsTrue(estoque.Validate());

            //Saida do estoque
            estoque.EntradaEstoque(1);

            //Validando o estoque após a saida
            Assert.IsTrue(estoque.Validate());

            //Validação com o valor esperado
            Assert.AreEqual(estoque.Quantidade, 11);

        }
    }
}
