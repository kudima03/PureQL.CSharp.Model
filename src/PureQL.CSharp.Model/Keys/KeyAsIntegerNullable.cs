using OneOf;

namespace PureQL.CSharp.Model.Keys;

public sealed class KeyAsIntegerNullable : OneOfBase<KeyInteger, KeyIntegerNullable>
{
    public KeyAsIntegerNullable(KeyInteger value)
        : this((OneOf<KeyInteger, KeyIntegerNullable>)value) { }

    public KeyAsIntegerNullable(KeyIntegerNullable value)
        : this((OneOf<KeyInteger, KeyIntegerNullable>)value) { }

    private KeyAsIntegerNullable(OneOf<KeyInteger, KeyIntegerNullable> input)
        : base(input) { }
}
