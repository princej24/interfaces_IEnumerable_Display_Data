using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace interfaces_IEnumerable_Display_Data
{
    public class Student
    {
        public string _FirstName ; 
      
        public Student(string firstName)
        {
            _FirstName = firstName;
          
        }
        public override string ToString()
        {
            return $"student first name --{ _FirstName} ";
        }
      
    }
}
