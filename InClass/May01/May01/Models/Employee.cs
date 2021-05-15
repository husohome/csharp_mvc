using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace May01.Models
{
    public class Employee
    {
        [Required(ErrorMessage ="本欄位必填")]
        [Display(Name="員工姓名")]
        public string Name { get; set; }

        [Required(ErrorMessage = "本欄位必填")]
        [HireDateValidation(ErrorMessage="日期不能為未來")]
        [Display(Name="雇用日期")]
        public DateTime HireDate { get; set; }
    }
}