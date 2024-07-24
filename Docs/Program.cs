using System;

class docs
{
    static void Main()
    {
        string name, lastname, DateOfBirth, Email, PhoneNumber;

        Console.Write("Digite seu nome: ");
         name = Convert.ToString (Console.ReadLine());

        Console.Write("Digite seu sobrenome: ");
          lastname = Convert.ToString (Console.ReadLine());

        Console.Write("Digite sua data data de nascimento: ");
           DateOfBirth = Convert.ToString (Console.ReadLine());

        Console.Write("Digite seu Email: ");
            Email = Convert.ToString (Console.ReadLine());

        Console.Write("Digite seu número de telefone: ");
             PhoneNumber = Convert.ToString (Console.ReadLine());
        Console.WriteLine("Confirme suas informações:\n Nome: {0}\n Sobrenome: {1}\n Data de Nascimento: {2}\n Email: {3} \n Número de Telefone: {4}",name,lastname,DateOfBirth,Email,PhoneNumber);
    }
}