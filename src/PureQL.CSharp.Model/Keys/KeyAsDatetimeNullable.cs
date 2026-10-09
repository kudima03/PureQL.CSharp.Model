using OneOf;

namespace PureQL.CSharp.Model.Keys;

public sealed class KeyAsDatetimeNullable : OneOfBase<KeyDatetime, KeyDatetimeNullable>
{
    public KeyAsDatetimeNullable(KeyDatetime value)
        : this((OneOf<KeyDatetime, KeyDatetimeNullable>)value) { }

    public KeyAsDatetimeNullable(KeyDatetimeNullable value)
        : this((OneOf<KeyDatetime, KeyDatetimeNullable>)value) { }

    private KeyAsDatetimeNullable(OneOf<KeyDatetime, KeyDatetimeNullable> input)
        : base(input) { }
}
