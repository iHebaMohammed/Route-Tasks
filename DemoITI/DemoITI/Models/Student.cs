﻿using Microsoft.Extensions.DependencyModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoITI.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Image { get; set; }
        public int Age { get; set; }
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
