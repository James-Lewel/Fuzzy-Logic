using DotFuzzy;

namespace Water_Heater.Helpers
{
    internal static class HeatKnobHelper
    {
        public static string GetRule(double heat)
        {
            if (heat > 7.5) return "A_WHOLE_LOT";
            else if (heat > 6.0) return "A_LOT";
            else if (heat > 3.0) return "A_GOOD_AMOUNT";
            else if (heat > 1.5) return "A_LITTLE";
            else return "VERY_LITTLE";
        }
    }
}
