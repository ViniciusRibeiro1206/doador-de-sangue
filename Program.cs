int idade;

Console.Write("Digite sua idade: ");
idade = Convert.ToInt32(Console.ReadLine());

if (idade > 18 && idade < 68)
{

    Console.WriteLine("Você pode ser doador.");

}

else
{

    Console.WriteLine("Você não pode ser doador.");

}
