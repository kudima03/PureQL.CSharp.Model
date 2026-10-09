using OneOf;

namespace PureQL.CSharp.Model.Keys;

public sealed class KeyAsDecimalNullable
    : OneOfBase<KeyDecimal, KeyDecimalNullable, KeyInteger, KeyIntegerNullable>
{
    public KeyAsDecimalNullable(KeyDecimal value)
        : this(
            (OneOf<KeyDecimal, KeyDecimalNullable, KeyInteger, KeyIntegerNullable>)value
        )
    { }

    public KeyAsDecimalNullable(KeyDecimalNullable value)
        : this(
            (OneOf<KeyDecimal, KeyDecimalNullable, KeyInteger, KeyIntegerNullable>)value
        )
    { }

    public KeyAsDecimalNullable(KeyInteger value)
        : this(
            (OneOf<KeyDecimal, KeyDecimalNullable, KeyInteger, KeyIntegerNullable>)value
        )
    { }

    public KeyAsDecimalNullable(KeyIntegerNullable value)
        : this(
            (OneOf<KeyDecimal, KeyDecimalNullable, KeyInteger, KeyIntegerNullable>)value
        )
    { }

    private KeyAsDecimalNullable(
        OneOf<KeyDecimal, KeyDecimalNullable, KeyInteger, KeyIntegerNullable> input
    )
        : base(input) { }
}
