///Exercicio 11 - Nivel 2 

// Console.WriteLine("Escreva o valor de B");
// int B = int.Parse(Console.ReadLine());

// int C = A;

// A = B;

// B = C;

// Console.WriteLine($"O Valor de A é igual :{A}\nO Valor de B é igual a:{B}");

///Exercicio 12 - 

// Console.WriteLine("Digite o valor de X");

// int x = int.Parse(Console.ReadLine());

// if (x > 0)
// {
//     Console.WriteLine($"O módulo de X é igual a:{x}");
// }
// else if (x < 0)
// {
//     int modulo = x * (-1);
//     Console.WriteLine($"O módulo de X é igual a:{modulo}");
// }

///Exercicio 13 -  Escreva um programa que leia 3 números inteiros e imprima na tela os valores em ordem decrescente.
///Voltar depois 

Console.WriteLine("Digite um valor");

int numero1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite um valor");

int numero2 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite um valor");

int numero3 = int.Parse(Console.ReadLine());

if (numero1 >= numero2 && numero1 >= numero3)
{
    maior = numero1;
    if (numero2 >= numero3)
    {
        medio = numero2;
        menor = numero3;
    }
    else
    {
        medio = numero3;
        menor = numero2;
    }
    Console.WriteLine($"A ordem dos valores em decresente : {menor} , {medio} , {maior}");
}
else if (numero2 >= numero1 && numero2 >= numero3)
{
    maior = numero2;
    if (numero1 >= numero3)
    {
        medio = numero1;
        menor = numero3;
    }
    else
    {
        medio = numero3;
        menor = numero1;
    }
    Console.WriteLine($"A ordem dos valores em decresente : {menor} , {medio} , {maior}");
}
else
{
    maior = numero3;
    if (numero1 >= numero2)
    {
        medio = numero1;
        menor = numero2;
    }
    else
    {
        medio = numero2;
        menor = numero1;
    }
    Console.WriteLine($"A ordem dos valores em decresente : {menor} , {medio} , {maior}");
}


