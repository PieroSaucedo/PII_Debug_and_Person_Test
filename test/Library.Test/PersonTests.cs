using System;
using NUnit.Framework;
using UnitTestAndDebug;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestName() //Test para verificar cuando el nombre es válido
        {
            Person testName = new Person("Piero Saucedo", "5.342.503-5", "12/02/2003");
            string expected = "Piero Saucedo";
            Assert.AreEqual(expected, testName.Name);

        }

        [Test]
        public void TestIDVálido() //Test para verificar el ID
        {
            Person testID = new Person("Piero Saucedo", "5.342.503-5", "12/02/2003");
            string expected = "5.342.503-5";
            Assert.AreEqual(expected, testID.ID);
        }
        [Test]
        public void TestIDInválido() //Test para verificar el ID
        {
            Person testID = new Person("Piero Saucedo", "5.342.503-511", "12/02/2003");
            string expected = null;
            Assert.AreEqual(expected, testID.ID);
        }
        [Test]
        public void TestNacimientoVálido() //Test para verificar cuando la fecha de nacimiento es válida
        {
            Person testID = new Person("Piero Saucedo", "5.342.503-5", "12/02/2003");
            string expected = "12/02/2003";
            Assert.AreEqual(expected, testID.Nacimiento);
        }
        [Test]
        public void TestNacimientoInválido() //Test para verificar cuando la fecha de nacimiento es inválida
        {
            Person testID = new Person("Piero Saucedo", "5.342.503-5", "111112/02/2003");
            string expected = null;
            Assert.AreEqual(expected, testID.Nacimiento);
        }
    }
}