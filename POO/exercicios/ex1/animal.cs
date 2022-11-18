 namespace ex1
{
    public abstract class animal
    {
        protected string Raca;
        protected string Tamanho;

        public virtual void EmitirSom(){
            Console.WriteLine("Barulho");
        }
    }

    public class Gato: animal{
        public Gato(string raca, string tamanho){
            Raca = raca;
            Tamanho = tamanho;
        }

        public override void EmitirSom(){
            base.EmitirSom();
            Console.WriteLine("O gato mia");
        }
    }

    public class Cachorro: animal{
        public Cachorro(string raca, string tamanho){
            Raca = raca;
            Tamanho = tamanho;
        }
        public override void EmitirSom()
        {
            base.EmitirSom();
            Console.WriteLine("O cachorro late");
        }
    }

    public class Passaro: animal{
        public Passaro(string raca, string tamanho){
            Raca = raca;
            Tamanho = tamanho;
        }

        public override void EmitirSom()
        {
            base.EmitirSom();
            Console.WriteLine("O passarinho pia");
        }
    }
}