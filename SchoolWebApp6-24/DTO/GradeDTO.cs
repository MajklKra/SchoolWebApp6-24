﻿using SchoolWebApp6_24.Models;
using System.ComponentModel;

namespace SchoolWebApp6_24.DTO {
    public class GradeDTO {
        public int Id { get; set; }
        [DisplayName("Student name")]
        public int StudentId { get; set; }
        [DisplayName("Subject")]
        public int SubjectId { get; set; }
        public string Topic { get; set; }
        public DateTime Date { get; set; }
        [DisplayName("Grade awarded")]
        public int Mark { get; set; }
    }
}
