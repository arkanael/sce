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

            Produto produto = new Produto();

            produto.Cadastrar(nomeProduto, modeloProduto);

            if (produto == null)
            {
                Assert.Fail();
            }

            Assert.IsTrue(produto.Validate());
        }

    }
}
