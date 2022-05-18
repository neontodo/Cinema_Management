//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ServiceTest
{
    [TestFixture]
    public class UnitAuthenticationTest
    {
        ServiceReference1.WebAuthenticationSoapClient service = new ServiceReference1.WebAuthenticationSoapClient();

        //Tests with focus on FindAccounnt possible cases
        [Test]
        public void FindAccount_WasFound()
        {
            int id;
            string username = "admin";
            string password = "admin";

            id = service.FindAccount(username, password);

            Assert.AreEqual(id, 1);
        }

        [Test]
        public void FindAccount_WasNotFound()
        {
            int id;
            string username = "maricica";
            string password = "parola";

            id = service.FindAccount(username, password);

            Assert.AreEqual(id, -1);
        }


        //tests with focus on isEmployee possible cases
        [Test]
        public void isEmployee_Positive()
        {
            int id = 1; //admin
            bool result;

            result = service.IsEmployee(id);

            Assert.IsTrue(result);
        }

        [Test]
        public void isEmployee_Negative()
        {
            int id = 48;  //normal account
            bool result;

            result = service.IsEmployee(id);

            Assert.That(result, Is.False);
        }

        //tests with focus on isClient possible cases
        [Test]
        public void isClient_Positive()
        {
            int id = 48; //normal account
            bool result;

            result = service.IsClient(id);

            Assert.That(result, Is.True);
        }

        [Test]
        public void isClient_Negative()
        {
            int id = 1; //admin
            bool result;

            result = service.IsClient(id);

            Assert.That(result, Is.False);
        }

        [Test]
        public void CreateAccount_Succesful()
        {
            //username and password for account
            string username = "test";
            string password = "test";
            List<string> details = new List<string>();
            details.Add(username);
            details.Add(password);

            bool result;

            result = service.CreateAccount(details);

            Assert.That(result, Is.True);

        }
    }
}
