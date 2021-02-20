using GameTop.Interface;

namespace GameTop.Lib
{
    public class Jogador2 : iJogador
    {

        public readonly string _Nome;
        public Jogador2(string nome = "Maradona")
        {
            _Nome = nome;
        }
        public string Chuta()
        {
            return $"{_Nome} esta passando\n";
        }

        public string Corre()
        {
            return $"{_Nome} esta correndo\n";
        }

        public string Passe()
        {
            return $"{_Nome} esta chutando\n";
        }
    }
}