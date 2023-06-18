using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTC
{
    internal class User:Person
    {
       
      
        public void ChangePassword(string newPassword)
        {
            bool isRightPassword = false;
            int digitCount = 0;

            do
            {
                if (newPassword == null || newPassword.Length < 8)
                {
                    Console.WriteLine("Пароль должен содержать минимум 2 цифры и состаяать из 8 букв и цифр. Попробуйте еще раз.");
                    newPassword = Console.ReadLine();
                }

                digitCount = 0;

                foreach (var item in newPassword)
                {
                    if (int.TryParse(item.ToString(), out int b))
                    {
                        digitCount++;
                        if (digitCount >= 2)
                        {
                            isRightPassword = true;
                            break;
                        }
                    }
                }

                if (!isRightPassword)
                {
                    Console.WriteLine("Пароль должен содержать минимум 2 цифры. Попробуйте еще раз.");
                    newPassword = Console.ReadLine();
                }

            } while (!isRightPassword);

            password = newPassword;
        }

    }
}
