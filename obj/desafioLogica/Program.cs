    while(true){
        Console.Write("Digite a quantidade de notas que serão calculadas: ");
        
        int qNotas = Convert.ToInt32(Console.ReadLine());
        double sumNotas = 0;
        char continuar = '.';
        for(int nota=1; nota<=qNotas; nota++){
            Console.Write($"Digite a {nota}° nota: ");
            sumNotas += Convert.ToDouble(Console.ReadLine());
        }
        double media = Math.Round(sumNotas/qNotas, 2);
        Console.WriteLine($"A média do aluno é de: {media}");
        if(media >= 6){
            Console.WriteLine("Está Aprovado");
        }
        else{
            Console.WriteLine("Está Repovado");
        }

        do{
            try{
                Console.Write("Deseja escrever a nota para outro aluno(S/N) ?: ");
                continuar = Convert.ToChar(Console.ReadLine().ToLower());
            }
            catch{
                Console.WriteLine("Digite um opção valida (S/N)");
            }
        }while(continuar != 's' && continuar != 'n');

        if(continuar == 'n'){
            Console.WriteLine("Até logo!");
            break;
        }
    }
