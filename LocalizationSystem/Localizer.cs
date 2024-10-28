namespace LocalizationSystem
{
    public static class Localizer
    {
        internal static List<LocalizationModel> localizationData;


        public static string Localize(this string key, string lang)
        {
            var res = localizationData.FirstOrDefault(x => x.Key == key)?.Values.FirstOrDefault(x => x.Lang == lang)?.Value;
            if (string.IsNullOrWhiteSpace(res))
                res = $"{key}, {lang} dilinde bulunamadi.";

            return res;
        }

        public static string Localize(this string key)
        {
            string lang = LanguageSettings.CurrentLanguage;
            var res = localizationData.FirstOrDefault(x => x.Key == key)?.Values.FirstOrDefault(x => x.Lang == lang)?.Value;
            if (string.IsNullOrWhiteSpace(res))
                res = $"{key}, {lang} dilinde bulunamadi.";
            return res;
        }
    }
}
