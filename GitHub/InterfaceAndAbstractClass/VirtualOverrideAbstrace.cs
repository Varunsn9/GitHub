using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHub.InterfaceAndAbstractClass
{
    internal class VirtualOverrideAbstrace
    {
    }
    public interface Organization
    {
        void Company();
        void Employees();
        void Leads();
    }
    public abstract class V1 : Organization
    {
        string company = "TestYantra";
        public virtual void Company() 
        {
            Console.WriteLine(company);
        }
        public abstract void Employees();
        public abstract void Leads();
    }
    public class Employee : V1
    {
        private string employee { get; set; }
        private string employeesLead { get; set; }
        Employee(string employeeName, string employeesLead) 
        {
            employee = employeeName;
            this.employeesLead = employeesLead;
            new Employee().EmployeesLead();
            new Employee().Employees();
        }

        public Employee()
        {
        }

        public override void Employees()
        {
            Console.WriteLine($"employee name is {employee}");
        }
        public virtual void EmployeesLead()
        {
            Console.WriteLine($"employee lead is {this.employeesLead}");
        }

        public override void Leads()
        {
            
        }
    }
}
