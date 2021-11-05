using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OperaWebSite.Validations
{
    public class CheckValidYear:ValidationAttribute
    {
        public CheckValidYear()
        {
            ErrorMessage = "The earliest opera is Daphne, 1598, by Corsi, Peri, and Rinuccini";

        }
         public override bool IsValid(object value)
         {
             int year = (int)value;
             if (year < 1598)
               {
                   return false;
               }
              else
                   return true;
         }



    }

}