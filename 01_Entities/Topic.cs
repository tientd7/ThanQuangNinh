﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Topic : IEntity
    {
        [Key]
        public int Id { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        [Display(Name= "Vocabulary")]
        public string Vocalbularies { set; get; }
        [Display(Name="Sentences")]
        public string Content { set; get; }
        public bool IsEnable { set; get; }
    }
}
