using System;

namespace HYK.Scoreboards
{
    [Serializable]
    public struct ScoreboardEntryData
    {
        public string entryName;
        public string entryScore;
        public string entryGrade;
        public string entryAdd;
        public string entryMinus;
        public string entryMultiply;
        public string entryDivision;
    }
}
