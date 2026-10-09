using OneOf;

namespace PureQL.CSharp.Model.Fields;

public sealed class FieldAsDecimalNullable
    : OneOfBase<FieldDecimal, FieldDecimalNullable, FieldInteger, FieldIntegerNullable>
{
    public FieldAsDecimalNullable(FieldDecimal value)
        : this(
            (OneOf<
                FieldDecimal,
                FieldDecimalNullable,
                FieldInteger,
                FieldIntegerNullable
            >)
                value
        )
    { }

    public FieldAsDecimalNullable(FieldDecimalNullable value)
        : this(
            (OneOf<
                FieldDecimal,
                FieldDecimalNullable,
                FieldInteger,
                FieldIntegerNullable
            >)
                value
        )
    { }

    public FieldAsDecimalNullable(FieldInteger value)
        : this(
            (OneOf<
                FieldDecimal,
                FieldDecimalNullable,
                FieldInteger,
                FieldIntegerNullable
            >)
                value
        )
    { }

    public FieldAsDecimalNullable(FieldIntegerNullable value)
        : this(
            (OneOf<
                FieldDecimal,
                FieldDecimalNullable,
                FieldInteger,
                FieldIntegerNullable
            >)
                value
        )
    { }

    private FieldAsDecimalNullable(
        OneOf<
            FieldDecimal,
            FieldDecimalNullable,
            FieldInteger,
            FieldIntegerNullable
        > input
    )
        : base(input) { }
}
