using System;
using System.Collections.Generic;
using System.Text;

namespace Passku.Generator.Abstract
{
    interface IGenerate
    {
        /// <summary>
        /// This method create new random password.
        /// </summary>
        /// <param name="passwordLength">This parameter is your password length.</param>
        /// <param name="isSymbol">If this parameter is true, your password contains symbols.</param>
        /// <param name="isNumber">If this parameter is true, your password contains numbers.</param>
        /// <param name="isUpperCase">If this parameter is true, your password contains upper case.</param>
        /// <returns></returns>
        String CreatePassword(int? passwordLength = 15, bool? isSymbol = false, bool? isNumber = false, bool? isUpperCase = false);
    }
}
