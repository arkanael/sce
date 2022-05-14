using Microsoft.VisualStudio.TestTools.UnitTesting;
using SCE.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src.Testes.Entities
{
    [TestClass]
    public class ProdutoTest
    {
        [TestCategory("Produto")]
        [TestMethod]
        public void CadastrarProdutoCorretamenteTrue()
        {
            string nomeProduto = "SSD 120GB";
            string modeloProduto = "Samsung";
            bool resultado = false;
            Produto produto = new Produto();

            produto.Cadastrar(nomeProduto, modeloProduto);

            if (produto == null)
            {
                Assert.Fail();
            }

            resultado = string.IsNullOrEmpty(produto.Nome);
            Assert.IsFalse(resultado);

            resultado = string.IsNullOrEmpty(produto.Modelo);
            Assert.IsFalse(resultado);

            Assert.IsTrue(produto.Nome == nomeProduto);
            Assert.IsTrue(produto.Modelo == modeloProduto);
        }

    }
}
