using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.Linq;

namespace BasicMath_V2.Test
{
    [TestClass]
    public class EmployeeDbOperationTest
    {
        private Mock<IDbOperation<Employee>> _dbOperation;
        private IDbOperation<Employee> _employeeOperation;


        [TestInitialize]
        public void TestInitialize()
        {
            _dbOperation = new Mock<IDbOperation<Employee>>();
            _employeeOperation = _dbOperation.Object;
        }

        [TestMethod]
        public void Test_Employee_GetAll_1()
        {
            // Arrange
            var employees = new List<Employee>()
            {
                new Employee() { Id = 1, Name = "Test 1"},
                new Employee() { Id = 2, Name = "Test 2"}
            };
            _dbOperation.Setup(x => x.GetAll()).Returns(employees);

            // Act
            var actualEmployees = _employeeOperation.GetAll();

            // Assert
            Assert.AreEqual(employees.Count, actualEmployees.Count());
        }

        [TestCleanup]
        public void TestCleanup()
        {
            if(_employeeOperation != null )
            {
                _employeeOperation = null;
            }

            if (_dbOperation.Object != null)
            {
                _dbOperation = null;
            }
        }
    }
}
