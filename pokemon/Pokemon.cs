using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemon
{
    class Pokemon
    {
        public string Name { get; set; }
        public double HP { get; set; }
        public double ATT { get; set; }
        public double DEF { get; set; }

        public bool IsDead = false;
        public PokemonType Type { get; set; }

        public Pokemon(string name,  double hp=10.0, double att = 1.0, double def=1.0, PokemonType type=null)
        {
            if (hp < 0 || att < 0 || def < 0)
                throw new ArgumentException("生命、攻擊力、防禦力都不能是負的");

            this.Name = name;
            this.HP = hp;
            this.ATT = att;
            this.DEF = def;
            this.Type = type;

        }
        public void Die() {
            this.IsDead = true;
            Console.WriteLine(this.Name + "已死亡");
        }

        public void Attack(Pokemon attacked) {
            if (this.IsDead)
            {
                Console.WriteLine("神奇寶貝已經死亡，不能攻擊");
                return;
            }
            attacked.TakeDamage(this);
        }

        public void TakeDamage(Pokemon attacker) {
            if (this.IsDead) {
                Console.WriteLine("神奇寶貝已經死亡，不能再鞭屍");
                return;
            }
                
            double damageDealt = (attacker.ATT - this.DEF) * attacker.Type.GetScalar(this.Type);
            this.HP -= damageDealt < 0 ? 0 : damageDealt;
            if (this.HP <= 0) {
                this.HP = 0;
                this.Die();
            }

        }

        public override string ToString()
        {
            return $"{this.Name}, {this.Type.Name}系神奇寶貝, HP:{this.HP} 攻:{this.ATT} 防:{this.DEF}";
        }



    }
}
