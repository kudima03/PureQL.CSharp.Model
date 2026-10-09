using OneOf;

namespace PureQL.CSharp.Model.Keys;

public sealed class KeyAsBooleanNullable : OneOfBase<KeyBoolean, KeyBooleanNullable>
{
    public KeyAsBooleanNullable(KeyBoolean value)
        : this((OneOf<KeyBoolean, KeyBooleanNullable>)value) { }

    public KeyAsBooleanNullable(KeyBooleanNullable value)
        : this((OneOf<KeyBoolean, KeyBooleanNullable>)value) { }

    private KeyAsBooleanNullable(OneOf<KeyBoolean, KeyBooleanNullable> input)
        : base(input) { }
}
