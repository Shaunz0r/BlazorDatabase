using System;
using System.Collections.Generic;

namespace BlazorApp.Models
{
    public class Personnel
    {
        public int ID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string jobTitle { get; set; }
        public string email { get; set; }
        public int departmentID { get; set; }
    }
}