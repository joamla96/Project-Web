using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Core;
using Core.Interfaces;

namespace Service.Tests
{
    /// <summary>
    /// Summary description for UserRepositoryUnitTests
    /// </summary>
    [TestClass]
    public class UserRepositoryUnitTests
    {

        [TestMethod]
        public void UserRepositoryInstanceAreTheSame()
        {
            User DummyOne = new User();
            IUserRepository Instance1 = UserRepository.Instance;
            IUserRepository Instance2 = UserRepository.Instance;

            Instance1.AddUser(DummyOne);

            var List = Instance2.GetAllUsers();

            Assert.IsTrue(List.Contains(DummyOne));
        }

        [TestMethod]
        public void CanAddUsersToRepository()
        {
            User DummyOne = new User();
            IUserRepository Instance = UserRepository.Instance;
            Instance.AddUser(DummyOne);
            var Users = Instance.GetAllUsers();
            Assert.IsTrue(Users.Contains(DummyOne));
        }

        [TestMethod]
        public void CanRemoveUserFromRepository()
        {
            User DummyOne = new User();
            IUserRepository Instance = UserRepository.Instance;
            Instance.AddUser(DummyOne);

            Instance.RemoveUser(DummyOne);
            var Users = Instance.GetAllUsers();
            Assert.IsFalse(Users.Contains(DummyOne));
        }

        [TestMethod]
        public void CanGetUserFromRepositoryByUsername()
        {
            User DummyOne = new User() { Username = "TestUser-1237yuhbjn" };
            User DummyTwo;
            IUserRepository Instance = UserRepository.Instance;

            Instance.AddUser(DummyOne);
            DummyTwo = Instance.GetUserByUsername("TestUser-1237yuhbjn");

            Assert.AreEqual(DummyOne, DummyTwo);
        }

    }
}
