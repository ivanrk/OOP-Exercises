namespace CompanyRoster
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var N = int.Parse(Console.ReadLine());
            var employees = new List<Employee>();
            var departmentSalaries = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < N; i++)
            {
                var employeeInfo = Console.ReadLine().Split(' ');
                var name = employeeInfo[0];
                var salary = decimal.Parse(employeeInfo[1]);
                var position = employeeInfo[2];
                var department = employeeInfo[3];

                var employee = new Employee(name, salary, position, department);
                CheckIfInputContainsEmailAndAge(employeeInfo, employee);
                employees.Add(employee);

                if (!departmentSalaries.ContainsKey(department))
                {
                    departmentSalaries[department] = new List<decimal>();
                }
                departmentSalaries[department].Add(salary);
            }

            departmentSalaries = departmentSalaries
                                    .OrderByDescending(d => d.Value.Sum() / d.Value.Count)
                                    .ToDictionary(d => d.Key, d => d.Value);

            var highestSalaryDep = departmentSalaries.First().Key;

            employees = employees
                            .Where(e => e.Department == highestSalaryDep)
                            .OrderByDescending(e => e.Salary)
                            .ToList();

            Console.WriteLine($"Highest Average Salary: {highestSalaryDep}");
            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.Name} {emp.Salary:f2} {emp.Email} {emp.Age}");
            }              
        }

        private static void CheckIfInputContainsEmailAndAge(string[] employeeInfo, Employee employee)
        {
            string email;
            int age;
            int isNumber;

            if (employeeInfo.Length > 4)
            {
                if (int.TryParse(employeeInfo[4], out isNumber))
                {
                    age = isNumber;
                    employee.Age = age;
                }
                else
                {
                    email = employeeInfo[4];
                    employee.Email = email;
                }
            }

            if (employeeInfo.Length > 5)
            {
                age = int.Parse(employeeInfo[5]);
                employee.Age = age;
            }
        }
    }
}
