//Exercicio 11 - level 2 
// Console.WriteLine("Escreva o valor de B");
// int B = int.Parse(Console.ReadLine());

// int C = A;

// A = B;

// B = C;

// Console.WriteLine($"O Valor de A é igual :{A}\nO Valor de B é igual a:{B}");

//Exercicio 12 
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

//Exercicio 13 
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

//Exercicio 14 
// Console.WriteLine("Digite um valor");

// double numero1 = double.Parse(Console.ReadLine());

// Console.WriteLine("Digite um valor");

// double numero2 = double.Parse(Console.ReadLine());

// double maior , menor;

// if (numero1 > numero2 )
// {
//     maior = numero1;
//     menor = numero2;

//     double diferenca = numero1 % numero2;
//     Console.WriteLine($"A diferença entre valores é : {diferenca}");
// }
// else if (numero2 > numero1 )
// {
//     maior = numero2;
//     menor = numero1;

//     double diferenca = numero2 % numero1;
//     Console.WriteLine($"A diferença entre valores é : {diferenca}");
// }

//Exercicio 15 

// Console.WriteLine("Digite a nota do primeiro bimestre");

// double nota1 = double.Parse(Console.ReadLine());

// Console.WriteLine("Digite a nota do segundo bimestre");

// double nota2 = double.Parse(Console.ReadLine());

// Console.WriteLine("Digite a nota do terceiro bimestre");

// double nota3 = double.Parse(Console.ReadLine());

// Console.WriteLine("Digite a nota do quarto bimestre");

// double nota4 = double.Parse(Console.ReadLine());

// double media = (nota1 + nota2 + nota3 + nota4) /4;

// if(media >= 7)
// {
//     Console.WriteLine("Aluno Aprovado");
// }
// else
// {
//     Console.WriteLine("Digite o valor da recuperação");
//     double recuperacao = double.Parse(Console.ReadLine());
//     double novaMedida = (media + recuperacao)/2;

//     if(novaMedida >= 7)
//     {
//         Console.WriteLine("Aluno Aprovado");
//     }
//     else
//     {
//         Console.WriteLine("Aluno reprovado");
//     }
// }

//Exercicio 16 

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

//Exercicio 17 

// Console.WriteLine("Digite um numero");

// int numero1 = int.Parse(Console.ReadLine()); 

// if(numero1 >= 0 && numero1 <= 9)
// {
//     Console.WriteLine("Valor valido");
// }
// else
// {
//     Console.WriteLine("Valor invalido");
// }

//Exercicio 18 
// Console.WriteLine("Digite um valor");
// int valor = int.Parse(Console.ReadLine()); 

// switch (valor)
// {
//     case 1:
//     Console.WriteLine("um");
//     break;
//     case 2:
//     Console.WriteLine("dois");
//     break;
//     case 3:
//     Console.WriteLine("três");
//     break;

//     default:
//     Console.WriteLine("Codigo invalido");
//     break;
// }

//Exercicio 19

// Console.WriteLine("Digite um valor");

// int A = int.Parse(Console.ReadLine());

// Console.WriteLine("Digite um valor");

// int B = int.Parse(Console.ReadLine());

// Console.WriteLine("Digite um valor");

// int C = int.Parse(Console.ReadLine());

// if (A < B + C && B < A + C && C < A + B)
// {
//     if(A == B && B == C )    
//     {
//         Console.WriteLine("O triàngulo é equilátero");
//     }
//     else if (A == B || A == C || B == C)
//     {
//         Console.WriteLine("O triàngulo é isósceles");
//     }
//     else 
//     {
//         Console.WriteLine("Triângulo escaleno");
//     }
// }
// else
// {
//     Console.WriteLine("Os valores fornecidos não formam um triângulo");
// }

//Exercicio 20 -
// int A = LerValor("A");
// int B = LerValor("B");
// int C = LerValor("C");

// int menor = A;
//         if (B < menor) menor = B;
//         if (C < menor) menor = C;

//         int maior = A;
//         if (B > maior) maior = B;
//         if (C > maior) maior = C;

// int LerValor(string numero){
//     while(true){
//         Console.Write("Digite um numero");
//         if(int.TryParse(Console.ReadLine(), out int valor)&& valor > 0)
//         {
//             return valor;
//         }
//         Console.WriteLine("Valor invalido , por favor digite um valor maior que zero");
//     }
// }

// /Exercicio 21 - 
// while (true) 
// {   
//     Console.WriteLine("Digite um número inteiro (ou 'sair' para terminar): ");
//     string input = Console.ReadLine();

//     if (input.ToLower() == "sair")
//     {
//         break;  
//     }

//     else if ( int.TryParse (input, out int numero) )
//     {

//             if (numero > 0 )
//             {
//                 Console.WriteLine("O valor é positivo");
//             }

//             else
//             {
//                 Console.WriteLine("O valor é negativo");
//             }
//     }
//     else
//     {
//         Console.WriteLine ("Número invalido, por favor Digite um número valido ");
//     }
// }
//Exercicio 22- 
// Console.WriteLine("Digite um valor");
//     int valor = int.Parse(Console.ReadLine());

//     int A = 0, B = 0;

//     if (valor > 0)
//         {
//             A = valor;
//         }
//     else if (valor< 0)
//     {
//             B = valor;
//     }
//     else
//     {
//         Console.WriteLine("O valor não foi armazenado");
//     }
// Console.WriteLine("\nResultado Final;");
// {

//     if(A != 0)
//     {
//         Console.WriteLine($"A(Número Posítivo):{A}");
//     }
//         else 
//     {
//         Console.WriteLine("A(número positivo):Nenhum valor armazenado");
//     }
//
//     if(B != 0)
//     {
//         Console.WriteLine($"A(Números Negativos):{B}");
//     }
//         else
//     {
//         Console.WriteLine("A(Números Negativos):Nenhum valor armazenado");
//     }
// }

// Exercicio 23 -
// Console.WriteLine("1-Adição = A + B\n2-Subtração = A - B\n3-Multiplicação = A * B\n4-Divisão = A / B");

//Exercicio 24 -    Escreva um programa que leia dois números inteiros e apresente as opções para usuário escolher o que deseja
// realizar:
// 1 – Verificar se um dos números lidos é ou não múltiplo do outro
// 2 – Verificar se os dois números lidos são pares
// 3 – Verificar se a média dos dois números é maior ou igual a 7.
// 4 – Sair 

// Console.WriteLine("Digite um valor");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo valor");
int B = int.Parse(Console.ReadLine());



//Exercicio 25 -) Tendo como dados de entrada a altura e o sexo de uma pessoa, faça um programa que calcule seu peso ideal,
// utilizando as seguintes fórmulas: (h = altura)
// - Para homens: (72.7*h) - 58
// - Para mulheres: (62.1 *h) - 44.7 

// Console.WriteLine("Informe seu sexo(Masculino ou Femino)");
// string sexo =Console.ReadLine(); 
// sexo.ToLower(); 
// Console.WriteLine("Informe sua altura");
// string altura= string.Parse(Console.ReadLine()); 


