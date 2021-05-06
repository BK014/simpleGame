using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using simpleGame;

namespace simpleGame_UnitTestProject
{
    [TestClass]
    public class simpleGame_UnitTest
    {
        logicClass logic_obj = new logicClass();


        // Test case of spin button based on boundary value analysis
        [TestMethod]
        public void Test_spin_bva1()
            {
                int spin_unit_data = logic_obj.spin();
                Assert.AreNotEqual(0, spin_unit_data);
            }


            [TestMethod]
            public void Test_spin_bva2()
            {
                int spin_unit_data = logic_obj.spin();
                Assert.AreNotEqual(7, spin_unit_data);
            }


        //Test case of shoot button based on boundary value analysis

        [TestMethod]
            public void Test_shoot_bva1()
            {
                int shoot_unit_data = logic_obj.shoot();
                Assert.AreNotEqual(7, shoot_unit_data);
            }


            [TestMethod]
            public void Test_shoot_bva2()
            {
                int shoot_unit_data = logic_obj.shoot();
                Assert.AreNotEqual(0, shoot_unit_data);
            }
        }
    }
