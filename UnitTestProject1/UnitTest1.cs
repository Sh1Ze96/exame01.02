using ClassLibrary2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class PasswordTest
    {
        [TestMethod]
        public void CheckPassword()
        {
            string password = "qwerty1234Q#";
            string expected = "хорошо";

            string actual = Password.checkPassword(password);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckPassword1()
        {
            string password = "Dis23$23";
            string expected = "хорошо";

            string actual = Password.checkPassword(password);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckPassword2()
        {
            string password = "Alex200#1";
            string expected = "хорошо";

            string actual = Password.checkPassword(password);
            Assert.AreEqual(expected, actual);
        }
    }
}
