using OneOf;
using PureQL.CSharp.Model.Keys;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class IntegerNullableGroup
    : OneOfBase<
        KeyAsIntegerNullable,
        ParamAsIntegerNullable,
        LiteralAsIntegerNullable,
        ArithmeticIntegerNullableGroup,
        RoundingIntegerNullableGroup,
        DateDiffDaysIntegerNullableGroup,
        ConditionalIntegerNullableGroup,
        AggregateIntegerNullableGroup
    >
{
    public IntegerNullableGroup(KeyAsIntegerNullable value)
        : this(
            (OneOf<
                KeyAsIntegerNullable,
                ParamAsIntegerNullable,
                LiteralAsIntegerNullable,
                ArithmeticIntegerNullableGroup,
                RoundingIntegerNullableGroup,
                DateDiffDaysIntegerNullableGroup,
                ConditionalIntegerNullableGroup,
                AggregateIntegerNullableGroup
            >)
                value
        )
    { }

    public IntegerNullableGroup(ParamAsIntegerNullable value)
        : this(
            (OneOf<
                KeyAsIntegerNullable,
                ParamAsIntegerNullable,
                LiteralAsIntegerNullable,
                ArithmeticIntegerNullableGroup,
                RoundingIntegerNullableGroup,
                DateDiffDaysIntegerNullableGroup,
                ConditionalIntegerNullableGroup,
                AggregateIntegerNullableGroup
            >)
                value
        )
    { }

    public IntegerNullableGroup(LiteralAsIntegerNullable value)
        : this(
            (OneOf<
                KeyAsIntegerNullable,
                ParamAsIntegerNullable,
                LiteralAsIntegerNullable,
                ArithmeticIntegerNullableGroup,
                RoundingIntegerNullableGroup,
                DateDiffDaysIntegerNullableGroup,
                ConditionalIntegerNullableGroup,
                AggregateIntegerNullableGroup
            >)
                value
        )
    { }

    public IntegerNullableGroup(ArithmeticIntegerNullableGroup value)
        : this(
            (OneOf<
                KeyAsIntegerNullable,
                ParamAsIntegerNullable,
                LiteralAsIntegerNullable,
                ArithmeticIntegerNullableGroup,
                RoundingIntegerNullableGroup,
                DateDiffDaysIntegerNullableGroup,
                ConditionalIntegerNullableGroup,
                AggregateIntegerNullableGroup
            >)
                value
        )
    { }

    public IntegerNullableGroup(RoundingIntegerNullableGroup value)
        : this(
            (OneOf<
                KeyAsIntegerNullable,
                ParamAsIntegerNullable,
                LiteralAsIntegerNullable,
                ArithmeticIntegerNullableGroup,
                RoundingIntegerNullableGroup,
                DateDiffDaysIntegerNullableGroup,
                ConditionalIntegerNullableGroup,
                AggregateIntegerNullableGroup
            >)
                value
        )
    { }

    public IntegerNullableGroup(DateDiffDaysIntegerNullableGroup value)
        : this(
            (OneOf<
                KeyAsIntegerNullable,
                ParamAsIntegerNullable,
                LiteralAsIntegerNullable,
                ArithmeticIntegerNullableGroup,
                RoundingIntegerNullableGroup,
                DateDiffDaysIntegerNullableGroup,
                ConditionalIntegerNullableGroup,
                AggregateIntegerNullableGroup
            >)
                value
        )
    { }

    public IntegerNullableGroup(ConditionalIntegerNullableGroup value)
        : this(
            (OneOf<
                KeyAsIntegerNullable,
                ParamAsIntegerNullable,
                LiteralAsIntegerNullable,
                ArithmeticIntegerNullableGroup,
                RoundingIntegerNullableGroup,
                DateDiffDaysIntegerNullableGroup,
                ConditionalIntegerNullableGroup,
                AggregateIntegerNullableGroup
            >)
                value
        )
    { }

    public IntegerNullableGroup(AggregateIntegerNullableGroup value)
        : this(
            (OneOf<
                KeyAsIntegerNullable,
                ParamAsIntegerNullable,
                LiteralAsIntegerNullable,
                ArithmeticIntegerNullableGroup,
                RoundingIntegerNullableGroup,
                DateDiffDaysIntegerNullableGroup,
                ConditionalIntegerNullableGroup,
                AggregateIntegerNullableGroup
            >)
                value
        )
    { }

    private IntegerNullableGroup(
        OneOf<
            KeyAsIntegerNullable,
            ParamAsIntegerNullable,
            LiteralAsIntegerNullable,
            ArithmeticIntegerNullableGroup,
            RoundingIntegerNullableGroup,
            DateDiffDaysIntegerNullableGroup,
            ConditionalIntegerNullableGroup,
            AggregateIntegerNullableGroup
        > input
    )
        : base(input) { }
}
