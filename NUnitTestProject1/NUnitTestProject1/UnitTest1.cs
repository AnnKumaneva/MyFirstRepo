using NUnit.Framework;
using System;
using System.Text;
using System.Collections.Generic;

namespace NUnitTestProject1
{
    public class Tests
    {


        //Calculator.Methods m = new Calculator.Methods();
        //m.addition(x, y);
        //m.difference(x, y);
        //m.division(x, y);
        //m.multiplication(x, y);


        [Test, TestCaseSource("arg")]
        public void TestAdd(int x, int y)
        {
           var add = Calculator.Calculator.calculator(x, y, "+");
            Assert.AreEqual((x + y), add);
        }


        [Test, TestCaseSource("arg")]
        public void TestDif(int x, int y)
        {
            var dif = Calculator.Calculator.calculator(x, y, "-");
            Assert.AreEqual((x - y), dif);
        }

        [Test, TestCaseSource("arg")]
        public void TestDiv(int x, int y)
        {
            var div = Calculator.Calculator.calculator(x, y, "/");
            Assert.AreEqual((x/y), div);
        }

        
        [Test, TestCaseSource("arg")]
        public void TestMult(int x, int y)
        {
            var mult = Calculator.Calculator.calculator(x, y, "*");
            Assert.AreEqual((x * y), mult);
        }
        static object[] arg =
        {
            new object[] { 0, 1},
            new object[] { 1, 1},
            new object[] { 2, 1},
            new object[] { 3, 1},
            new object[] { 4, 1},
            new object[] { 5, 1},
            new object[] { 6, 1},
            new object[] { 7, 1},
            new object[] { 8, 1},
            new object[] { 9, 1},
            new object[] { 10, 1},
            new object[] { 0, 0},
            new object[] { 1, 0},
            new object[] { 1, 2},
            new object[] { 1, 3},
            new object[] { 1, 4},
            new object[] { 1, 5},
            new object[] { 1, 6},
            new object[] { 1, 7},
            new object[] { 1, 8},
            new object[] { 1, 9},
            new object[] { 1, 10}
            

        };



    }
}