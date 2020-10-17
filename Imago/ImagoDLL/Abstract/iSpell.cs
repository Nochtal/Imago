namespace ImagoDLL.Abstract
{
    public interface iSpell
    {
        string Name { get; set; }
        string Arcanum { get; set; }
        int ArcanumRating { get; set; }
        string Practice { get; set; }
        string PrimaryFactor { get; set; }
        string Withstand { get; set; }
        int ManaCost { get; set; }
        string[] RoteSkills { get; set; }
        string Description { get; set; }
        string[][][] ReachEffects { get; set; } // Reach, Mana, Description
    }
}