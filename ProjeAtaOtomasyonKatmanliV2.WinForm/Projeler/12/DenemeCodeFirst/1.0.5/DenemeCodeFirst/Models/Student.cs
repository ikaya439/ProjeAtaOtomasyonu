using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenemeCodeFirst.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public DateTime InsDate { get; set; }
        public Grade Grade { get; set; }
    }
}
