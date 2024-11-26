﻿using System.ComponentModel.DataAnnotations;

namespace Lab3.Models
{
    public class Category
    {
        [Key]
        public int id { get; set; }
        public string name {  get; set; }
        public string description { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }
}
