
using GameTop.Interface;

namespace GameTop.Lib
{

    public class Jogador: iJogador
    {
        public readonly string _Nome;

        public Jogador()
        {
        }

        public Jogador(string nome = "Ronaldo")
        {
            _Nome = nome;
           
        }
        public string Chuta ()
        {
             return $"{_Nome} esta chutando\n";
        }
        public string Corre ()
        {
            return $"{_Nome} esta correndo\n";
        }
        public string Passe ()
        {
            return $"{_Nome} esta passando\n";
            
        }
        

    
    
    }

    
    
    
    
}






