///Exercicio 1

// Console.WriteLine("Informe o salario");

// double salario = double.Parse(Console.ReadLine());

// double porcentagem = salario * 0.25;

// salario = salario + porcentagem;

// Console.WriteLine($"Novo salario {salario}"); 


///Exercicio 2 

// Console.WriteLine("Informe o salario");

// double salario = double.Parse(Console.ReadLine());

// Console.WriteLine("Informe a porcentagem para incrementar");

// double porcentagem = double.Parse(Console.ReadLine());

// double porcentagemReal = porcentagem / 100; 

// double calculo = salario * porcentagemReal;

// double novoSalario = salario + calculo;

// Console.WriteLine($"Novo salario {novoSalario}");

// /Exercicio 3 

// Console.WriteLine("Ano de Nascimento");

// int anoNascimento = int.Parse(Console.ReadLine());

// Console.WriteLine("Ano Atual");

// int anoAtual = int.Parse(Console.ReadLine());

// int idadeAnos = anoAtual - anoNascimento; 

// int idadeMeses = idadeAnos * 12; 

// int idadeSemana = idadeAnos * 52;

// int idadeDias = idadeAnos * 365;

// Console.WriteLine($"Idades em Anos: {idadeAnos}\nIdade em Meses: {idadeMeses}\nIdade em Semanas: {idadeSemana}\nIdade Dias: {idadeDias}");


// /Exercicio 4 

// Console.WriteLine("Peso do Saco:");//10kilos

// double sacoRacao = double.Parse(Console.ReadLine());

// double sacoGramas = sacoRacao * 1000;

// Console.WriteLine("Porção da raçao:");//200 gramas

// double porcao = double.Parse(Console.ReadLine());

// double consumo = porcao * 2 * 5; 

// double racaoRestante = sacoGramas - consumo;

// Console.WriteLine($"Ração restante no saco {racaoRestante} gramas");


///Exercicio 5 

// Console.WriteLine("Coloque o valor de A");
// int A = int.Parse(Console.ReadLine());

// Console.WriteLine("Coloque o valor de B");
// int B = int.Parse(Console.ReadLine());

// int C = A;
// A = B;
// B = C;  
// Console.WriteLine($"O valor de A é:{A}\nO valor de B é:{B}");

///Exercicio 6

// Console.WriteLine("Diga o Comprimento da caixa");
// double comprimento = double.Parse(Console.ReadLine());  

// Console.WriteLine("Diga a Largura da caixa");
// double largura = double.Parse(Console.ReadLine()); 

// Console.WriteLine("Diga a Altura da caixa");
// double altura = double.Parse(Console.ReadLine());

// double volume = comprimento * largura * altura;
// Console.WriteLine($"O Volume da Caixa é {volume}");

///Exercicio 6 com função 

// Console.WriteLine("Diga o Comprimento da caixa");
// double comprimento = double.Parse(Console.ReadLine());  

// Console.WriteLine("Diga a Largura da caixa");
// double largura = double.Parse(Console.ReadLine()); 

// Console.WriteLine("Diga a Altura da caixa");
// double altura = double.Parse(Console.ReadLine());

// double volume = CalcularVolume(comprimento, largura,altura);

// double CalcularVolume(double comprimento, double largura,double altura){
//     return comprimento * largura * altura;
// }

// Console.WriteLine($"O volume é igual a : {volume}");

// ///Exercicio 7

// Console.WriteLine("Valor de A ");
// int A = int.Parse(Console.ReadLine());

// Console.WriteLine("Valor de B");
// int B = int.Parse(Console.ReadLine());

// int diferença = A - B;

// int quadrado = diferença * diferença;

// Console.WriteLine($"O quadrado da diferença de A e B é = {quadrado}");

///Exercicio 8 

// Console.WriteLine("Digite o valor em Dòlar para converção em Reais:");

// decimal valor = decimal.Parse(Console.ReadLine());

// Console.WriteLine("Digite o valor da cotação do Dólar:");

// decimal cotacao = decimal.Parse(Console.ReadLine());

// decimal conversao = valor *  cotacao;

// Console.WriteLine($"Valor da converção em real: $:{conversao:F}");

///Exercicio 9 

// Console.WriteLine("Digite o valor de A ");

// int A = int.Parse(Console.ReadLine());

// Console.WriteLine("Digite o valor de B ");

// int B = int.Parse(Console.ReadLine());

// Console.WriteLine("Digite o valor C ");

// int C = int.Parse(Console.ReadLine());

// int calculo = (A + B + C) * 2;

// Console.WriteLine($"Valor do quadrado da soma dos 3 valores é igual a :{calculo}");

///Exercicio 10 
///Elaborar um programa que leia dois valores numéricos reais desconhecidos
// representados pelas variáveis A e B. Calcular e apresentar os resultados das quatro
// operações aritméticas básicas (soma, subtração, divisão e multiplicação).



