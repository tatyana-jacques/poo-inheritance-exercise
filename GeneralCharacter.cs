using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_character
{
    public class GeneralCharacter
    {
        protected string _name;
        protected int _life;
        protected int _strength;
        protected float _experience;
        protected bool _magic;

        public string Name
        {
            get { return _name; }
        }

        public int Life
        {
            get { return _life; }
        }

        public int Strength
        {
            get { return _strength; }
        }

        public float Experience
        {
            get { return _experience; }
        }

        public GeneralCharacter(string name, int life, int strength, float experience)
        {
            _name = name;
            _life = life;
            _strength = strength;
            _experience = experience;

        }

        public void IncrementXP(float increment)
        {
            _experience += increment;
        }

        public virtual void DecrementLife(int damage)
        {
            if (_life - damage >= 0)
            {
                _life -= damage;
            }
            else
            {
                _life = 0;
                Console.WriteLine("Game over!");
            }

        }

        public void IncrementStrength(int increment)
        {
            _strength += increment;
        }

        public void SetMagic()
        {
            _magic = true;
            Console.WriteLine("Now you can use magic!");
        }
    }

}