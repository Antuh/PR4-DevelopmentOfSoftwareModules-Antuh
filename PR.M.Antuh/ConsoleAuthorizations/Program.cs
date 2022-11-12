using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleAuthorizations.Module;
using HashPasswords;

namespace ConsoleAuthorizations
{
    class Program
    {
        static void Main(string[] args)
        {
            Helper ms2 = new Helper();
            Entities1 ms = Helper.getContext();
            Console.WriteLine("Добавление сотрудника и создание учетной записи");
            Console.Write("Введите имя сотрудника: ");
            string name = Console.ReadLine();
            Console.Write("Введите фамилию сотрудника: ");
            string surname = Console.ReadLine();
            Console.Write("Введите отчество сотрудника: ");
            string patronymic = Console.ReadLine();
            Console.Write("Введите дату рождения сотрудника: ");
            string born = Console.ReadLine();
            Console.Write("Введите айди должности сотрудника: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Введите логин сотрудника: ");
            string login = Console.ReadLine();
            Console.Write("Введите пароль сотрудника: ");
            string password = Console.ReadLine();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname)
                && string.IsNullOrEmpty(born) 
                && string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                Console.WriteLine("Не все нужные данные введены");
            }
            else if (int.TryParse(name, out int n) || int.TryParse(surname, out int s)
                || int.TryParse(login, out int l))
            {
                Console.WriteLine("Данные введены не корректно");
            }
            else if (DateTime.TryParseExact(born, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime dt))
            {

                HashPassword hash = new HashPassword();
                Console.WriteLine($"Хешированный пароль пользователя: {hash.HashPassw(password)}");
                Console.WriteLine($"Длина хешированного пароля: {hash.HashPassw(password).Length}");
                int idstaff = Helper.GetLastIDStaff();
                
                
                Staff staffs = new Staff { ID_Staff = idstaff, Name = name, Surname = surname, Patronymic = patronymic, Born = dt, ID_Post = id};
                Authorizations authorization = new Authorizations { ID_Authorization = idstaff, Login = login, Password = hash.HashPassw(password) };
                Helper.Create(staffs, authorization);
                Console.WriteLine("Учетная запись добавлена");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Неправильный ввод даты рождения");
            }
        }
    }
}
