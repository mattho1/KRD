using KRDLab1;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProjectKRDTests
{
    [TestFixture]
    public class PackagesTests
    {
        private IPackages _packages;

        [SetUp]
        public void SetUp()
        {
            _packages = new Packages();
        }

        [Test]
        [TestCase(1, PakageStatus.Delivered, 2018, 4, 21, 12, 0, 0, 1, "Mateusz", "Thomas", "Reja", "mat", "mat",
            UserRole.Client)]
        [TestCase(2, PakageStatus.InSystem, 2018, 4, 22, 12, 10, 0, 2, "Kamil", "Nowakowski", "Solna", "kam", "kam",
            UserRole.Administrator)]
        [TestCase(3, PakageStatus.InWarehouse, 2018, 4, 22, 12, 20, 0, 3, "Adam", "Nowak", "Długa", "ad", "ad",
            UserRole.Courier)]
        [TestCase(4, PakageStatus.OnTheWay, 2018, 4, 22, 12, 30, 0, 4, "Jan", "Kowalski", "Prosta", "ja", "ja",
            UserRole.Client)]
        public void Packages_WhenGetGoodData_ShouldConstructCorrectObject(int number, PakageStatus status, int year,
            int month, int day, int hour, int minute, int second, int id, string name, string surname, string street,
            string login, string password, UserRole role)
        {
            User owner = new User(id, name, surname, street, login, password, role);
            DateTime time = new DateTime(year, month, day, hour, minute, second);
            Packages packages = new Packages(new List<Package>() {new Package(number, status, time, owner)});

            Assert.IsNotNull(packages.packages);
            Assert.AreEqual(packages.packages[0].number, number);
            Assert.AreEqual(packages.packages[0].hour, time);
            Assert.AreEqual(packages.packages[0].owner, owner);
            Assert.AreEqual(packages.packages[0].status, status);
        }

        [Test]
        public void Packages_WhenGetEmtpyList_ShouldThorwException()
        {
            Assert.Throws<ArgumentException>(() => new Packages(null));
        }

        [Test]
        [TestCase(1, PakageStatus.Delivered, 2018, 4, 21, 12, 0, 0, 1, "Mateusz", "Thomas", "Reja", "mat", "mat",
            UserRole.Client)]
        [TestCase(2, PakageStatus.InSystem, 2018, 4, 22, 12, 10, 0, 2, "Kamil", "Nowakowski", "Solna", "kam", "kam",
            UserRole.Administrator)]
        [TestCase(3, PakageStatus.InWarehouse, 2018, 4, 22, 12, 20, 0, 3, "Adam", "Nowak", "Długa", "ad", "ad",
            UserRole.Courier)]
        [TestCase(4, PakageStatus.OnTheWay, 2018, 4, 22, 12, 30, 0, 4, "Jan", "Kowalski", "Prosta", "ja", "ja",
            UserRole.Client)]
        public void AddSinglePackage_WhenGetGoodData_ShouldCorrectAddPackageToList(int number, PakageStatus status,
            int year, int month, int day, int hour, int minute, int second, int id, string name, string surname,
            string street, string login, string password, UserRole role)
        {
            User owner = new User(id, name, surname, street, login, password, role);
            DateTime time = new DateTime(year, month, day, hour, minute, second);
            Package package = new Package(number, status, time, owner);

            Assert.DoesNotThrow(() => _packages.Add(package));
            Assert.NotNull(_packages.packages);
            Assert.AreNotEqual(_packages.packages.IndexOf(package), -1);
        }

        [Test]
        public void AddSinglePackage_WhenGetNullObject_ShouldThrowException()
        {
            Package package = null;

            Assert.Throws<ArgumentException>(() => _packages.Add(package));
        }

        [Test]
        public void AddListPackages_WhenGetNullObject_ShouldThrowException()
        {
            List<Package> packages = null;

            Assert.Throws<ArgumentException>(() => _packages.Add(packages));
        }

        [Test]
        public void Remove_WhenGetNullObject_ShouldThrowException()
        {
            Package package = null;

            Assert.Throws<ArgumentException>(() => _packages.Remove(package));
        }

        [Test]
        public void Remove_WhenGetPackageFromOutsidePackageList_ShouldThrowException()
        {
            Package packageFromOutside = new Package(20, PakageStatus.InSystem, new DateTime(2018, 4, 21, 12, 0, 0),
                new User(20, "Abc", "Abc", "Abc", "Abc", "Abc", UserRole.Client));

            Assert.Throws<ArgumentException>(() => _packages.Remove(packageFromOutside));
        }

        [Test]
        [TestCase(1, PakageStatus.Delivered, 2018, 4, 21, 12, 0, 0, 1, "Mateusz", "Thomas", "Reja", "mat", "mat",
            UserRole.Client)]
        [TestCase(2, PakageStatus.InSystem, 2018, 4, 22, 12, 10, 0, 2, "Kamil", "Nowakowski", "Solna", "kam", "kam",
            UserRole.Administrator)]
        [TestCase(3, PakageStatus.InWarehouse, 2018, 4, 22, 12, 20, 0, 3, "Adam", "Nowak", "Długa", "ad", "ad",
            UserRole.Courier)]
        [TestCase(4, PakageStatus.OnTheWay, 2018, 4, 22, 12, 30, 0, 4, "Jan", "Kowalski", "Prosta", "ja", "ja",
            UserRole.Client)]
        public void Remove_WhenGetCorrectPackage_ShouldRemovePackageFromList(int number, PakageStatus status, int year,
            int month, int day, int hour, int minute, int second, int id, string name, string surname, string street,
            string login, string password, UserRole role)
        {
            User owner = new User(id, name, surname, street, login, password, role);
            DateTime time = new DateTime(year, month, day, hour, minute, second);
            Package package = new Package(number, status, time, owner);

            _packages.Add(package);

            Assert.DoesNotThrow(() => _packages.Remove(package));
            Assert.AreEqual(_packages.packages.IndexOf(package), -1);
        }
    }
}
