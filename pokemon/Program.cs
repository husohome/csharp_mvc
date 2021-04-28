using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            // 建立好屬性相剋表
            var water = new PokemonType("水");
            var grass = new PokemonType("草");
            var fire = new PokemonType("火");
            water.StrongAgainst = fire;
            water.WeakAgainst = grass;
            grass.StrongAgainst = water;
            grass.WeakAgainst = fire;
            fire.StrongAgainst = grass;
            fire.WeakAgainst = water;

            // 做出三隻神奇寶貝
            var bulbasaur = new Pokemon("妙蛙種子", 10, 2, 1, grass);
            var squirtle = new Pokemon("傑尼龜", 10, 2, 1, water);
            var charmander = new Pokemon("小火龍", 10, 2, 1, fire);

            bool turn = true; // 如果true則是第一隻神奇寶貝的回合; 如果是false是第二支的回合

            // 設定
            var player1 = bulbasaur; // 把這邊改掉
            var player2 = squirtle; // 把這邊改掉

            // 開始打架(比方說妙蛙種子對傑尼龜)
            while (!player1.IsDead && !player2.IsDead) {
                if (turn)
                {
                    Console.WriteLine(player1.Name + "的回合，發動攻擊");
                    player1.Attack(player2);
                }
                else {
                    Console.WriteLine(player2.Name + "的回合，發動攻擊");
                    player2.Attack(player1);
                }
                Console.WriteLine("目前狀況:");
                Console.WriteLine(player1);
                Console.WriteLine(player2);
                Console.WriteLine("*********** 按任意鍵繼續");
                turn = !turn; //這樣就可以輪流
                Console.Read();
            }

            Console.WriteLine("對決結束");
            Console.Read();

        }
    }
}
