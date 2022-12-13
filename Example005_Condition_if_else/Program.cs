Console.Write("Введите имя пользоватля :");
string userName = Console.ReadLine();

if(userName.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же Маша!");
}
else
{
    Console.Write("Привет ");
    Console.WriteLine(userName);

}
