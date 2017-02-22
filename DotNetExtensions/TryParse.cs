using System;

namespace DotNetExtensions
{
    public static class TryParse
    {
        public static IConvertible Convert<TConvertible>(this TConvertible convertible)
            where TConvertible: IConvertible
        {
            return convertible;
        }

        public static int ToInt(this string value, int defaultValue = 0)
        {
            int result;
            var success = int.TryParse(value, out result);
            return success ? result : defaultValue;
        }
    }
}
