﻿using NUnit.Framework;

namespace DogeNews.Web.Models.Tests
{
    [TestFixture]
    public class UserWebModelTests
    {
        [Test]
        public void Id_ShouldReturnSetValue()
        {
            string id = "1";
            UserWebModel user = new UserWebModel();

            user.Id = id;
            Assert.AreEqual(id, user.Id);
        }

        [Test]
        public void Username_ShouldReturnSetValue()
        {
            string username = "username";
            UserWebModel user = new UserWebModel();

            user.Username = username;
            Assert.AreEqual(username, user.Username);
        }

        [Test]
        public void Firstname_ShouldReturnSetValue()
        {
            string firstname = "firstname";
            UserWebModel user = new UserWebModel();

            user.FirstName = firstname;
            Assert.AreEqual(firstname, user.FirstName);
        }

        [Test]
        public void Lastname_ShouldReturnSetValue()
        {
            string lastname = "lastname";
            UserWebModel user = new UserWebModel();

            user.LastName = lastname;
            Assert.AreEqual(lastname, user.LastName);
        }

        [Test]
        public void Email_ShouldReturnSetValue()
        {
            string email = "email";
            UserWebModel user = new UserWebModel();

            user.Email = email;
            Assert.AreEqual(email, user.Email);
        }        
    }
}
