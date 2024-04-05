using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PR;

namespace UTProj
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(Program.GetMark("5", "10","15")); //PositiveTest1 - Проверка с валидными данными
            Assert.IsTrue(Program.GetMark("1", "2", "4")); //PositiveTest2 - Проверка с валидными данными
            Assert.IsTrue(Program.GetMark("22", "38", "20")); //PositiveTest3 - Проверка с валидными данными
            Assert.IsTrue(Program.GetMark("0", "0", "0")); //PositiveTest4 - Проверка с валидными данными

            Assert.IsFalse(Program.GetMark("", "", "")); //NegativeTest1 - Проверка с пустыми полями
            Assert.IsFalse(Program.GetMark(" ", " ", " ")); //NegativeTest2 - Проверка с пробелами
            Assert.IsFalse(Program.GetMark("qwe", "rty", "uio")); //NegativeTest3 - Проверка с текстом в полях
            Assert.IsFalse(Program.GetMark("-5", "100", "80")); //NegativeTest4 - Проверка с int, не позволяемыми тех. требованиями
        }
    }
}
