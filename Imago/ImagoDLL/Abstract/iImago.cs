namespace ImagoDLL.Abstract
{
    public interface iImago
    {
        iSpell spell { get; set; }
        int Gnosis { get; set; }
        int Arcanum { get; set; }
        string Method { get; set; } // Casting Method
        int CastingTime { get; set; }
        bool aRange { get; set; }
        int Potency { get; set; }
        bool aPotency { get; set; }
        int Duration { get; set; } 
        bool aDuration { get; set; } 
        int Scale { get; set; }
        bool aScale { get; set; }

        int FreeReach();

        void InitialFactors();

        bool CastableCheck();

        int DicePool();
    }
}
