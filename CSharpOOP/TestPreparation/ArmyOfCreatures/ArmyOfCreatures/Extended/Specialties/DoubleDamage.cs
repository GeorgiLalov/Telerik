namespace ArmyOfCreatures.Extended.Specialties
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Logic.Specialties;

    public class DoubleDamage : Specialty
    {
        private int rounds;

        public DoubleDamage()
        {

        }

        // greater than 0, be less than or equal to 10
        public int Rounds
        {
            get
            {
                return this.rounds;
            }
            set
            {
                if (value < 1 || value > 11)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.rounds = value;
            }
        }

    }
}
