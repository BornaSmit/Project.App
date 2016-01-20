using System;

namespace Project.Code.DataValidiation
{
    public class Validiation
    {
        public static bool CheckIfNull(string a)
        {
            if (string.IsNullOrWhiteSpace(a))
            {
                return true;
            }
            else { return false; }
        }

        public static string CheckOperation(string a)
        {
            if (a.Equals(Operations.Operations.display, StringComparison.CurrentCultureIgnoreCase))
            {
                return "display";
            }
            else if (a.Equals(Operations.Operations.enlist, StringComparison.CurrentCultureIgnoreCase))
            {
                return "enlist";
            }
            else return "false";
        }
    }
}
