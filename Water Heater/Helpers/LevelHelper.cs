using DotFuzzy;

namespace Water_Heater.Helpers
{
    internal static class LevelHelper
    {
        public static string GetRule(double level)
        {
            if (level > 7.5) return "X_LARGE";
            else if (level > 6.0) return "LARGE";
            else if (level > 3.0) return "MEDIUM";
            else if (level > 1.5) return "SMALL";
            else return "X_SMALL";
        }
    }
}
