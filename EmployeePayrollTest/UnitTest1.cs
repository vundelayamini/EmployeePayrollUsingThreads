using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace EmployeePayrollTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Given10Employee_WhenAddedToList_ShouldMatchEmployeeEntries()
        {
            List<EmployeeDetails> employeeDetails = new List<EmployeeDetails>
            {
                new EmployeeDetails(EmployeeID: 1, EmployeeName: "Bruce", PhoneNumber: "9999999999", Address: "xyz", Department: "HR", Gender: 'M', City: "abc", BasicPay: 100, TaxablePay: 2, Tax: 3, Country: "India"),
                new EmployeeDetails(EmployeeID: 2, EmployeeName: "Banner", PhoneNumber: "9999999999", Address: "xyz", Department: "HR", Gender: 'M', City: "abc", BasicPay: 100, TaxablePay: 2, Tax: 3, Country: "India"),
                new EmployeeDetails(EmployeeID: 3, EmployeeName: "clark", PhoneNumber: "9999999999", Address: "xyz", Department: "HR", Gender: 'M', City: "abc", BasicPay: 100, TaxablePay: 2, Tax: 3, Country: "India"),
                new EmployeeDetails(EmployeeID: 4, EmployeeName: "Mike", PhoneNumber: "9999999999", Address: "xyz", Department: "HR", Gender: 'M', City: "abc", BasicPay: 100, TaxablePay: 2, Tax: 3, Country: "India"),
                new EmployeeDetails(EmployeeID: 5, EmployeeName: "Jason", PhoneNumber: "9999999999", Address: "xyz", Department: "HR", Gender: 'M', City: "abc", BasicPay: 100, TaxablePay: 2, Tax: 3, Country: "India"),
                new EmployeeDetails(EmployeeID: 6, EmployeeName: "Patrick", PhoneNumber: "9999999999", Address: "xyz", Department: "HR", Gender: 'M', City: "abc", BasicPay: 100, TaxablePay: 2, Tax: 3, Country: "India"),
                new EmployeeDetails(EmployeeID: 7, EmployeeName: "Maria", PhoneNumber: "9999999999", Address: "xyz", Department: "HR", Gender: 'M', City: "abc", BasicPay: 100, TaxablePay: 2, Tax: 3, Country: "India"),
                new EmployeeDetails(EmployeeID: 8, EmployeeName: "Steve", PhoneNumber: "9999999999", Address: "xyz", Department: "HR", Gender: 'M', City: "abc", BasicPay: 100, TaxablePay: 2, Tax: 3, Country: "India")
            };

            EmployeePayrollOperations employeePayrollOperations = new EmployeePayrollOperations();//object of employeepayrolloperations
            DateTime startDateTime = DateTime.Now;
            employeePayrollOperations.addEmployeeToPayroll(employeeDetails);
            DateTime stopDateTime = DateTime.Now;
            Console.WriteLine("Duration without thread: " + (stopDateTime - startDateTime));

            DateTime startDateTimeThread = DateTime.Now;
            employeePayrollOperations.addEmployeeToPayrollWithThread(employeeDetails);
            DateTime stopDateTimeThread = DateTime.Now;
            Console.WriteLine("Duration with thread: " + (stopDateTimeThread - startDateTimeThread));

        }


    }
}
