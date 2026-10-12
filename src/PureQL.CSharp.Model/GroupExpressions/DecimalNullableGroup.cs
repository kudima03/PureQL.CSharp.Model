using OneOf;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class DecimalNullableGroup
    : OneOfBase<
        ExactDecimalGroup,
        ExactDecimalNullableGroup,
        IntegerGroup,
        ExactIntegerNullableGroup
    >
{
    public DecimalNullableGroup(ExactDecimalGroup value)
        : this(
            (OneOf<
                ExactDecimalGroup,
                ExactDecimalNullableGroup,
                IntegerGroup,
                ExactIntegerNullableGroup
            >)
                value
        )
    { }

    public DecimalNullableGroup(ExactDecimalNullableGroup value)
        : this(
            (OneOf<
                ExactDecimalGroup,
                ExactDecimalNullableGroup,
                IntegerGroup,
                ExactIntegerNullableGroup
            >)
                value
        )
    { }

    public DecimalNullableGroup(IntegerGroup value)
        : this(
            (OneOf<
                ExactDecimalGroup,
                ExactDecimalNullableGroup,
                IntegerGroup,
                ExactIntegerNullableGroup
            >)
                value
        )
    { }

    public DecimalNullableGroup(ExactIntegerNullableGroup value)
        : this(
            (OneOf<
                ExactDecimalGroup,
                ExactDecimalNullableGroup,
                IntegerGroup,
                ExactIntegerNullableGroup
            >)
                value
        )
    { }

    private DecimalNullableGroup(
        OneOf<
            ExactDecimalGroup,
            ExactDecimalNullableGroup,
            IntegerGroup,
            ExactIntegerNullableGroup
        > input
    )
        : base(input) { }
}
