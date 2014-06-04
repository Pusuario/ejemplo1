using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EjemploPruebas.Model;

namespace PruebasUnitarias
{
    /// <summary>
    /// Summary description for UsuarioTest
    /// </summary>
    [TestClass]
    public class UsuarioTest
    {
        [TestMethod]
        public void ToStringTest()
        {
            Usuario u = new Usuario();

            Assert.AreEqual(u.ToString(), "admin;aaa111...");

        }
        [TestMethod]
        public void UsuarioConstructorTest()
        {
            Usuario u = new Usuario();
            Assert.IsNotNull(u);
            Assert.AreEqual(u.username, "admin");
            Assert.AreEqual(u.password, "aaa111...");
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
    
        public void getMD5Test()
        {
            Usuario u = new Usuario();
            string md = u.getMD5("aaa111...");
            
            Assert.AreEqual(md, "15827d1b83c6be8de449fa4535737d48");

            md = u.getMD5("");
            Assert.IsNull(md);

            md = u.getMD5(null);
            Assert.IsNull(md);
        }
    }
}
