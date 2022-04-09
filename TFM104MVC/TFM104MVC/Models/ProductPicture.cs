﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TFM104MVC.Models
{
    public class ProductPicture
    {
        [KeyAttribute]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Url { get; set; }
        [ForeignKey("ProductId")]
        public Guid ProductId { get; set; }

        //連接屬性
        public Product Product { get; set; }
    }
}
