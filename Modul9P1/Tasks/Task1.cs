using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul9P1
{
    public delegate void MessageDelegate(string message);

    internal class Task1
    {
        public static void Tas1()
        {
            MessageDelegate messageDelegate;

            // Призначення методу делегату
            messageDelegate = ShowMessage;
            messageDelegate("Hello, this is the first message!");

            // Призначення іншого методу делегату
            messageDelegate = ShowMessageInUpperCase;
            messageDelegate("Hello, this is the second message!");
        }

        static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }

        // Метод для відображення повідомлення у верхньому регістрі
        static void ShowMessageInUpperCase(string message)
        {
            Console.WriteLine(message.ToUpper());
        }
    }
}
