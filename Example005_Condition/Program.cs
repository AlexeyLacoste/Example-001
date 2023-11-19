Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "Маша")
{
    Console.WriteLine("УРА, это же МАША!!!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}