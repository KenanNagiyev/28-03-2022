using System;

namespace ConsoleApp28
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee em = new Employee("Kenan", "Nagiyev", 18, 15, 40);
            Student stud = new Student("Ibrahim", "Huseynov", 20, 50, 77);
            if (em.Age < 18)
            {
                throw new Exception("yas 18 den kicikdir olmaz");
            }
            if (em.WorkingHour * em.SalaryofHour < 250)
            {
                throw new Exception("maas 250 den az ola bilmez");
            }
            if (stud.Age < 6 || stud.Age > 20)
            {
                throw new Exception("yas 6 dan az, 20 den cox ola bilmez");
            }
            if (stud.IQRank + stud.LanguageRank < 120)
            {
                throw new Exception("120 den az olmaz");
            }

        }
    }
    abstract class Person
    {

        public abstract void FulName();
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
    }
    class Employee : Person
    {

        public override void FulName()
        {
            Console.WriteLine(Name + Surname + Age);
        }
        //SalaryofHour-1 saata qazandigi maas
        //WorkingHour-1 ayda islediyi saat
        public int CalculateSalary(int SalaryofHour, int WorkingHour)
        {
            if (Age >= 18 && SalaryofHour * WorkingHour >= 250)
            {
                return SalaryofHour * WorkingHour;
            }
            return -1;

        }
        public int SalaryofHour;
        public int WorkingHour;
        public Employee(string name, string surname, int age, int salary, int hour)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            this.SalaryofHour = salary;
            this.WorkingHour = hour;

            Console.WriteLine("Name: " + name + " " + "Surname: " + surname + " " + "Age: " + age + " " + "Salary of Month: " + CalculateSalary(SalaryofHour, WorkingHour));
        }

    }
    class Student : Person
    {
        public override void FulName()
        {
            Console.WriteLine(Name + Surname + Age);
        }
        //IQRank-IQ imtahaninin neticesi
        //LanguageRank-Dil imtahaninin neticesi
        public int ExamResult(int IQRank, int LanguageRank)
        {
            if (IQRank <= 100 && LanguageRank <= 100 && Age >= 6 && Age <= 20 && IQRank + LanguageRank >= 120)
            {
                return IQRank + LanguageRank;
            }
            return -1;


        }
        public int IQRank;
        public int LanguageRank;
        public Student(string name, string surname, int age, int Iqrank, int Languagerank)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            this.IQRank = Iqrank;
            this.LanguageRank = Languagerank;

            Console.WriteLine("Name: " + name + " " + "Surname: " + surname + " " + "Age: " + age + " " + "ExamResult: " + ExamResult(IQRank, LanguageRank));
        }
    }
}
    

