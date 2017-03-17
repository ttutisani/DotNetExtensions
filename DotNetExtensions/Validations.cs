namespace DotNetExtensions
{
    public static class Validations
    {
        public static bool IsNull<TValue>(this TValue value)
            where TValue : class
        {
            return value == null;
        }

        public static bool IsNullOrEmpty(this string value)
        {
            return string.IsNullOrEmpty(value);
        }

        public static bool IsNullOrWhiteSpace(this string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }
    }
}
