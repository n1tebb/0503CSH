using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0503CSH
{
    public class Features_Student
    {
        private string _FIO;
        private int _groupName;
        private int _gradeBookNum;
        public string FIO
        {
            get { return _FIO; }
            set { _FIO = value; }
        }
        public int GroupName { get; }
        public int GradeBookNum { get; }
        public string SNILS { get; }
        public string Info() => $"ФИО: {FIO}, Номер группы: {GroupName}, Номер зачетной книжки: {GradeBookNum}, СНИЛС: {SNILS}";
        public Features_Student(string FIO, int groupName, int gradeBookNum)
        {
            FIO = FIO;
            GroupName = groupName;
            GradeBookNum = gradeBookNum;
        }
    }
}
