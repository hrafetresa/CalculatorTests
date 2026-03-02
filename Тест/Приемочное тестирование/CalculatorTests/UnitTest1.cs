using FlaUI.Core.AutomationElements;
using FlaUI.UIA3;
using FlaUI.UIA3.Patterns;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace CalculatorTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SumMethod()
        {

            var app = FlaUI.Core.Application.Launch(@"C:\Users\User\Desktop\Тесты\Тест\Тест\Приемочное тестирование\CalculatorTests\bin\Debug\Calculator.exe");
            using (var automation = new UIA3Automation())
            {
                //arrange data
                var window = app.GetMainWindow(automation);
                var plusButton = window.FindFirstDescendant(cf => cf.ByName("+"))?.AsButton();
                var fiveButton = window.FindFirstDescendant(cf => cf.ByName("5"))?.AsButton();
                var twoButton = window.FindFirstDescendant(cf => cf.ByName("2"))?.AsButton();
                var resultButton = window.FindFirstDescendant(cf => cf.ByName("="))?.AsButton();

                //act
                twoButton?.Click();
                plusButton?.Click();
                fiveButton?.Click();
                resultButton?.Click();

                var resultField = window.FindFirstDescendant(cf => cf.ByClassName("WindowsForms10.EDIT.app.0.141b42a_r7_ad1")).AsTextBox();

                //assert
                Assert.AreEqual("7", resultField?.Text);

                app.Close();
            }
        }

        [TestMethod]
        public void MultiplicationMethod()
        {
            var app = FlaUI.Core.Application.Launch(@"C:\Users\User\Desktop\Тесты\Тест\Тест\Приемочное тестирование\CalculatorTests\bin\Debug\Calculator.exe");
            using (var automation = new UIA3Automation())
            {
                //arrange data
                var window = app.GetMainWindow(automation);
                var multiplyButton = window.FindFirstDescendant(cf => cf.ByName("*"))?.AsButton();
                var fiveButton = window.FindFirstDescendant(cf => cf.ByName("5"))?.AsButton();
                var nineButton = window.FindFirstDescendant(cf => cf.ByName("9"))?.AsButton();
                var resultButton = window.FindFirstDescendant(cf => cf.ByName("="))?.AsButton();

                //act
                nineButton?.Click();
                multiplyButton?.Click();
                fiveButton?.Click();
                resultButton?.Click();

                var resultField = window.FindFirstDescendant(cf => cf.ByClassName("WindowsForms10.EDIT.app.0.141b42a_r7_ad1")).AsTextBox();

                //assert
                Assert.AreEqual("45", resultField?.Text);

                app.Close();
            }
        }

        [TestMethod]
        public void MinusMethod()
        {
            var app = FlaUI.Core.Application.Launch(@"C:\Users\User\Desktop\Тесты\Тест\Тест\Приемочное тестирование\CalculatorTests\bin\Debug\Calculator.exe");
            using (var automation = new UIA3Automation())
            {
                //arrange data
                var window = app.GetMainWindow(automation);
                var minusButton = window.FindFirstDescendant(cf => cf.ByName("-"))?.AsButton();
                var sixButton = window.FindFirstDescendant(cf => cf.ByName("6"))?.AsButton();
                var nineButton = window.FindFirstDescendant(cf => cf.ByName("9"))?.AsButton();
                var resultButton = window.FindFirstDescendant(cf => cf.ByName("="))?.AsButton();

                //act
                nineButton?.Click();
                minusButton?.Click();
                sixButton?.Click();
                resultButton?.Click();

                var resultField = window.FindFirstDescendant(cf => cf.ByClassName("WindowsForms10.EDIT.app.0.141b42a_r7_ad1")).AsTextBox();

                //assert
                Assert.AreEqual("3", resultField?.Text);

                app.Close();
            }
        }

        [TestMethod]
        public void DivideMethod()
        {
            var app = FlaUI.Core.Application.Launch(@"C:\Users\User\Desktop\Тесты\Тест\Тест\Приемочное тестирование\CalculatorTests\bin\Debug\Calculator.exe");
            using (var automation = new UIA3Automation())
            {
                //arrange data
                var window = app.GetMainWindow(automation);
                var divideButton = window.FindFirstDescendant(cf => cf.ByName("/"))?.AsButton();
                var threeButton = window.FindFirstDescendant(cf => cf.ByName("3"))?.AsButton();
                var nineButton = window.FindFirstDescendant(cf => cf.ByName("9"))?.AsButton();
                var resultButton = window.FindFirstDescendant(cf => cf.ByName("="))?.AsButton();

                //act
                nineButton?.Click();
                divideButton?.Click();
                threeButton?.Click();
                resultButton?.Click();

                var resultField = window.FindFirstDescendant(cf => cf.ByClassName("WindowsForms10.EDIT.app.0.141b42a_r7_ad1")).AsTextBox();

                //assert
                Assert.AreEqual("3", resultField?.Text);

                app.Close();
            }
        }

        [TestMethod]
        public void PowMethod()
        {
            var app = FlaUI.Core.Application.Launch(@"C:\Users\User\Desktop\Тесты\Тест\Тест\Приемочное тестирование\CalculatorTests\bin\Debug\Calculator.exe");
            using (var automation = new UIA3Automation())
            {
                //arrange data
                var window = app.GetMainWindow(automation);
                var powButton = window.FindFirstDescendant(cf => cf.ByName("x^y"))?.AsButton();
                var threeButton = window.FindFirstDescendant(cf => cf.ByName("3"))?.AsButton();
                var fourButton = window.FindFirstDescendant(cf => cf.ByName("4"))?.AsButton();
                var resultButton = window.FindFirstDescendant(cf => cf.ByName("="))?.AsButton();

                //act
                threeButton?.Click();
                powButton?.Click();
                fourButton?.Click();
                resultButton?.Click();

                var resultField = window.FindFirstDescendant(cf => cf.ByClassName("WindowsForms10.EDIT.app.0.141b42a_r7_ad1")).AsTextBox();

                //assert
                Assert.AreEqual("81", resultField?.Text);

                app.Close();
            }
        }

        [TestMethod]
        public void SqrtMethod()
        {
            var app = FlaUI.Core.Application.Launch(@"C:\Users\User\Desktop\Тесты\Тест\Тест\Приемочное тестирование\CalculatorTests\bin\Debug\Calculator.exe");
            using (var automation = new UIA3Automation())
            {
                //arrange data
                var window = app.GetMainWindow(automation);
                var rootButton = window.FindFirstDescendant(cf => cf.ByName("√"))?.AsButton();
                var twoButton = window.FindFirstDescendant(cf => cf.ByName("2"))?.AsButton();
                var fiveButton = window.FindFirstDescendant(cf => cf.ByName("5"))?.AsButton();
                var resultButton = window.FindFirstDescendant(cf => cf.ByName("="))?.AsButton();

                //act
                twoButton?.Click();
                fiveButton?.Click();
                rootButton?.Click();
                resultButton?.Click();

                var resultField = window.FindFirstDescendant(cf => cf.ByClassName("WindowsForms10.EDIT.app.0.141b42a_r7_ad1")).AsTextBox();

                //assert
                Assert.AreEqual("5", resultField?.Text);

                app.Close();
            }
        }

        [TestMethod]
        public void PercentMethod()
        {
            var app = FlaUI.Core.Application.Launch(@"C:\Users\User\Desktop\Тесты\Тест\Тест\Приемочное тестирование\CalculatorTests\bin\Debug\Calculator.exe");
            using (var automation = new UIA3Automation())
            {
                //arrange data
                var window = app.GetMainWindow(automation);
                var rootButton = window.FindFirstDescendant(cf => cf.ByName("√"))?.AsButton();
                var twoButton = window.FindFirstDescendant(cf => cf.ByName("2"))?.AsButton();
                var fiveButton = window.FindFirstDescendant(cf => cf.ByName("5"))?.AsButton();
                var resultButton = window.FindFirstDescendant(cf => cf.ByName("="))?.AsButton();

                //act
                twoButton?.Click();
                fiveButton?.Click();
                rootButton?.Click();
                resultButton?.Click();

                var resultField = window.FindFirstDescendant(cf => cf.ByClassName("WindowsForms10.EDIT.app.0.141b42a_r7_ad1")).AsTextBox();

                //assert
                Assert.AreEqual("5", resultField?.Text);

                app.Close();
            }
        }
    }
}
