///Exercicio 11 - level 2 
// Console.WriteLine("Escreva o valor de B");
// int B = int.Parse(Console.ReadLine());

// int C = A;

// A = B;

// B = C;

// Console.WriteLine($"O Valor de A é igual :{A}\nO Valor de B é igual a:{B}");

///Exercicio 12 
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

///Exercicio 13 
// Console.WriteLine("Digite um valor");

// int numero1 = int.Parse(Console.ReadLine());

// Console.WriteLine("Digite um valor");

// int numero2 = int.Parse(Console.ReadLine());

// Console.WriteLine("Digite um valor");

// int numero3 = int.Parse(Console.ReadLine());

// int maior , menor , medio; 

// if (numero1 >= numero2 && numero1 >= numero3){
//     maior = numero1;
//     if (numero2 >= numero3)
//     {
//         medio = numero2;
//         menor = numero3;
//     }
//     else
//     {
//         medio = numero3;
//         menor = numero2;
//     }
//     Console.WriteLine($"A ordem dos valores em decresente : {menor} , {medio} , {maior}");
// }
// else if (numero2 >= numero1 && numero2 >= numero3)
// {
//     maior = numero2;
//     if (numero1 >= numero3)
//     {
//         medio = numero1;
//         menor = numero3;
//     }
//     else
//     {
//         medio = numero3;
//         menor = numero1;
//     }
//     Console.WriteLine($"A ordem dos valores em decresente : {menor} , {medio} , {maior}");
// }
// else
// {
//     maior = numero3;
//     if (numero1 >= numero2)
//     {
//         medio = numero1;
//         menor = numero2;
//     }
//     else
//     {
//         medio = numero2;
//         menor = numero1;
//     }
//     Console.WriteLine($"A ordem dos valores em decresente : {menor} , {medio} , {maior}");
// }

///Exercicio 14 
// Console.WriteLine("Digite um valor");

// double numero1 = double.Parse(Console.ReadLine());

// Console.WriteLine("Digite um valor");

// double numero2 = double.Parse(Console.ReadLine());

// double maior , menor;

// if (numero1 >= numero2 )
// {
//     maior = numero1;
//     menor = numero2;
    
//     double diferenca = numero1 % numero2;
//     Console.WriteLine($"A diferença entre valores é : {diferenca}");
// }
// else if (numero2 >= numero1 )
// {
//     maior = numero2;
//     menor = numero1;
    
//     double diferenca = numero2 % numero1;
//     Console.WriteLine($"A diferença entre valores é : {diferenca}");
// }

///Exercicio 15 


// Console.WriteLine("Digite a nota do primeiro bimestre");

// double nota1 = double.Parse(Console.ReadLine());

// Console.WriteLine("Digite a nota do segundo bimestre");

// double nota2 = double.Parse(Console.ReadLine());

// Console.WriteLine("Digite a nota do terceiro bimestre");

// double nota3 = double.Parse(Console.ReadLine());

// Console.WriteLine("Digite a nota do quarto bimestre");

// double nota4 = double.Parse(Console.ReadLine());

// double media = nota1 + nota2 + nota3 + nota4 /4;

// if(media >= 7)
// {
//     Console.WriteLine("Aluno Aprovado");
// }
// else
// {
//     Console.WriteLine("Digite o valor da recuperação");
//     double recuperacao = double.Parse(Console.ReadLine());
//     double novaMedida = media + recuperacao;
//     if(novaMedida >= 7)
//     {
//         Console.WriteLine("Aluno Aprovado");
//     }
//     else
//     {
//         Console.WriteLine("Aluno reprovado");
//     }
// }

///Exercicio 16 

// Console.WriteLine("Digite o Primeiro valor");

// double numero1 = double.Parse(Console.ReadLine());

// Console.WriteLine("Digite o Segundo valor");

// double numero2 = double.Parse(Console.ReadLine());

// double maior , menor;

// if (numero1 > numero2)
// {
//     maior=numero1;
//     menor=numero2;

//     Console.WriteLine($"O maior numero é {maior} e o menor é {menor}");
// } 
// else if (numero1 < numero2)
// {
//     maior = numero2;
//     menor = numero1;

//     Console.WriteLine($"O maior numero é {maior} e o menor é {menor}");
// }
// else
// {
//     Console.WriteLine("Os numeros são iguais");
// }

///Exercicio 17 

// Console.WriteLine("Digite um numero");

// int numero1 = int.Parse(Console.ReadLine()); 

// if(numero1 >= 0 || numero1 >= 9)
// {
//     Console.WriteLine("Valor valido");
// }
// else
// {
//     Console.WriteLine("Valor invalido");
// }

///Exercicio 18 _ Escreva um programa que leia um número inteiro (variável CODIGO). Verificar se o código é igual a 1, igual a 2 ou
// igual a 3. Caso não seja, apresentar a mensagem “Código inválido”. Ao ser verificado o código e constatado que é
// um valor válido, o programa deve verificar cada código em separado para determinar seu valor por extenso, ou
// seja, apresentar a mensagem “um”, ”dois” ou “três”. (Utilizar o comando Switch). 

Console.WriteLine("Digite um valor");
int valor = int.Parse(input.ReadLine()); 

switch (valor)
{
    case 1:
    Console.WriteLine("Valor Valido");
    
    case 2:
    Console.WriteLine("Valor Valido");
    case 3:
    Console.WriteLine("Valor Valido");
    break;
    default:
    Console.WriteLine("Codigo invalido");
    break;
}
