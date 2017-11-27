using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Core;
using System.Linq;

namespace Service.Tests
{
	[TestClass]
	public class LecturePlanRepositoryUnitTest
	{
        [TestMethod]
        public void LecturePlanRepositoryIDCounterWorks()
        {
            LecturePlanRepository repo = (LecturePlanRepository)LecturePlanRepository.Instance;
            int ID1 = repo.NextIDTest();
            int ID2 = repo.NextIDTest();
            int ID3 = repo.NextIDTest();

            Assert.AreEqual(ID1, ID2 - 1);
            Assert.AreEqual(ID1, ID3 - 2);
            Assert.AreEqual(ID2, ID1 + 1);
            Assert.AreEqual(ID2, ID3 - 1);
            Assert.AreEqual(ID3, ID1 + 2);
            Assert.AreEqual(ID3, ID2 + 1);
        }

        [TestMethod]
        public void RepositoryInstanceAreTheSame()
        {
            LecturePlan DummyOne = new LecturePlan();
            ILecturePlanRepository Instance1 = LecturePlanRepository.Instance;
            ILecturePlanRepository Instance2 = LecturePlanRepository.Instance;

            Instance1.AddLecturePlan(DummyOne);

            var LecturePlans = Instance2.GetAllLecturePlans();

            Assert.IsTrue(LecturePlans.Contains(DummyOne));
        }

		[TestMethod]
		public void CanAddLecturePlansToRepository()
		{
            LecturePlan DummyOne = new LecturePlan();
            ILecturePlanRepository Instance = LecturePlanRepository.Instance;
            Instance.AddLecturePlan(DummyOne);
            var LecturePlans = Instance.GetAllLecturePlans();
            Assert.IsTrue(LecturePlans.Contains(DummyOne));
        }

        [TestMethod]
        public void CanRemoveLecturePlanFromRepository()
        {
            LecturePlan DummyOne = new LecturePlan();
            ILecturePlanRepository Instance = LecturePlanRepository.Instance;
            Instance.AddLecturePlan(DummyOne);

            Instance.RemoveLecturePlan(DummyOne);
            var LecturePlans = Instance.GetAllLecturePlans();
            Assert.IsFalse(LecturePlans.Contains(DummyOne));
        }

        [TestMethod]
        public void CanGetLecturePlanFromRepositoryByID()
        {
            LecturePlan DummyOne = new LecturePlan();
            LecturePlan DummyTwo;
            ILecturePlanRepository Instance = LecturePlanRepository.Instance;

            int ID = Instance.AddLecturePlan(DummyOne);

            DummyTwo = Instance.GetLecturePlanByID(ID);

            Assert.AreEqual(DummyOne, DummyTwo);
        }

        [TestMethod]
        public void CanDeleteLecturePlanFromRepositoryByID()
        {
            LecturePlan DummyOne = new LecturePlan();
            ILecturePlanRepository Instance = LecturePlanRepository.Instance;

            int ID = Instance.AddLecturePlan(DummyOne);
            Instance.RemoveLecturePlanByID(ID);

            var LecturePlans = Instance.GetAllLecturePlans();

            Assert.IsFalse(LecturePlans.Contains(DummyOne));
        }
    }
}
