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

        /// <summary>
        /// TODO
        /// </summary>
        [Test]
        public void FindAccount_NullData()
        {
            int id;

            id = service.FindAccount(null, null);

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
            //CreatClientEntry details
            string name = "test";
            string surname = "test";
            string phoneNumber = "test";
            string email = "test";
            string birthDate = "1980.01.01";

            ServiceReference1.ArrayOfString details = new ServiceReference1.ArrayOfString();
            details.Add(username);
            details.Add(password);
            details.Add(name);
            details.Add(surname);
            details.Add(phoneNumber);
            details.Add(email);
            details.Add(birthDate);

            bool result;

            result = service.CreateAccount(details);

            Assert.That(result, Is.True);

        }

        [Test]
        public void CreateAccount_Identical_Information()
        {
            //username and password for account
            string username = "user1";
            string password = "user1";
            //CreatClientEntry details
            string name = "Name1";
            string surname = "Surname1";
            string phoneNumber = "0762383844";
            string email = "name1_sur1@gmail.com";
            string birthDate = "1989-01-01";

            ServiceReference1.ArrayOfString details = new ServiceReference1.ArrayOfString();
            details.Add(username);
            details.Add(password);
            details.Add(name);
            details.Add(surname);
            details.Add(phoneNumber);
            details.Add(email);
            details.Add(birthDate);

            bool result;

            result = service.CreateAccount(details);

            Assert.That(result, Is.False);
        }

        [Test]
        public void CreateAccount_Wrong_Info()
        {
            string username = "1";
            string password = "2";
            //CreatClientEntry details
            string name = "test";
            string surname = "test";
            string phoneNumber = "test";
            string email = "test";
            string birthDate = "1989";  //Incomplete data entry

            ServiceReference1.ArrayOfString details = new ServiceReference1.ArrayOfString();
            details.Add(username);
            details.Add(password);
            details.Add(name);
            details.Add(surname);
            details.Add(phoneNumber);
            details.Add(email);
            details.Add(birthDate);

            bool result;

            result = service.CreateAccount(details);

            Assert.That(result, Is.False);
        }
    }
}
