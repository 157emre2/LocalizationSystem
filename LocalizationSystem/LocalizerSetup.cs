using System.Text.Json;

namespace LocalizationSystem
{
    public static class LocalizerSetup
    {

        public static void SetupLocalize()
        {
            string filePath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Globalization.json");
            var exData = CreateExampleData();

            if (!File.Exists(filePath))
            {
                Console.WriteLine("Globalization.json dosyasi projenin ana dizininde bulunamadi. Dosya sizin icin olusturuluyor :)");
                try
                {
                    var x = File.Create(filePath);
                    x.Close();
                    File.WriteAllText(filePath, JsonSerializer.Serialize(exData, new JsonSerializerOptions { WriteIndented = true }));

                }
                catch (Exception ex)
                {
                    Console.Error.WriteLine(ex);
                }
            }      

            LoadLocalizationData(filePath);

        }

        private static void LoadLocalizationData(string fp)
        {
            var json = File.ReadAllText(fp);
            if (!string.IsNullOrWhiteSpace(json))
            {
                Localizer.localizationData = JsonSerializer.Deserialize<List<LocalizationModel>>(json);
            }
            else
            {
                throw new Exception("Globalization.json dosyasi bos oldugu icin okunamiyor.");
            }

        }

        private static List<LocalizationModel> CreateExampleData()
        {
            var exampleData = new List<LocalizationModel>
            {
                new LocalizationModel
                {
                    Key = "exampleKey",
                    Values = new List<LocalizationValue>
                            {
                                new LocalizationValue
                                {
                                    Lang = "es",
                                    Value = "Valor de la muestra"
                                },
                                new LocalizationValue
                                {
                                    Lang = "en",
                                    Value = "Example Value"
                                }
                            }
                }
            };
            return exampleData;
        }
    }
}
