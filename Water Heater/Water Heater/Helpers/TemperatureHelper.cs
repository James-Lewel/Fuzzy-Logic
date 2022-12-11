namespace Water_Heater.Helpers
{
    internal static class TemperatureHelper
    {
        public static string GetRule(double temperature)
        {
            if (temperature > 85) return "X_LARGE";
            else if (temperature > 60) return "LARGE";
            else if (temperature > 30) return "MEDIUM";
            else if (temperature > 10) return "SMALL";
            else return "X_SMALL";
        }
    }
}
