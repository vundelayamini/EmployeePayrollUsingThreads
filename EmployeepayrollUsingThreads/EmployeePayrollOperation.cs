using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EmployeepayrollUsingThreads
{
    class EmployeePayrollOperation
    {
        public List<EmployeeDetails> employeePayrollDetailsList = new List<EmployeeDetails>();
        /// <summary>
        /// Adding Employee details  
        /// </summary>
        /// <param name="employeePayrollDetailsList"></param>
        public void addEmployeeToPayroll(List<EmployeeDetails> employeePayrollDetailsList)
        {
            employeePayrollDetailsList.ForEach(employeeData =>
            {
                Console.WriteLine("Employee being added:" + employeeData.EmployeeName);
                this.addEmployeeToPayroll(employeeData);
                Console.WriteLine("Employee Added : " + employeeData.EmployeeName);
            });
            Console.WriteLine(this.employeePayrollDetailsList.ToString());
        }

        public void addEmployeeToPayroll(EmployeeDetails emp)
        {
            employeePayrollDetailsList.Add(emp);
        }
        /// <summary>
        ///Using thread 
        /// </summary>
        /// <param name="employeePayrollDetailsList"></param>
        public void addEmployeeToPayrollWithThread(List<EmployeeDetails> employeePayrollDetailsList)

        {
            employeePayrollDetailsList.ForEach(employeeData =>
            {
                //Console.WriteLine("abc");
                Task thread = new Task(() =>
                {
                    Console.WriteLine("employee being added: " + employeeData.EmployeeName);
                    this.addEmployeeToPayroll(employeeData);
                    Console.WriteLine("Employee added:" + employeeData.EmployeeName);
                });
                thread.Start();
            });
            Console.WriteLine(this.employeePayrollDetailsList.Count);
        }
    }
}

