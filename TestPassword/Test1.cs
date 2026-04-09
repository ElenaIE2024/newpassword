using PasswordLibrary;
namespace TestPassword
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PasswordNOKLength()
        {
            Password psw = new Password("7fa");
            Assert.IsFalse(psw.CheckPassword());
        }
        [TestMethod]
        public void PasswordOKNumberNotFirst()
        {
            Password psw = new Password("ffii5iiiiii");
            Assert.IsTrue(psw.CheckPassword());
        }
        [TestMethod]
        public void PasswordOKNumberFirst()
        {
            Password psw = new Password("7ffiiiiiiii");
            Assert.IsTrue(psw.CheckPassword());
        }
    }
}
