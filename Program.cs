// В переменной string есть секретное сообщение, во второй есть пароль. 
// Пользователю программы даётся 3 попытки ввести пароль и увидеть секретное сообщение.

Console.WriteLine("Добро пожаловать. У вас есть 3 попытки ввести трехзначный код.");
string pass = "333", input;
int count = 3;
while(count > 0) 
{
    input = Console.ReadLine();
    --count;

    if (input.Equals(pass)) 
    {Console.WriteLine("Добро пожаловать User!"); count = 0;}
    else 
    {Console.WriteLine("Вы ввели не верный код! У вас осталось " + count + " попытки!");}
}


//Есть программа с бесконечным циклом. Когда пользователь вводит exit программа заканчивается

Console.WriteLine("------------------------\nЧто бы выйти наберите exit.");
string inputCom;
bool flag = true;
while(flag) {
    inputCom = Console.ReadLine();
    if (inputCom.Equals("exit")) 
    {
        flag = false;
        Console.WriteLine("До свидание User!");
    }
}