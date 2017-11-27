using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Core.Interfaces;
using Service.Tests.TestRepositoreis;
using Service.Controllers;
using Core;
using System.Linq;

namespace Service.Tests
{
    /// <summary>
    /// Summary description for UserControllerUnitTest
    /// </summary>
    [TestClass]
    public class UserControllerUnitTest
    {
        private IUserRepository testRepo;
        private UserController userController;

        private User DummyOne = new User() { Name = "Dummy One", Username = "D1" };
        private User DummyTwo = new User() { Name = "Dummy Two", Username = "D2" };
        private User DummyThree = new User() { Name = "Dummy Three", Username = "D3" };

        [TestInitialize]
        public void Init()
        {
            testRepo = new TestUserRepository();
            userController = new UserController(testRepo);

            testRepo.AddUser(DummyOne);
            testRepo.AddUser(DummyTwo);
            testRepo.AddUser(DummyThree);
        }

        [TestMethod]
        public void UserControllerGetAllUsers()
        {
            var List = userController.Get();

            Assert.IsTrue(List.Contains(DummyOne));
            Assert.IsTrue(List.Contains(DummyTwo));
            Assert.IsTrue(List.Contains(DummyThree));
        }

        [TestMethod]
        public void UserControllerGetUserByUsername()
        {
            var User = userController.Get("D1");
            Assert.AreEqual(DummyOne, User);
        }


        [TestMethod]
        public void UserControllerGetUserByUsername2()
        {
            var User = userController.Get("D2");
            Assert.AreEqual(DummyTwo, User);
        }


        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void UserControllerGetUserByUsernameFail()
        {
            var User = userController.Get("D4");
        }

        [TestMethod]
        public void UserControllerInsertUserIntoRepository()
        {
            User DummyFour = new User() { Name = "Dummy Four", Username = "D4" };
            userController.Post(DummyFour);

            var ExpectD4 = testRepo.GetUserByUsername("D4");

            Assert.AreEqual(DummyFour, ExpectD4);
        }

        [TestMethod]
        public void UserControllerDeleteUserFromRepository()
        {
            userController.Delete(DummyOne);
            var List = testRepo.GetAllUsers();

            Assert.IsFalse(List.Contains(DummyOne));
        }
    }
}
