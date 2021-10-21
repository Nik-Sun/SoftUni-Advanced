using System;
using System.Collections.Generic;
using System.Text;

namespace BakeryOpenning
{
    public class Bakery
    {
        private List<Employee> data;
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count { get => data.Count; }

        public Bakery(string name,int capacity)
        {
            Name = name;
            Capacity = capacity;
            data = new List<Employee>();
        }
        public void Add(Employee employee)
        {
            if (data.Count < Capacity)
            {
                data.Add(employee);
            }
        }
        public bool Remove(string name)
        {
            Employee employee = data.Find(e =>e.Name == name);
            return data.Remove(employee);
        }
        public Employee GetOldestEmployee()
        {
            int maxAge = int.MinValue;
            Employee oldest = null;
            foreach (Employee employee in data)
            {
                if (employee.Age> maxAge)
                {
                    maxAge = employee.Age;
                    oldest = employee;
                }
            }
            return oldest;
        }
        public Employee GetEmployee(string name)
        {
            return data.Find(e => e.Name == name);
        }
        public string Report()
        {
            return $"Employees working at Bakery {Name}:\r\n{string.Join("\r\n", data)}";
        }
    }
}
