using ImagoDLL.Abstract;

namespace ImagoDLL.Concrete
{
    public class Imago: iImago
    {
        public iSpell spell { get { return spell; } set { spell = value; } }
        public int Gnosis { get { return Gnosis; } set { Gnosis = value; } }
        public int Arcanum { get { return Arcanum; } set { Arcanum = value; } }
        public string Method { get { return Method; } set { Method = value; } } // Casting Method
        public int CastingTime { get { return CastingTime; } set { CastingTime = value; } }
            /// 0 = ritual cast or instant cast; 1-5 = extra ritual casting intervals.
        public bool aCastingTime { get { return aCastingTime; } set { aCastingTime = value; } }
        public bool aRange { get { return aRange; } set { aRange = value; } }
        public int Potency { get { return Potency; } set { Potency = value; } }
        public bool aPotency { get { return aPotency; } set { aPotency = value; } }
        public int Duration { get { return Duration; } set { Duration = value; } }
        public bool aDuration { get { return aDuration; } set { aDuration = value; } }
        public int Scale { get { return Scale; } set { Scale = value; } }
        public bool aScale { get { return aScale; } set { aScale = value; } }

        public int SpellFactors { get { return SpellFactors; } set { SpellFactors = value; } }
        public int YantraBonus { get { return YantraBonus; } set { YantraBonus = value; } }
        public int Modifiers { get { return Modifiers; } set { Modifiers = value; } }

        public int FreeReach()
        {
            return (Arcanum + 1) - spell.ArcanumRating;
        }

        public void InitialFactors()
        {
            aCastingTime = false;
            aRange = false;
            aPotency = false;
            aDuration = false;
            aScale = false;
            CastingTime = 1;
            Potency = 1;
            Duration = 1;
            Scale = 1;
        }

        public void SetSpellFactors()
        {
            switch (spell.PrimaryFactor)
            {
                case "Potency":
                    {
                        
                        break;
                    }

                case "Duration":
                    {
                        SpellFactors = -2 * (Potency + (Duration - Arcanum + 1) + Scale);
                        if (CastingTime < 0 && !aCastingTime)
                        {
                            SpellFactors += CastingTime;
                        }
                        break;
                    }
            }
        }

        public bool CastableCheck()
        {
            if (Gnosis + Arcanum + SpellFactors + YantraBonus > -6) return true;
            else return false;
        }

        public int DicePool()
        {
            return Gnosis + Arcanum + SpellFactors + YantraBonus + Modifiers;
        }
    }
}
