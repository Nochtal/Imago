using ImagoDLL.Abstract;

namespace ImagoDLL.Concrete
{
    public class Spell : iSpell
    {
        public string Arcanum { get { return Arcanum; } set { Arcanum = value; } }

        public int ArcanumRating { get { return ArcanumRating; } set { ArcanumRating = value; } }
        
        public string Description { get { return Description; } set { Description = value; } }

        public int ManaCost { get { return ManaCost; } set { ManaCost = value; } }

        public string Name { get { return Name; } set { Name = value; } }

        public string Practice { get { return Practice; } set { Practice = value; } }

        public string PrimaryFactor { get { return PrimaryFactor; } set { PrimaryFactor = value; } }

        public string[][][] ReachEffects { get { return ReachEffects; } set { ReachEffects = value; } }

        public string[] RoteSkills { get { return RoteSkills; } set { RoteSkills = value; } }

        public string Withstand { get { return Withstand; } set { Withstand = value; } }
    }
}