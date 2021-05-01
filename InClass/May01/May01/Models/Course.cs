﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace May01.Models
{
    public class Course
    {

        public Course(string code, string name, string email)
        {
            this.Code = code;
            this.Name = name;
            this.ServiceEmail = email;
        }
        [Display(Name="課程代碼")]
        public string Code { get; set; }

        [Display(Name="課程名稱")]
        public string Name { get; set; }

        [Display(Name="E-mail")]
        [DataType(DataType.EmailAddress)]
        public string ServiceEmail { get; set; }

    }
}