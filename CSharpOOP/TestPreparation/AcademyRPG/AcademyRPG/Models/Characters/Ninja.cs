namespace AcademyRPG
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;


    public class Ninja : Character, IFighter, IGatherer
    {
        public Ninja(string name, Point position, int owner) 
            : base(name, position, owner)
        {
            this.HitPoints = 1;
        }

        public int AttackPoints
        {
            get
            {
                return 0;
            }
        }

        public int DefensePoints
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            throw new NotImplementedException();
        }

        public bool TryGather(IResource resource)
        {
            if (resource.Type == ResourceType.Lumber || resource.Type == ResourceType.Stone)
            {
                return true;
            }

            return false;
        }
    }
}
