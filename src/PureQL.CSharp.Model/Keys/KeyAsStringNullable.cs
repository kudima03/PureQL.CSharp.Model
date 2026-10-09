using OneOf;

namespace PureQL.CSharp.Model.Keys;

public sealed class KeyAsStringNullable : OneOfBase<KeyString, KeyStringNullable>
{
    public KeyAsStringNullable(KeyString value)
        : this((OneOf<KeyString, KeyStringNullable>)value) { }

    public KeyAsStringNullable(KeyStringNullable value)
        : this((OneOf<KeyString, KeyStringNullable>)value) { }

    private KeyAsStringNullable(OneOf<KeyString, KeyStringNullable> input)
        : base(input) { }
}
