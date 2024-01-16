using tdd_todo_list.CSharp.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    public class ExtensionTests
    {
        /*
        private TodoListExtension Extension;

        [SetUp]
        public void SetUp()
        {
            Extension = new TodoListExtension();
        }
        */

        //THIS ONE THAT WE LOOKED AT
        [Test, Order(1)]
        [TestCase(1, "Achieving CHIM")]
        [TestCase(2, "Banana eating contest")]
        [TestCase(3, "Calculate all float values of pi")]
        [TestCase(4, "Destroy the universe")]
        public void getTaskByIDTest(int id, string name)
        {
            //Arrange
            TodoListExtension Extension = new TodoListExtension();
            Extension.Add(name);

            //Act
            ToDoTask returnedTask = Extension.getTaskByID(id);

            //Assert
            Assert.That(returnedTask.TaskID, Is.EqualTo(id));

        }




















        [Test, Order(2)]
        [TestCase(666)]
        public void getTaskByIDTestFail(int id)
        {
            //Arrange
            TodoListExtension Extension = new TodoListExtension();
            Extension.Add("Banana eating contest");
            Extension.Add("Achieving CHIM");
            Extension.Add("Destroy the universe");
            Extension.Add("Calculate all float values of pi");

            //Act
            ToDoTask returnedTask = Extension.getTaskByID(id);

            //Assert
            Assert.That(returnedTask.TaskName, Is.EqualTo("not found"));
        }

        [Test, Order(3)]
        [TestCase(3, "Eat a lot of pizza")]
        public void updateNameTest(int id, string name)
        {
            //Arrange
            TodoListExtension Extension = new TodoListExtension();
            Extension.Add("Banana eating contest");
            Extension.Add("Achieving CHIM");
            Extension.Add("Destroy the universe");
            Extension.Add("Calculate all float values of pi");

            //Act
            string result = Extension.updateName(id, name);

            //Assert
            Assert.That(result, Is.EqualTo("Eat a lot of pizza"));
        }

        [Test, Order(4)]
        public void setStatusByIDTest(int id, bool isCompleted)
        {

            //Arrange
            TodoListExtension Extension = new TodoListExtension();
            Extension.Add("Banana eating contest");
            Extension.Add("Achieving CHIM");
            Extension.Add("Destroy the universe");
            Extension.Add("Calculate all float values of pi");
            //Act
            Extension.setStatusByID(id, isCompleted);

            //Assert
            Assert.Fail();
        }

        [Test, Order(5)]
        public void setStatusByIDTestFail(int id, bool isCompleted)
        {

            //Arrange
            TodoListExtension Extension = new TodoListExtension();
            Extension.Add("Banana eating contest");
            Extension.Add("Achieving CHIM");
            Extension.Add("Destroy the universe");
            Extension.Add("Calculate all float values of pi");
            //Act
            Extension.setStatusByID(id, isCompleted);

            //Assert
            Assert.Fail();
        }

        [Test, Order(6)]
        public void getCreationTimeTest(int id)
        {

            //Arrange
            TodoListExtension Extension = new TodoListExtension();
            Extension.Add("Banana eating contest");
            Extension.Add("Achieving CHIM");
            Extension.Add("Destroy the universe");
            Extension.Add("Calculate all float values of pi");
            //Act
            Extension.getCreationTime(id);

            //Assert
            Assert.Fail();
        }
    }
}