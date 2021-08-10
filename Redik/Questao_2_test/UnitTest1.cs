using Exercicio_2;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Questao_2_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestarReducaoConcatenacao1()
        {
            string s = "blablablabla";
            string t = "blablabcde";
            int k = 8;
            Desafio2 des = new Desafio2();
            bool resultado = des.ConcatERemove(s,t,k);
            Assert.IsTrue(resultado);

        }
        [TestMethod]
        public void TestarReducaoConcatenacao2()
        {
            string s = "aba";
            string t = "aba";
            int k = 7;
            Desafio2 des = new Desafio2();
            bool resultado = des.ConcatERemove(s, t, k);
            Assert.IsTrue(resultado);

        }
        [TestMethod]
        public void TestarReducaoConcatenacao3()
        {
            string s = "ashley";
            string t = "ash";
            int k = 2;
            Desafio2 des = new Desafio2();
            bool resultado = des.ConcatERemove(s, t, k);
            Assert.IsFalse(resultado);

        }
    }
}
