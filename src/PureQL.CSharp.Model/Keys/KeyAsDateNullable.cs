using OneOf;

namespace PureQL.CSharp.Model.Keys;

public sealed class KeyAsDateNullable : OneOfBase<KeyDate, KeyDateNullable>
{
    public KeyAsDateNullable(KeyDate value)
        : this((OneOf<KeyDate, KeyDateNullable>)value) { }

    public KeyAsDateNullable(KeyDateNullable value)
        : this((OneOf<KeyDate, KeyDateNullable>)value) { }

    private KeyAsDateNullable(OneOf<KeyDate, KeyDateNullable> input)
        : base(input) { }
}
