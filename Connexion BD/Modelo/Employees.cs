using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connexion_BD.Modelo
{
    public class Employees
    {
        public int employee_id { get; set; }
        public string employee_firstName { get; set; }
        public string employee_lastName { get; set; }
        public string employee_email { get; set; }
        public string employee_phone { get; set; }
        public DateTime employee_hireDate { get; set; }
        public int employee_jobId { get; set; }
        public decimal employee_salary { get; set; }
        public int? employee_managerId { get; set; }
        public int? employee_departmentId { get; set; }

        public Employees() { }

        public Employees(int employee_id, string employee_firstName, string employee_lastName, string employee_email,
            string employee_phone, DateTime employee_hireDate, int employee_jobId, decimal employee_salary,
            int employee_managerId, int employee_departmentId)
        {
            this.employee_id = employee_id;
            this.employee_firstName = employee_firstName;
            this.employee_lastName = employee_lastName;
            this.employee_email = employee_email;
            this.employee_phone = employee_phone;
            this.employee_hireDate = employee_hireDate;
            this.employee_jobId = employee_jobId;
            this.employee_salary = employee_salary;
            this.employee_managerId = employee_managerId;
            this.employee_departmentId = employee_departmentId;
        }

        public override string ToString() {
            return employee_firstName + " " + employee_lastName;
        }
    }
}
