using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary2
{
    public class Password
    {
        public static string checkPassword(string password)
        {
            string correct = "хорошо";
            string error = "ещё";
            string symbol = "!@#$%^&*()";
            if (password.Length >= 6)
            {
                string erroq = "Нужны спец символ";
                if (password.Intersect(symbol).Count() != 0)
                {
                    string errow = "нужны заглавные";
                    if (password.Any(Char.IsUpper))
                    {
                        string errort = "нужны строчные";
                        if (password.Any(Char.IsLower))
                        {
                            string errore = "Нужны цифры";
                            if (password.Any(Char.IsDigit))
                            {
                                return correct;
                            }
                            else return correct;
                        }
                        else return correct;
                    }
                    else return correct;
                }
                else return correct;
            }
            else return correct;
        }
    }
}
