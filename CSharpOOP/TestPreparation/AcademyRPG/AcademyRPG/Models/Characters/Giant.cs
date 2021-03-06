﻿namespace AcademyRPG
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Giant : Character, IFighter, IGatherer
    {
        private bool isAttackPointsIncreased;

        public Giant(string name, Point position)
            : base(name, position, 0)
        {
            this.HitPoints = 200;
            this.isAttackPointsIncreased = false;
        }

        public int AttackPoints
        {
            get
            {
                if (this.isAttackPointsIncreased)
                {
                    return 250;
                }
                else
                {
                    return 150;
                }
            }
        }

        public int DefensePoints
        {
            get
            {
                return 80;
            }
        }

        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            for (int i = 0; i < availableTargets.Count; i++)
            {
                if (availableTargets[i].Owner != 0)
                {
                    return i;
                }
            }

            return -1;
        }

        public bool TryGather(IResource resource)
        {
            if (resource.Type == ResourceType.Stone)
            {
                this.isAttackPointsIncreased = true;
                return true;
            }

            return false;
        }
    }
}
