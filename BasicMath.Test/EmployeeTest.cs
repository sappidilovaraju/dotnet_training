using Moq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;

namespace BasicMath.Test
{
    [TestClass]
    public class EmployeeTest
    {
        private Mock<IDataInterface<Employee>> _mockDataInterface;
        private IDataInterface<Employee> _employeeDataOperation;

        [TestInitialize]
        public void InitializeTest()
        {
            _mockDataInterface = new Mock<IDataInterface<Employee>>();
            _employeeDataOperation = _mockDataInterface.Object;
        }

        [TestMethod]
        public void Test_Employee_GetAll()
        {
            // Arrange
            var employee = new Employee()
            {
                Id = 1,
                Name = "Test"
            };
            _mockDataInterface.Setup(x => x.GetAll()).Returns(new List<Employee>() { employee });

            // Act
            var employees = _employeeDataOperation.GetAll();

            // Assert
            Assert.AreEqual(employees.Count(), 1);
        }

        [TestCleanup]
        public void TestCleanUp()
        {
            if (_mockDataInterface != null)
            {
                _mockDataInterface = null;
            }

            if (_employeeDataOperation != null)
            {
                _employeeDataOperation = null;
            }
        }
    }
}
