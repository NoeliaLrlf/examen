using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        /**
        * Get "class data value" and validate it
        * **Do not modify this unit test**
        */

        [TestMethod]
        public void test_1()
        {
            var expected = 100;
            var actual = Account.MinimumBalance;

            Assert.AreEqual(expected, actual);
        }

        /**
        * Getting "class data value" and validate it
        * **Do not modify this unit test**
        */

        [TestMethod]
        public void test_2()
        {
            new Account("ABC-01");
            new Account("ABC-02");
            new Account("ABC-03");

            var actual = Account.Ids;

            string expected = "ABC-01,ABC-02,ABC-03";
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(3, Account.Count);
        }

        /**
        * Get "instance data value" and validate it
        * **Do not modify this unit test**
        */

        [TestMethod]
        public void test_3()
        {
            var expected = "Juan Perez";
            var actual = new Person("Juan Perez").Name;

            Assert.IsTrue(expected == actual);
            Assert.IsTrue(expected.Equals(actual));
        }

        ///**
        //* Work with Equals method
        //* **Do not modify this unit test**
        //*/
        [TestMethod]
        public void test_4()
        {
            var person1 = new Person("Juan Perez", "12345 CB", 25, new Address("Av. Melchor Perez", 256));
            var person2 = new Person("Juan Perez", "12345 CB", 25, new Address("Av. Melchor Perez", 256));

            Assert.IsTrue(person1.Equals(person2));
        }

        ///**
        //* Work with == operator
        //* **Do not modify this unit test**
        //*/
        [TestMethod]
        public void test_5()
        {
            var person1 = new Person("Juan Perez", "12345 CB", 25, new Address("Av. Melchor Perez", 256));
            var person2 = new Person("Juan Perez", "12345 CB", 25, new Address("Av. Melchor Perez", 256));

            Assert.IsTrue(person1 == person2);
        }

        ///**
        //* Work with HashCode
        //* **Do not modify this unit test**
        //*/
        [TestMethod]
        public void test_6()
        {
            var person1 = new Person("Juan Perez", "12345 CB", 25, new Address("Av. Melchor Perez", 256));
            var person2 = new Person("Juan Perez", "12345 CB", 25, new Address("Av. Melchor Perez", 256));

            Assert.IsTrue(person1.GetHashCode() == person2.GetHashCode());
        }

        ///**
        //* Work with "class method" and inheritance
        //* **Do not modify this unit test**
        //*/
        [TestMethod]
        public void test_7()
        {
            ClassA baseClassInstance = new ClassA();
            ClassB derivedClassInstance = new ClassB();

            var actual1 = ClassB.IsDerivedClass(baseClassInstance);
            var actual2 = ClassB.IsDerivedClass(derivedClassInstance);
            var actual3 = ClassB.IsBaseClass(baseClassInstance);
            var actual4 = ClassB.IsClassABaseClassOfClassB();

            Assert.IsFalse(actual1);
            Assert.IsTrue(actual2);
            Assert.IsTrue(actual3);
            Assert.IsTrue(actual4);
        }

        ///**
        //* Work with inheritance
        //* **Do not modify this unit test**
        //*/
        [TestMethod]
        public void test_8()
        {
            ClassA instance1 = new ClassA();
            ClassA instance2 = new ClassB();

            Assert.IsFalse(instance1 is ClassB);
            Assert.IsTrue(instance2 is ClassB);
            Assert.IsTrue(instance1 is ClassA);
            Assert.IsTrue(instance2 is ClassA);
        }

        ///**
        //* Work with inheritance and abstract class and polymorphism
        //* **Do not modify this unit test**
        //*/
        [TestMethod]
        public void test_9()
        {
            AbstractGeometricFigure rectangle = new Rectangle(2, 3);// base 2, height 3
            AbstractGeometricFigure circle = new Circle(3);// radius 3

            double actualAreaRectangle = rectangle.GetArea();
            double actualAreaCircle = circle.GetArea();

            Assert.AreEqual(6, actualAreaRectangle, 0.1);
            Assert.AreEqual(28.27, actualAreaCircle, 0.1);
        }

        ///**
        //* Work with interfaces
        //* **Do not modify this unit test**
        //*/
        [TestMethod]
        public void test_10()
        {
            var quiz = new Quiz();
            IQuiz1 q1 = quiz;
            IQuiz2 q2 = quiz;
            IQuiz3 q3 = quiz;

            bool actual1 = q1.IsIQuiz1();
            bool actual2 = q2.IsIQuiz2();
            bool actual3 = q3.IsIQuiz3();

            Assert.IsTrue(actual1);
            Assert.IsTrue(actual2);
            Assert.IsTrue(actual3);
        }

        ///**
        //* Create unit test to verify the message of a Custom exception
        //*/
        [TestMethod]
        public void test_12()
        {
            var result = 0;
            int x = 10;
            int y = 0;
            var actual = string.Empty;
            string expected = "Division 0 is invalid";
            try
            {
                if (y == 0)
                    throw new InvalidDivision("Division 0 is invalid");
                result = x / y;
            }
            catch (InvalidDivision ex)
            {
                actual = ex.Message;
            }

            Assert.AreEqual(expected, actual);
        }

        ///**
        //* Create unit test to verify the type of an exception (do not use try/catch block)
        //*/
        [TestMethod]
        public void test_13()
        {
            int[] arr = new[] { 1, 2, 3 };
            Assert.ThrowsException<IndexOutOfRangeException>(() => arr[10]);
        }
    }
}