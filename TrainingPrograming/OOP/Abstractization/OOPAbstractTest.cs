using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPrograming.OOP.Abstractization
{
    public class OOPAbstractTest
    {
        // Interface
        //  - defines a contract (what must be done)
        //  - cannot contain implementation
        //  - cannot have fields (only properties); can not have constructors
        //  - a class can implement multiple interfaces
        //  - used when you just need to define behavior

        // Abstract class
        //  - defines a base (shared code and structure)
        //  - can contain both abstract and concrete methods
        //  - can have fields, properties, and constructors
        //  - a class can inherit from only one abstract class
        //  - used when you need to provide common behavior + enforce rules

        [Test]
        public void AbstractTest()
        {
            Employee employee = new Employee("Sam", "Smith", 34, "Endava", 2200);
            employee.GoToWork();
            employee.TakeABreak();

            EmployeeStudent employeeStudent = new EmployeeStudent("Andreea", "Marinescu", 26, "Microsoft", 1800, "ASE", "Finance");
            employeeStudent.GoToWork();
            employeeStudent.TakeABreak();
            employeeStudent.AttendClass();
            employeeStudent.TakeExam();

            Student student = new Student("Mihaela", "Mihai", 24, "NYU", "Robotics",true);
            student.DisplayStudentInfo();
            student.AttendClass();
            Student student2 = new Student("John", "Johnathan", 21, "Cambridge", "Literature", true, true);
            student2.DisplayStudentInfo();

        }
    }
}
