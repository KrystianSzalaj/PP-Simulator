namespace Simulator
{
    public static class Validator
    {
        public static int Limiter(int value, int min, int max)
        {
            return Math.Clamp(value, min, max);
        }

        public static string Shortener(string value, int min, int max, char placeholder)
        {
            if (string.IsNullOrWhiteSpace(value))
                value = new string(placeholder, min);

            string trimmedValue = value.Trim();

            if (trimmedValue.Length < min)
                trimmedValue = trimmedValue.PadRight(min, placeholder);
            else if (trimmedValue.Length > max)
                trimmedValue = trimmedValue.Substring(0, max);

            return char.ToUpper(trimmedValue[0]) + trimmedValue.Substring(1);
        }
    }
}
