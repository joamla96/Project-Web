using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Core.Interfaces;
using Service.Tests.TestRepositoreis;
using Service.Controllers;
using Core;

namespace Service.Tests
{
    [TestClass]
    public class LecturePlanControllerUnitTest
    {
        private ILecturePlanRepository testRepo;
        private LecturePlanController userController;

        private LecturePlan DummyOne = new LecturePlan() { ID = 1, Name = "Dummy One" };
        private LecturePlan DummyTwo = new LecturePlan() { ID = 2, Name = "Dummy Two" };
        private LecturePlan DummyThree = new LecturePlan() { ID = 3, Name = "Dummy Three" };
        

        [TestInitialize]
        public void Init()
        {
            testRepo = new TestLecturePlanRepository();
            userController = new LecturePlanController(testRepo);

            testRepo.AddLecturePlan(DummyOne);
            testRepo.AddLecturePlan(DummyTwo);
            testRepo.AddLecturePlan(DummyThree);
        }
    }
}
