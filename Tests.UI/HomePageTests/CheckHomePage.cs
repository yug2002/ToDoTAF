using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests.UI.HomePageTests
{
    [TestFixture]
    public class CheckHomePage : BaseUITest
    {
        [SetUp]
        public void Init()
        {
           HomePage.Open();
        }

        [Test]
        public void CheckThatHomePageIsOpened()
        {
            
        }
    }
}
