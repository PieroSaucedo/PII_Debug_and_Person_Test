using System;

namespace UnitTestAndDebug
{
    public class Person
    {
        public Person(string name, string id, string nacimiento)
        {
            this.Name = name;
            this.ID = id;
            this.Nacimiento = nacimiento;
        }

        private string name;

        private string id;

        private string nacimiento;

        public string Name
        {
            get
            {
                return this.name;
            }
            
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.name = value;
                }
            }
        }
        public string ID
        {
            get
            {
                return this.id;
            }

            set
            {
                if (IdUtils.IdIsValid(value))
                {
                    this.id = value;
                }
            }
        }
        public string Nacimiento
        {
            get
            {
                return this.nacimiento;
            }

            set
            {
                if (IdUtils.NacimientoIsValid(value))
                {
                    this.nacimiento = value;
                }
            }
        }

        public void IntroduceYourself()
        {
            Console.WriteLine($"Soy {this.Name}, mi cédula es {this.ID} y nací el {this.Nacimiento}");
        }
    }
}
