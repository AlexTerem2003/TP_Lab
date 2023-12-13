using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_NUnit
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1_MathOperations()
        {
            Logic logic = new();
            Assert.AreEqual(99583, logic.MathOperations("+", 1238, 98345));
            Assert.AreEqual(778464, logic.MathOperations("-", 875921, 97457));
            Assert.AreEqual(601966, logic.MathOperations("*", 982, 613));
            Assert.AreEqual(873, logic.MathOperations("/", 6984, 8));
        }

        [Test]
        public void Test2_NumberOfDayOfWeek()
        {
            Logic logic = new();
            Assert.AreEqual(1, logic.NumberOfDayOfWeek("Понедельник"));
            Assert.AreEqual(2, logic.NumberOfDayOfWeek("Вторник"));
            Assert.AreEqual(3, logic.NumberOfDayOfWeek("Среда"));
            Assert.AreEqual(4, logic.NumberOfDayOfWeek("Четверг"));
            Assert.AreEqual(5, logic.NumberOfDayOfWeek("Пятница"));
            Assert.AreEqual(6, logic.NumberOfDayOfWeek("Суббота"));
            Assert.AreEqual(7, logic.NumberOfDayOfWeek("Воскресенье"));
        }

        [Test]
        public void Test3_CalculatePerimeter()
        {
            Logic logic = new();
            Assert.AreEqual(72, logic.CalculatePerimeter(new List<int> { 10, 20, 42 }));
            Assert.AreEqual(124, logic.CalculatePerimeter(new List<int> { 30, 32, 13, 49 }));
            Assert.AreEqual(200, logic.CalculatePerimeter(new List<int> { 85, 40, 10, 20, 45 }));
        }

        [Test]
        public void Test4_SizeOfSumToString()
        {
            Logic logic = new();
            Assert.AreEqual(6, logic.SizeOfSumToString(12387, 283498));
            Assert.AreEqual(4, logic.SizeOfSumToString(232, 1234));
            Assert.AreEqual(7, logic.SizeOfSumToString(512389, 678498));
        }

        [Test]
        public void Test5_Greetings()
        {
            Logic logic = new();
            Assert.AreEqual("Москва в 8-й раз встречает Вас, Алексей!", logic.Greetings("Алексей", "Москва", 8));
            Assert.AreEqual("Владимир в 13232-й раз встречает Вас, Алексей!", logic.Greetings("Алексей", "Владимир", 13232));
            Assert.AreEqual("Санкт-Петербург в 5-й раз встречает Вас, Алексей!", logic.Greetings("Алексей", "Санкт-Петербург", 5));
        }

        [Test]
        public void Test6_IsThereEnoughPizza()
        {
            Logic logic = new();
            Assert.IsTrue(logic.IsThereEnoughPizza(24, 15));
            Assert.IsTrue(logic.IsThereEnoughPizza(10, 8));
            Assert.IsTrue(logic.IsThereEnoughPizza(6, 3));
            Assert.IsFalse(logic.IsThereEnoughPizza(5, 2));
            Assert.IsFalse(logic.IsThereEnoughPizza(100, 1));
        }

        [Test]
        public void Test7_FootAndShoesSizeAcceptability()
        {
            Logic logic = new();
            Assert.AreEqual("Не лезет, собака!", logic.FootAndShoesSizeAcceptability(32, 30));
            Assert.AreEqual("Неплохо. Со вторыми носками пойдёт!", logic.FootAndShoesSizeAcceptability(42, 44));
            Assert.AreEqual("Ух.. Впритык...", logic.FootAndShoesSizeAcceptability(40, 40));
            Assert.AreEqual("Сойдёт!", logic.FootAndShoesSizeAcceptability(41, 42));
            Assert.AreEqual("На вырост сойдёт! Остаётся только превратиться в великана (-_ -)", logic.FootAndShoesSizeAcceptability(40, 45));
        }
    }
}
