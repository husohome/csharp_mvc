using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemon
{
    class PokemonType : IEquatable<PokemonType>
    {
        public string Name { get; set; }
        public PokemonType WeakAgainst { get; set; }
        public PokemonType StrongAgainst { get; set; }

        public PokemonType(string name) {
            this.Name = name;
        }
        public PokemonType(string name, PokemonType strongAgainst, PokemonType weakAgainst) {
            this.Name = name;
            this.WeakAgainst = weakAgainst;
            this.StrongAgainst = strongAgainst;
        }
        public double GetScalar(PokemonType enemyType)
        {
            if (enemyType == this.StrongAgainst)
                return 1.5;
            else if (enemyType == this.WeakAgainst)
                return 0.5;
            else
                return 1;

        }

        public override string ToString()
        {
            return $"{this.Name} 攻擊x1.5倍: {this.StrongAgainst.Name} 攻擊x0.5倍{this.WeakAgainst.Name}";
        }

        public bool Equals(PokemonType other) {
            return other.Name == this.Name && other.StrongAgainst == this.StrongAgainst && other.WeakAgainst == this.WeakAgainst;
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode() + this.StrongAgainst.GetHashCode() + this.WeakAgainst.GetHashCode();
        }

    }
}
