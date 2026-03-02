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

        [TestMethod]
        public void MSMethod()
        {
            var app = FlaUI.Core.Application.Launch(@"C:\Users\User\Desktop\Тесты\Тест\Тест\Приемочное тестирование\CalculatorTests\bin\Debug\Calculator.exe");
            using (var automation = new UIA3Automation())
            {
                //arrange data
                var window = app.GetMainWindow(automation);
                var twoButton = window.FindFirstDescendant(cf => cf.ByName("2"))?.AsButton();
                var msButton = window.FindFirstDescendant(cf => cf.ByName("MS"))?.AsButton();
                var clearButton = window.FindFirstDescendant(cf => cf.ByName("C"))?.AsButton();
                var mrButton = window.FindFirstDescendant(cf => cf.ByName("MR"))?.AsButton();

                //act
                twoButton?.Click();
                msButton?.Click();
                clearButton?.Click();
                mrButton?.Click();

                var resultField = window.FindFirstDescendant(cf => cf.ByClassName("WindowsForms10.EDIT.app.0.141b42a_r7_ad1")).AsTextBox();

                //assert
                Assert.AreEqual("2", resultField?.Text);

                app.Close();
            }
        }

        [TestMethod]
        public void MRMethod()
        {
            var app = FlaUI.Core.Application.Launch(@"C:\Users\User\Desktop\Тесты\Тест\Тест\Приемочное тестирование\CalculatorTests\bin\Debug\Calculator.exe");
            using (var automation = new UIA3Automation())
            {
                //arrange data
                var window = app.GetMainWindow(automation);
                var eightButton = window.FindFirstDescendant(cf => cf.ByName("8"))?.AsButton();
                var msButton = window.FindFirstDescendant(cf => cf.ByName("MS"))?.AsButton();
                var mrButton = window.FindFirstDescendant(cf => cf.ByName("MR"))?.AsButton();
                var clearButton = window.FindFirstDescendant(cf => cf.ByName("C"))?.AsButton();

                //act
                eightButton?.Click();
                msButton?.Click();
                clearButton.Click();
                mrButton?.Click();

                var resultField = window.FindFirstDescendant(cf => cf.ByClassName("WindowsForms10.EDIT.app.0.141b42a_r7_ad1")).AsTextBox();

                //assert
                Assert.AreEqual("8", resultField?.Text);

                app.Close();
            }
        }

        [TestMethod]
        public void MCMethod()
        {
            var app = FlaUI.Core.Application.Launch(@"C:\Users\User\Desktop\Тесты\Тест\Тест\Приемочное тестирование\CalculatorTests\bin\Debug\Calculator.exe");
            using (var automation = new UIA3Automation())
            {
                //arrange data
                var window = app.GetMainWindow(automation);
                var nineButton = window.FindFirstDescendant(cf => cf.ByName("9"))?.AsButton();
                var msButton = window.FindFirstDescendant(cf => cf.ByName("MS"))?.AsButton();
                var mcButton = window.FindFirstDescendant(cf => cf.ByName("MC"))?.AsButton();
                var mrButton = window.FindFirstDescendant(cf => cf.ByName("MR"))?.AsButton();

                //act
                nineButton?.Click();
                msButton?.Click();
                mcButton?.Click();
                mrButton?.Click();

                var resultField = window.FindFirstDescendant(cf => cf.ByClassName("WindowsForms10.EDIT.app.0.141b42a_r7_ad1")).AsTextBox();

                //assert
                Assert.AreEqual("0", resultField?.Text);

                app.Close();
            }
        }

        [TestMethod]
        public void MPlusMethod()
        {
            var app = FlaUI.Core.Application.Launch(@"C:\Users\User\Desktop\Тесты\Тест\Тест\Приемочное тестирование\CalculatorTests\bin\Debug\Calculator.exe");
            using (var automation = new UIA3Automation())
            {
                //arrange data
                var window = app.GetMainWindow(automation);
                var twoButton = window.FindFirstDescendant(cf => cf.ByName("2"))?.AsButton();
                var threeButton = window.FindFirstDescendant(cf => cf.ByName("3"))?.AsButton();
                var msButton = window.FindFirstDescendant(cf => cf.ByName("MS"))?.AsButton();
                var mPlusButton = window.FindFirstDescendant(cf => cf.ByName("M+"))?.AsButton();
                var mrButton = window.FindFirstDescendant(cf => cf.ByName("MR"))?.AsButton();
                var clearButton = window.FindFirstDescendant(cf => cf.ByName("C"))?.AsButton();

                //act
                twoButton?.Click();
                msButton?.Click();
                clearButton.Click();
                threeButton?.Click();
                mPlusButton?.Click();
                mrButton?.Click();

                var resultField = window.FindFirstDescendant(cf => cf.ByClassName("WindowsForms10.EDIT.app.0.141b42a_r7_ad1")).AsTextBox();

                //assert
                Assert.AreEqual("5", resultField?.Text);

                app.Close();
            }
        }

        [TestMethod]
        public void MMinusMethod()
        {
            var app = FlaUI.Core.Application.Launch(@"C:\Users\User\Desktop\Тесты\Тест\Тест\Приемочное тестирование\CalculatorTests\bin\Debug\Calculator.exe");
            using (var automation = new UIA3Automation())
            {
                //arrange data
                var window = app.GetMainWindow(automation);
                var nineButton = window.FindFirstDescendant(cf => cf.ByName("9"))?.AsButton();
                var oneButton = window.FindFirstDescendant(cf => cf.ByName("1"))?.AsButton();
                var msButton = window.FindFirstDescendant(cf => cf.ByName("MS"))?.AsButton();
                var mMinusButton = window.FindFirstDescendant(cf => cf.ByName("M-"))?.AsButton();
                var mrButton = window.FindFirstDescendant(cf => cf.ByName("MR"))?.AsButton();
                var clearButton = window.FindFirstDescendant(cf => cf.ByName("C"))?.AsButton();

                //act
                nineButton?.Click();
                msButton?.Click();
                clearButton.Click();
                oneButton?.Click();
                mMinusButton?.Click();
                mrButton?.Click();

                var resultField = window.FindFirstDescendant(cf => cf.ByClassName("WindowsForms10.EDIT.app.0.141b42a_r7_ad1")).AsTextBox();

                //assert
                Assert.AreEqual("8", resultField?.Text);

                app.Close();
            }
        }

        [TestMethod]
        public void DivideByZeroMethod()
        {
            var app = FlaUI.Core.Application.Launch(@"C:\Users\User\Desktop\Тесты\Тест\Тест\Приемочное тестирование\CalculatorTests\bin\Debug\Calculator.exe");
            using (var automation = new UIA3Automation())
            {
                //arrange data
                var window = app.GetMainWindow(automation);
                var fiveButton = window.FindFirstDescendant(cf => cf.ByName("5"))?.AsButton();
                var zeroButton = window.FindFirstDescendant(cf => cf.ByName("0"))?.AsButton();
                var divideButton = window.FindFirstDescendant(cf => cf.ByName("/"))?.AsButton();
                var resultButton = window.FindFirstDescendant(cf => cf.ByName("="))?.AsButton();

                //act
                fiveButton?.Click();
                divideButton?.Click();
                zeroButton?.Click();
                resultButton?.Click();

                //assert
                var okButton = window.FindFirstDescendant(cf => cf.ByName("ОК")).AsButton();
                Assert.IsNotNull(okButton, "Окно с ошибкой не появилось!");
                okButton?.Click();
                app.Close();
            }
        }

        [TestMethod]
        public void NegativeSqrtMethod()
        {
            var app = FlaUI.Core.Application.Launch(@"C:\Users\User\Desktop\Тесты\Тест\Тест\Приемочное тестирование\CalculatorTests\bin\Debug\Calculator.exe");
            using (var automation = new UIA3Automation())
            {
                //arrange data
                var window = app.GetMainWindow(automation);
                var threeButton = window.FindFirstDescendant(cf => cf.ByName("3"))?.AsButton();
                var btnMinus = window.FindFirstDescendant(cf => cf.ByName("-"))?.AsButton();
                var sixButton = window.FindFirstDescendant(cf => cf.ByName("6"))?.AsButton();
                var resultButton = window.FindFirstDescendant(cf => cf.ByName("="))?.AsButton();
                var sqrtButton = window.FindFirstDescendant(cf => cf.ByName("√"))?.AsButton();

                //act
                threeButton?.Click();
                btnMinus?.Click();
                sixButton?.Click();
                resultButton?.Click();
                sqrtButton?.Click();

                //assert
                var okButton = window.FindFirstDescendant(cf => cf.ByName("ОК")).AsButton();
                Assert.IsNotNull(okButton, "Окно с ошибкой не появилось!");
                okButton?.Click();
                app.Close();

            }
        }

    }
}
