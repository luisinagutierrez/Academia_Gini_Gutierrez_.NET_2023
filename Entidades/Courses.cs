using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Courses //: Entity
    {
        int _idCourse;
        int _idSubject;
        int _idCommission;
        int _calendarYear;
        int _quota;
        int _numStudents;

        public int IdCourse { get { return _idCourse; } set { _idCourse = value; } }
        public int IdSubject { get { return _idSubject; } set { _idSubject = value; } }
        public int IdCommission { get { return _idCommission; } set { _idCommission = value; } }
        public int CalendarYear { get { return _calendarYear; } set { _calendarYear = value; } }
        public int Quota { get { return _quota; } set { _quota = value; } }

        public int NumStudents { get { return _numStudents; } set { _numStudents = value; } }

        public Courses() { }

        public Courses(int idCourse, int idSubject, int idCommission, int calendarYear, int quota, int numStudents)
        {
            this._idCourse = idCourse;
            this._idSubject = idSubject;
            this._idCommission = idCommission;
            this._calendarYear = calendarYear;
            this._quota = quota;
            this._numStudents = numStudents;

        }

    }
}
