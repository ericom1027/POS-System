using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Pharmacy
{
    class RegexValidation
    {

        #region Validation Object using regex

        public string strTextBoxCheckContains(string strRegex, string strTxtBoxContains)
        {
            var strRtrValue = new PharmacyModel();

            Regex regexContains = new Regex(strRegex);
            if (regexContains.IsMatch(strTxtBoxContains))
            {
                strRtrValue.strTypes = "True";
            }
            else
            {
                strRtrValue.strTypes = "False";
            }

            return strRtrValue.strTypes;
        }

        #endregion
    }
}
