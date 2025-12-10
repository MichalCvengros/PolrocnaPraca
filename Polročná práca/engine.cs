using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Polročná_práca
{
    internal class engine
    {
        internal void TakeTurns(Player player, Monster monster)
        {
            bool isGoing = true;
            
            while (isGoing)
            {
                player.DoDamage(monster);
                monster.DoDamage(player);
            }
        }
        public void Play(Player player, Monster monster)
        {
            while (player.IsAlive())
            {
                TakeTurns(player, monster);
                
            }
        }
    }
}

