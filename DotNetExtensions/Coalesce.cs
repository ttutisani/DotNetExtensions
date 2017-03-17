namespace DotNetExtensions
{
    public static class Coalesce
    {
        public static string IfNull(this string value, string alternative)
        {
            return !value.IsNull()
                ? value
                : alternative;
        }

        public static string IfNullOrEmpty(this string value, string alternative)
        {
            return !value.IsNullOrEmpty()
                ? value
                : alternative;
        }

        public static string IfNullOrWhiteSpace(this string value, string alternative)
        {
            return !value.IsNullOrWhiteSpace()
                ? value
                : alternative;
        }
    }
}
