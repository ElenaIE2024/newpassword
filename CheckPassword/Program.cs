using PasswordLibrary;

Console.Write("Введите пароль: ");
string s = Console.ReadLine();
Password password = new Password(s);
if (password.CheckPassword())
    Console.WriteLine("Пароль соответствует требованиям");
else
    Console.WriteLine("Пароль не соответствует требованиям");
Console.ReadKey();