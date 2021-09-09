using System;
using System.Collections.Generic;

#nullable disable

namespace apiexample.CTSModel
{
    public partial class Student
    {
        public int StId { get; set; }
        public string StName { get; set; }
        public string StAddress { get; set; }
        public decimal? Marks { get; set; }
    }
}
