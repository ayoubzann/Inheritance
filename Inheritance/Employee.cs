using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    public class Employee
    {
        protected string _firstName;
        private string _lastName;
        private int _salary;


        public string firstName
        { get { return _firstName; } set { _firstName = value; } }
        public string lastName
        { get { return _lastName; } set { _lastName = value; } }
        public int salary
        { get { return _salary; } set { _salary = value; } }


    }

    public class Manager : Employee
    {
        private int _meetingsPerWeek;
        private int _vacationsPerYear;

        public int meetingsPerWeek
        { get { return _meetingsPerWeek; } set { _meetingsPerWeek = value; } }
        public int vacationsPerYear
        { get { return _vacationsPerYear; } set { _vacationsPerYear = value; } }

    }

    public class Engineer : Employee
    {
        private bool _cSharpSkill;
        private int _xp;
        private string _typeOfEngineer;

        public bool cSharpSkill
        { get { return _cSharpSkill; } set { _cSharpSkill = value; } }
        public int xp
        { get { return _xp; } set { _xp = value; } }

        public string typeOfEngineer
        {
            get { return _typeOfEngineer; }
            set { _typeOfEngineer = value; }

        }
    }

    public class Researcher : Employee
    {
        private string _degree;
        private string _doctorateThesis;

        public string degree { get { return _degree; } set { _degree = value; } }
        public string doctorateThesis { get { return _doctorateThesis; }set { _doctorateThesis = value; } }
    }
}
