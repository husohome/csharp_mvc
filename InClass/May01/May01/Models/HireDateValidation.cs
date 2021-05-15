using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace May01.Models
{
    public class HireDateValidation : ValidationAttribute
    {

        // override掉Validation Attribute的isValid方法
        public override bool IsValid(object value)
        {

            DateTime dateTime = Convert.ToDateTime(value);
            return dateTime <= DateTime.Now;
        }

        
    }
}