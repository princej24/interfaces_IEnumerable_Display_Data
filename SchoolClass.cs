using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace interfaces_IEnumerable_Display_Data
{
    public class SchoolClass : IEnumerable<Student>
    {
        public string Name { get; set; }
        private List<Student> roster;

        public SchoolClass(string name)
        {
            Name = name;
            roster = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            roster.Add(student);
        }

        public IEnumerator<Student> GetEnumerator()
        {
            return roster.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public override string ToString()
        {
            string rosterString = "";
            foreach (Student student in roster)
            {
                rosterString += student.ToString() + "\n";
            }
            return $"Class Name: - {Name}\n\n{rosterString}";
        }


    }

}
