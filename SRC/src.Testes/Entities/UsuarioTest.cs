using Microsoft.VisualStudio.TestTools.UnitTesting;
using SCE.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCE.Testes.Entities
{
    [TestCategory("Usuario")]
    [TestClass]
    public class UsuarioTest
    {
        [TestMethod("Ao cadastrar um usuário corretamente retornar True")]
        public void CadastrarUsuarioCorretamenteTrue()
        {
            string nomeUsuario = "Luiz G. Bandeira";
            string loginUsuario = "luiz.guilherme@gmail.com";
            string senhaUsuario = "1234";

            Usuario usuario = new Usuario().Cadastrar(nomeUsuario, loginUsuario, senhaUsuario);

            if (usuario == null)
            {
                Assert.Fail();
            }

            Assert.IsTrue(usuario.Validate());
        }
    }
}
