using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPrograming.OOP.Abstractization
{
    public interface IStudent
    {
        string Name { get; }
        int Age { get; }
        void Study();
        void AttendClass();
        void TakeExam();

    }
}
