using OneOf;

namespace PureQL.CSharp.Model.Parameters;

public sealed class ParamAsDecimalNullable
    : OneOfBase<ParamDecimal, ParamDecimalNullable, ParamInteger, ParamIntegerNullable>
{
    public ParamAsDecimalNullable(ParamDecimal value)
        : this(
            (OneOf<
                ParamDecimal,
                ParamDecimalNullable,
                ParamInteger,
                ParamIntegerNullable
            >)
                value
        )
    { }

    public ParamAsDecimalNullable(ParamDecimalNullable value)
        : this(
            (OneOf<
                ParamDecimal,
                ParamDecimalNullable,
                ParamInteger,
                ParamIntegerNullable
            >)
                value
        )
    { }

    public ParamAsDecimalNullable(ParamInteger value)
        : this(
            (OneOf<
                ParamDecimal,
                ParamDecimalNullable,
                ParamInteger,
                ParamIntegerNullable
            >)
                value
        )
    { }

    public ParamAsDecimalNullable(ParamIntegerNullable value)
        : this(
            (OneOf<
                ParamDecimal,
                ParamDecimalNullable,
                ParamInteger,
                ParamIntegerNullable
            >)
                value
        )
    { }

    private ParamAsDecimalNullable(
        OneOf<
            ParamDecimal,
            ParamDecimalNullable,
            ParamInteger,
            ParamIntegerNullable
        > input
    )
        : base(input) { }
}
