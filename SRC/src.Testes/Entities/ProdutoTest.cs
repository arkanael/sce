using Microsoft.VisualStudio.TestTools.UnitTesting;
using SCE.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCE.Testes.Entities
{
    [TestCategory("Produto")]
    [TestClass]
    public class ProdutoTest
    {
        [TestMethod("Ao cadastrar um produto corretamente retornar True")]
        public void CadastrarProdutoCorretamenteTrue()
        {
            string nomeProduto = "SSD 120GB";
            string modeloProduto = "Samsung";

            Produto produto = new Produto().Cadastrar(nomeProduto, modeloProduto);

            if (produto == null)
            {
                Assert.Fail();
            }

            Assert.IsTrue(produto.Validate());
        }

        [TestMethod("Ao cadastrar um produto com mais de 20 Caracteres deve retornar False")]
        public void CadastrarProdutoComMaisde20CaracteresFalse()
        {
            string nomeProduto = "HD SSD de 512 GIGAS da Marca Samsung";
            string modeloProduto = "SSD";

            Produto produto = new Produto().Cadastrar(nomeProduto, modeloProduto);

            if (produto == null)
            {
                Assert.Fail();
            }

            Assert.IsTrue(produto.Notifications.Count > 0);

            Assert.IsFalse(produto.Validate());
        }

        [TestMethod("Ao atualizar um produto corretamente retornar True")]
        public void AtualizarProdutoCorretamenteTrue()
        {
            string nomeProduto = "HD SSD de 512 GB";
            string modeloProduto = "SSD";

            string novoNomeProduto = "HD SSD de 240GB";
            string novoModeloProduto = "HD SSD";

            Produto produto = new Produto();

            produto.Cadastrar(nomeProduto, modeloProduto);

            if (produto == null)
            {
                Assert.Fail();
            }

            Assert.IsTrue(produto.Notifications.Count == 0);

            Assert.IsTrue(produto.Validate());


            produto.Atualizar(produto.Id.Value, novoNomeProduto, novoModeloProduto);

            Assert.IsTrue(produto.Validate());
            Assert.AreNotEqual(produto.Nome, nomeProduto);
            Assert.AreNotEqual(produto.Modelo, modeloProduto);
        }
    }
}
