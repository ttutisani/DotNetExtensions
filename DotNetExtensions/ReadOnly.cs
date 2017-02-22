namespace DotNetExtensions
{
    public struct ReadOnly<T>
    {
        public ReadOnly(T value)
        {
            Value = value;
        }

        public T Value { get; }

        public static implicit operator T(ReadOnly<T> readOnly)
        {
            return readOnly.Value;
        }

        public override string ToString()
        {
            return Value?.ToString();
        }
    }

    public static class ReadOnly
    {
        public static ReadOnly<T> Value<T>(T value)
        {
            return new ReadOnly<T>(value);
        }

        public static ReadOnly<T> AsReadOnly<T>(this T value)
        {
            return new ReadOnly<T>(value);
        }
    }
}
