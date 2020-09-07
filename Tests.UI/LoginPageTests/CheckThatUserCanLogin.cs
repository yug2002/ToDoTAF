using NUnit.Framework;

namespace Tests.UI.LoginPageTests
{
    public class CheckThatUserCanLogin : BaseUITest
    {
        [SetUp]
        public void Init()
        {
            HomePage.Open();
        }

        [Test]
        public void CheckLogin()
        {
            HomePage.ButtonByName("Get started").Click();
        }
    }
}
