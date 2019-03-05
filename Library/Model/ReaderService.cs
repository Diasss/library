using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model
{
    class ReaderService
    {
        public void ChangePassword(Reader reader)
        {
            Console.WriteLine("Введите новый пароль: ");
            string newPassword = Console.ReadLine();
            reader.password = newPassword;
        }
        public void CreateBook(Reader reader)
        {

        }
    }
}
