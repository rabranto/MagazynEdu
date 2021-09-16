﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazynEdu.DataAccess.Entities
{
    public class Author : EntityBase
    {
        [Required]
        [MaxLength(250)]
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }
}
