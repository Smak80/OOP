using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public enum Gender{ Female, Male }
    public class Person
    {
        private string _lastname;
        private string _firstname;
        private DateTime _birthday;
        private float _salary;

        public string Lastname
        {
            get { return _lastname; }
            set
            {
                if (value != null && value.Length > 0)
                    _lastname = value;
            }
        }

        public string Firstname
        {
            get => _firstname;
            /*private */set => _firstname = (value != null && value.Length > 0) ? value : "<Неизвестный>";
        }

        public DateTime Birthday => _birthday;

        public TimeSpan Age => DateTime.Today - Birthday;

        public float Salary
        {
            get => _salary;
            set => _salary = Math.Abs(value);
        }

        public Gender Gender { get; set; } = Gender.Male;// (Gender)1;

        public Person(string lastname, string firstname, int age, float salary, Gender gender)
        {
            Lastname = lastname;
            Firstname = firstname;
            //_age = age;
            Salary = salary;
            Gender = gender;
        }

        public Person() : this("Иванов", "Иван", 20, 0, Gender.Male) {}

        public Person(Person p) : this(p.Lastname, p.Firstname, p.Age, p.Salary, p.Gender)
        {
        }

        public override string ToString() => 
            $"{Lastname} {Firstname} (возраст: {Age}, зарплата: {Salary}, {(Gender == Gender.Male ? "Муж." : "Жен.")})";

    }
}