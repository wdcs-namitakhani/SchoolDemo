﻿using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SchoolDemo.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [NotMapped]
        public string EncryptedId { get; set; } 
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Name { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Fname { get; set; }
        [EmailAddress]
         
        [Column(TypeName = "varchar(50)")]
        public string Email { get; set; }
        
        [Column(TypeName = "varchar(50)")]
        public string Mobile { get; set; }
        public string Description { get; set; }
        public int DepartmentId { get; set; }

        public Department Department { get; set; }
        public int SemId { get; set; }
        public Sem sem { get; set; }

        [NotMapped]
        public string DepartmentName { get; set; }
       
        [NotMapped]
        public string SemName { get; set; }
    }
}
