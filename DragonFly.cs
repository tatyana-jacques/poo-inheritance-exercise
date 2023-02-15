using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_character
{
    public class DragonFly : GeneralCharacter
    {

        private bool _isFlying;
        public DragonFly(string name, int life, int strength, float experience) : base(name, life, strength, experience)
        {

        }

        public override void DecrementLife(int increment)
        {
            _life += increment;
        }

        public void SetIsFlying()
        {
            _isFlying = true;
            Console.WriteLine("Is she walking through the coulds? {0}", _isFlying);

        }

    }
}