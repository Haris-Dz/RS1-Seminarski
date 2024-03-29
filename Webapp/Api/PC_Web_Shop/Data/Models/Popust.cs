﻿using System.ComponentModel.DataAnnotations;

namespace PC_Web_Shop.Data.Models
{
    public class Popust
    {
        [Key]
        public int Id { get; set; }
        public string Naziv { get; set; }
        public DateTime DatumDo { get; set; }
        public DateTime DatumOd { get; set; }
        public float Procenat { get; set; }
        public bool IsDeleted { get; set; }
    }
}
