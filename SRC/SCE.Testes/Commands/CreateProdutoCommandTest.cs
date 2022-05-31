using Microsoft.VisualStudio.TestTools.UnitTesting;
using SCE.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCE.Testes.Commands
{
    [TestCategory("CreateProdutoCommand")]
    [TestClass]
    public class CreateProdutoCommandTest
    {
        [TestMethod("Ao cadastrar um produto corretamente retornar True")]
        public void CadastrarProdutoCorretamenteTrue()
        {
            string nomeProduto = "SSD 120GB";
            string modeloProduto = "Samsung";

            CreateProdutoCommand command = new CreateProdutoCommand(nomeProduto, modeloProduto);

            if (command == null)
            {
                Assert.Fail();
            }

            Assert.IsTrue(command.Validate());
        }

        [TestMethod("Ao cadastrar um produto com mais de 20 Caracteres deve retornar False")]
        public void CadastrarProdutoComMaisde20CaracteresFalse()
        {
            string nomeProduto = "HD SSD de 512 GIGAS da Marca Samsung";
            string modeloProduto = "SSD";

            CreateProdutoCommand command = new CreateProdutoCommand(nomeProduto, modeloProduto);

            if (command == null)
            {
                Assert.Fail();
            }

            Assert.IsFalse(command.Validate());
        }
    }
}
