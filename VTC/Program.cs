using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Xml;

namespace VTC
{
    internal class Program
    {
        static void Main()
        {
            User user = new User();

            Console.WriteLine("Введите новый пароль:");
            string newPassword = Console.ReadLine();
            
            try
            {
                user.ChangePassword(newPassword);
                Console.WriteLine("Пароль успешно изменен.");
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Ошибка при изменении пароля,нужны как минимум две цифры : " + ex.Message);
            }

           
        }
   }
}


