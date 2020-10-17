using ImagoDLL.Abstract;

namespace ImagoDLL.Concrete
{
    public class Gnosis: iGnosis
    {
        public string[,] GnosisTable { get { return GnosisTable; } set { GnosisTable = value; } }

        public Gnosis()
        {
            GnosisTable = new string[11, 11] {
                { "Gnosis", "Ritual Interval", "Trait Max", "Yantras", "Paradox", "Combined Spells", "Obsessions", "Mana Pool", "Mana Per Turn", "Highest Arcanum Max", "Other Arcana Max" },
                { "1",  "3 Hours",      "5", "2", "1", "1", "1", "10", "1", "3", "2" },
                { "2",  "3 Hours",      "5", "2", "1", "1", "1", "11", "2", "3", "3" },
                { "3",  "1 Hour",       "5", "3", "2", "2", "2", "12", "3", "4", "3" },
                { "4",  "1 Hour",       "5", "3", "2", "2", "2", "13", "4", "4", "4" },
                { "5",  "30 Minutes",   "5", "4", "3", "2", "2", "15", "5", "5", "4" },
                { "6",  "30 Minutes",   "6", "4", "3", "3", "3", "20", "6", "5", "5" },
                { "7",  "10 Minutes",   "7", "5", "4", "3", "3", "25", "7", "5", "5" },
                { "8",  "10 Minutes",   "8", "5", "4", "3", "3", "30", "8", "5", "5" },
                { "9",  "1 Minute",     "9", "6", "5", "4", "4", "50", "10", "5", "5" },
                { "10", "1 Minute",     "10", "6", "5", "4", "4", "75", "15", "5", "5" }, 
            };
            /*      -:  0   1   2   3   4   5   6   7   8   9   10
             *      0:  G   RI  TM  Y   P   CS  O   M   PT  HA  OA     
             *      1:  1   3h  5   2   1   1   1   10  1   3   2
             *      2:  2   3h  5   2   1   1   1   11  2   3   3
             *      3:  3   1h  5   3   2   2   2   12  3   4   3
             *      4:  4   1h  5   3   2   2   2   13  4   4   4
             *      5:  5   30m 5   4   3   2   2   15  5   5   4
             *      6:  6   30m 6   4   3   3   3   20  6   5   5
             *      7:  7   10m 7   5   4   3   3   25  7   5   5
             *      8:  8   10m 8   5   4   3   3   30  8   5   5
             *      9:  9   1m  9   6   5   4   4   50  10  5   5
             *      10: 10  1m  19  6   5   4   4   75  15  5   5
             */
        }
    }
}
