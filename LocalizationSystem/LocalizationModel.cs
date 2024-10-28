namespace LocalizationSystem
{
    internal class LocalizationModel
    {
        public string Key { get; set; }
        public List<LocalizationValue> Values { get; set; }
    }

    internal class LocalizationValue
    {
        public string Lang { get; set; }
        public string Value { get; set; }
    }
}