using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoApp
{
    class Studentinfo
    {
        public int studentId { get; set; }
        public string StudentName { get; set; }
        public string ClassTaken { get; set; }
        private decimal studentGrade;

        public decimal StudentGrade
        {
            get
            {
                return studentGrade;
            }
            set
            {
                if (studentGrade > 0)
                {
                    studentGrade = value;
                }
            }
        }
    }
}
