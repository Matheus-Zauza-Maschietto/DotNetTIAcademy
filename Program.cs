int nmr = 0;
int soma = 0;

Console.Write("Digite uma sequencia de numero (aperte 0 para sair): ");
nmr = int.Parse(Console.ReadLine());

// while(nmr != 0){
//     soma = soma+nmr;
//     nmr = int.Parse(Console.ReadLine());
// }
// Console.Write("A soma dos números é: "+soma);


do{
    nmr = int.Parse(Console.ReadLine());
    soma = soma+nmr;
}while(nmr != 0);
Console.Write("A soma dos números é: "+soma);




// Console.Write("Digite um numero: ");
// int num = int.Parse(Console.ReadLine());
// for(int contador = 0; contador <= 10; contador++){
//     Console.WriteLine($"{num} x {contador} = {num*contador}");
// }

// bool choveu = true;
// bool tarde = true;

// if(!choveu && !tarde){
//     Console.WriteLine("Vou pedalar");
// }
// else{
//     Console.WriteLine("VOU pedalar outro dia"");
// }


// bool presencaMinima = true;
// double media = 7.5;

// if(presencaMinima && media >= 7){
//     Console.WriteLine("Aprovado");
// }
// else{
//     Console.WriteLine("Reprovado");
// }

// bool maiorIdade = true;
// bool temAltorização = true;

// if(maiorIdade || temAltorização){
//     Console.WriteLine("Entrada liberada");
// }
// else{
//     Console.WriteLine("Entrada não permitida");
// }

// Console.Write("Digite sua idade: ");
// int idade = int.Parse(Console.ReadLine());

// if(idade >= 18){
//     Console.WriteLine("Voto Obrigatorio");
// }
// else if(idade >= 16 && idade <= 17){
//     Console.WriteLine("Voto Facultativo");
// }
// else{
//     Console.WriteLine("Você não pode votar ainda");
// }


// // See https://aka.ms/new-console-template for more information
// string nome = "Matheus Zauza Maschieto";
// Console.WriteLine("Digite sua idade");
// int idade = int.Parse(Console.ReadLine());
// Console.WriteLine("Hello, World! "+nome+" e possui "+idade+" anos");