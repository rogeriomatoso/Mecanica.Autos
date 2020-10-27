using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mecanica.Autos.Web.Annotations
{
    public class RenavamAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            string numeroRenavam = Convert.ToString(value);
            if(numeroRenavam.Length != 11)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}