using ConsoleAddUser.Models;
using HashPasswords;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAddUser
{
    class Program
    {
        static void Main(string[] args)
        {
            Entities Entities = new Entities();
            string Name, Surname, patronomyc, adress, phoneNumber, login, password;
            int idPost, idBranch, gender;
            try
            {
                do
                {
                    Console.WriteLine("Введите имя пользователя: ");
                    Name = Console.ReadLine();

                    Console.WriteLine("Введите фамилию пользователя: ");
                    Surname = Console.ReadLine();

                    Console.WriteLine("Введите Отчество пользователя: ");
                    patronomyc = Console.ReadLine();

                    Console.WriteLine("Введите id должности\n1-Риэлтор 2-Юрист 3-Нотариус 4-Агент по недвижимости: ");
                    idPost = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("В каком из 5 отделов он работает?");
                    idBranch = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите Адресс пользователя: ");
                    adress = Console.ReadLine();

                    Console.WriteLine("Введите Телефонный номер пользователя: ");
                    phoneNumber = Console.ReadLine();

                    Console.WriteLine("Введите id пол\n1-Мужской 2-Женский");
                    gender = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите логин пользователя: ");
                    login = Console.ReadLine();
                    Console.WriteLine("Введите пароль пользователя: ");
                    password = Console.ReadLine();
                } while (Name == "" || Surname == "" || patronomyc == "" || adress == "" || phoneNumber == "" || login == "" || password == "");


                HashPass hasher = new HashPass();
                string hashpassword = hasher.HashPassword(password);
                Console.WriteLine(hashpassword);

                var Emp = new Models.Employee
                {

                    FirstName = Name,
                    SecondName = Surname,
                    Patronymic = patronomyc,
                    Post = idPost,
                    Branch = idBranch,
                    Adress = adress,
                    TelephoneNumber = phoneNumber,
                    Gender = gender

                };
                Entities.Employee.Add(Emp);
                Entities.SaveChanges();

                var user = new Models.Users
                {
                    idUser = Emp.idEmployee,
                    Login = login,
                    Password = hashpassword
                };

                Entities.Users.Add(user);
                Entities.SaveChanges();

                Console.WriteLine("Учетная запись добавлена");
                Console.WriteLine($"Логин сотрудника{login} Пароль сотрудника{hashpassword}");
                Console.ReadKey();
            }
            catch(Exception AAA)
            {
                Console.WriteLine("Не введен индекс");
                Console.ReadKey();
            }

        }

    }
}
