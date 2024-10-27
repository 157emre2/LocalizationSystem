namespace LocalizationSystem
{
    public static class Localizer
    {
        public static List<LocalizationModel> localizationData;


        public static string Localize(this string key, string lang)
        {
            return localizationData.FirstOrDefault(x => x.Key == key)?.Values.FirstOrDefault(x => x.Lang == lang)?.Value;
        }
    }
}
