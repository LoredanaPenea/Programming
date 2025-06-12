using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPrograming.OOP.Abstractization.Abstractization_Interfaces
{
    public interface IStudent
    {
        string Name {  get; }
        int Age { get; }
        bool Erasmus { get; }   
        void Study();
        void AttendClass();
        void TakeExam();

    }
}
