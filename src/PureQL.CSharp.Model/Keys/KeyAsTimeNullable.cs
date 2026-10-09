using OneOf;

namespace PureQL.CSharp.Model.Keys;

public sealed class KeyAsTimeNullable : OneOfBase<KeyTime, KeyTimeNullable>
{
    public KeyAsTimeNullable(KeyTime value)
        : this((OneOf<KeyTime, KeyTimeNullable>)value) { }

    public KeyAsTimeNullable(KeyTimeNullable value)
        : this((OneOf<KeyTime, KeyTimeNullable>)value) { }

    private KeyAsTimeNullable(OneOf<KeyTime, KeyTimeNullable> input)
        : base(input) { }
}
