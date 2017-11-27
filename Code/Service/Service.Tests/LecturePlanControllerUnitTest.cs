using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Service.Tests.TestRepositoreis;
using Service.Controllers;
using Core;

namespace Service.Tests
{
    [TestClass]
    public class LecturePlanControllerUnitTest
    {
        private ILecturePlanRepository testRepo;
        private LecturePlanController Controller;

        private LecturePlan DummyOne = new LecturePlan() { ID = 1, Name = "Dummy One" };
        private LecturePlan DummyTwo = new LecturePlan() { ID = 2, Name = "Dummy Two" };
        private LecturePlan DummyThree = new LecturePlan() { ID = 3, Name = "Dummy Three" };
        

        [TestInitialize]
        public void Init()
        {
            testRepo = new TestLecturePlanRepository();
            Controller = new LecturePlanController(testRepo);

            testRepo.AddLecturePlan(DummyOne);
            testRepo.AddLecturePlan(DummyTwo);
            testRepo.AddLecturePlan(DummyThree);
        }

        [TestMethod]
        public void LecturePlanControllerGetAllPlans()
        {
            var List = Controller.Get();

            Assert.IsTrue(List.Contains(DummyOne));
            Assert.IsTrue(List.Contains(DummyTwo));
            Assert.IsTrue(List.Contains(DummyThree));
        }

        [TestMethod]
        public void LecturePlanControllerGetSpecificLecturePlan()
        {
            var Item = Controller.Get(1);
            Assert.AreEqual(DummyOne, Item);
        }

        [TestMethod]
        public void LecturePlanControllerAddPlan()
        {
            LecturePlan Item = new LecturePlan() { ID = 4, Name = "Dummy Four" };
            Controller.Post(Item);

            var List = testRepo.GetAllLecturePlans();
            Assert.IsTrue(List.Contains(Item));
        }
    }
}
