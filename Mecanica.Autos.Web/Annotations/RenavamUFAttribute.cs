using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mecanica.Autos.Web.Annotations
{
    public class RenavamUFAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            return value.ToString().EndsWith("-MG");
        }
    }
}