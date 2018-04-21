using System;
using NUnit.Framework;
using KRDLab1;
using System.Collections.Generic;

namespace UnitTestProjectKRDTests
{
    [TestFixture]
    public class UsersTests
    {
        private IUsers _users;

        [SetUp]
        public void SetUp()
        {
            _users = new Users();
        }

        [Test]
        [TestCase(1, "Mateusz", "Thomas", "Reja", "Math", "Math", UserRole.Administrator)]
        [TestCase(2, "Damian", "Król", "Długa", "login", "TrudneHasło12345!", UserRole.Courier)]
        [TestCase(3, "Wojtek", "Nowak", "Prosta", null, "hasło", UserRole.Client)]
        public void Users_WhenGetGoodData_ShouldConstructCorrectObject(int id, string name, string surname, string street, string login, string password, UserRole role)
        {
            Users users = new Users(new List<User>() { new User(id,name,surname,street,login,password,role) });

            Assert.IsNotNull(users.users);
            Assert.AreEqual(users.users[0].id, id);
            Assert.AreEqual(users.users[0].name, name);
            Assert.AreEqual(users.users[0].surname, surname);
            Assert.AreEqual(users.users[0].street, street);
            Assert.AreEqual(users.users[0].login, login);
            Assert.AreEqual(users.users[0].password, password);
            Assert.AreEqual(users.users[0].role, role);
        }

        [Test]
        public void Users_WhenGetEmtpyList_ShouldThorwException()
        {
            Users users;

            Assert.Throws<ArgumentException>(() => users = new Users(null));
        }

        [Test]
        [TestCase(1, "Mateusz", "Thomas", "Reja", "Math", "Math", UserRole.Administrator)]
        [TestCase(2, "Damian", "Król", "Długa", "login", "TrudneHasło12345!", UserRole.Courier)]
        [TestCase(3, "Wojtek", "Nowak", "Prosta", null, "hasło", UserRole.Client)]
        public void AddSingleUser_WhenGetGoodData_ShouldCorrectAddUserToList(int id, string name, string surname, string street, string login, string password, UserRole role)
        {
            User user = new User(id, name, surname, street, login, password, role);
            
            Assert.DoesNotThrow(() => _users.Add(user));
            Assert.NotNull(_users.users);
            Assert.AreNotEqual(_users.users.IndexOf(user), -1);
        }

        [Test]
        public void AddSingleUser_WhenGetNullObject_ShouldThrowException()
        {
            User user = null;

            Assert.Throws<ArgumentException>(() => _users.Add(user));
        }

        [Test]
        public void AddListUsers_WhenGetNullObject_ShouldThrowException()
        {
            List<User> users = null;

            Assert.Throws<ArgumentException>(() => _users.Add(users));
        }

        [Test]
        public void Remove_WhenGetNullObject_ShouldThrowException()
        {
            User user = null;

            Assert.Throws<ArgumentException>(() => _users.Remove(user));
        }

        [Test]
        public void Remove_WhenGetUserFromOutsideUserList_ShouldThrowException()
        {
            User userFromOutside = new User(20, "Abc", "Abc", "Abc", "Abc", "Abc", UserRole.Client);

            Assert.Throws<ArgumentException>(() => _users.Remove(userFromOutside));
        }

        [Test]
        [TestCase(4, "Bartek", "Thomas", "Reja", "Bar", "Bar", UserRole.Administrator)]
        [TestCase(5, "Szymon", "Kowalski", "Powstańców", "szy", "szy", UserRole.Courier)]
        [TestCase(6, "Kacper", "Kowalski", "Krzywa", "kac", "kac", UserRole.Client)]
        public void Remove_WhenGetCorrectUser_ShouldRemoveUserFromList(int id, string name, string surname, string street, string login, string password, UserRole role)
        {
            User user = new User(id, name, surname, street, login, password, role);

            _users.Add(user);

            Assert.DoesNotThrow(() => _users.Remove(user));
            Assert.AreEqual(_users.users.IndexOf(user), -1);
        }
    }
}
