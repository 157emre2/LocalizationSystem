namespace LocalizationSystem
{
    public class LocalizationModel
    {
        public string Key { get; set; }
        public List<LocalizationValue> Values { get; set; }
    }

    public class LocalizationValue
    {
        public string Lang { get; set; }
        public string Value { get; set; }
    }
}