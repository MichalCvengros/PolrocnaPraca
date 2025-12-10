using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//sea serpent

namespace Polročná_práca
{
    internal class Boss : Monster
    {
        public Boss(int _HP, int _DMG) : base(_HP, _DMG)
        {
            _HP = 200;
            _DMG = 25;
        }       
    }
}
