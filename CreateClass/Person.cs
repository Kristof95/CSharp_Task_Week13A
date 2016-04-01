using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Person
    {
        public enum Genders:int { Male, Female};

        private string name;
        private DateTime birthDate;
        public Genders gender;

        public DateTime BirthDate
        {
            get
            {
                return birthDate;
            }

            set
            {
                birthDate = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public Person()
        {

        }

        public Person(string name, DateTime birthDate)
        {
            this.name = name;
            this.birthDate = birthDate;
        }


        public override string ToString()
        {
            return (String.Format("Name:{0}, Birth Date:{1}",this.name, this.birthDate));
        }
    }
}
