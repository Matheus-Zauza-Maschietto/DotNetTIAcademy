Console.Write("Digite sua idade: ");
int idade = int.Parse(Console.ReadLine());

if(idade >= 18){
    Console.WriteLine("Voto Obrigatorio");
}
else if(idade >= 16 && idade <= 17){
    Console.WriteLine("Voto Facultativo");
}
else{
    Console.WriteLine("Você não pode votar ainda");
}

















// // See https://aka.ms/new-console-template for more information
// string nome = "Matheus Zauza Maschieto";
// Console.WriteLine("Digite sua idade");
// int idade = int.Parse(Console.ReadLine());
// Console.WriteLine("Hello, World! "+nome+" e possui "+idade+" anos");
