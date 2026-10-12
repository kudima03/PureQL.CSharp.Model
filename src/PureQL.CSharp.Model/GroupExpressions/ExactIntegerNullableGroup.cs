using OneOf;
using PureQL.CSharp.Model.Keys;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class ExactIntegerNullableGroup
    : OneOfBase<
        KeyIntegerNullable,
        ParamIntegerNullable,
        LiteralIntegerNullable,
        ArithmeticIntegerNullableGroup,
        RoundingIntegerNullableGroup,
        DateDiffDaysIntegerNullableGroup,
        ConditionalIntegerNullableGroup,
        AggregateIntegerNullableGroup
    >
{
    public ExactIntegerNullableGroup(KeyIntegerNullable value)
        : this(
            (OneOf<
                KeyIntegerNullable,
                ParamIntegerNullable,
                LiteralIntegerNullable,
                ArithmeticIntegerNullableGroup,
                RoundingIntegerNullableGroup,
                DateDiffDaysIntegerNullableGroup,
                ConditionalIntegerNullableGroup,
                AggregateIntegerNullableGroup
            >)
                value
        )
    { }

    public ExactIntegerNullableGroup(ParamIntegerNullable value)
        : this(
            (OneOf<
                KeyIntegerNullable,
                ParamIntegerNullable,
                LiteralIntegerNullable,
                ArithmeticIntegerNullableGroup,
                RoundingIntegerNullableGroup,
                DateDiffDaysIntegerNullableGroup,
                ConditionalIntegerNullableGroup,
                AggregateIntegerNullableGroup
            >)
                value
        )
    { }

    public ExactIntegerNullableGroup(LiteralIntegerNullable value)
        : this(
            (OneOf<
                KeyIntegerNullable,
                ParamIntegerNullable,
                LiteralIntegerNullable,
                ArithmeticIntegerNullableGroup,
                RoundingIntegerNullableGroup,
                DateDiffDaysIntegerNullableGroup,
                ConditionalIntegerNullableGroup,
                AggregateIntegerNullableGroup
            >)
                value
        )
    { }

    public ExactIntegerNullableGroup(ArithmeticIntegerNullableGroup value)
        : this(
            (OneOf<
                KeyIntegerNullable,
                ParamIntegerNullable,
                LiteralIntegerNullable,
                ArithmeticIntegerNullableGroup,
                RoundingIntegerNullableGroup,
                DateDiffDaysIntegerNullableGroup,
                ConditionalIntegerNullableGroup,
                AggregateIntegerNullableGroup
            >)
                value
        )
    { }

    public ExactIntegerNullableGroup(RoundingIntegerNullableGroup value)
        : this(
            (OneOf<
                KeyIntegerNullable,
                ParamIntegerNullable,
                LiteralIntegerNullable,
                ArithmeticIntegerNullableGroup,
                RoundingIntegerNullableGroup,
                DateDiffDaysIntegerNullableGroup,
                ConditionalIntegerNullableGroup,
                AggregateIntegerNullableGroup
            >)
                value
        )
    { }

    public ExactIntegerNullableGroup(DateDiffDaysIntegerNullableGroup value)
        : this(
            (OneOf<
                KeyIntegerNullable,
                ParamIntegerNullable,
                LiteralIntegerNullable,
                ArithmeticIntegerNullableGroup,
                RoundingIntegerNullableGroup,
                DateDiffDaysIntegerNullableGroup,
                ConditionalIntegerNullableGroup,
                AggregateIntegerNullableGroup
            >)
                value
        )
    { }

    public ExactIntegerNullableGroup(ConditionalIntegerNullableGroup value)
        : this(
            (OneOf<
                KeyIntegerNullable,
                ParamIntegerNullable,
                LiteralIntegerNullable,
                ArithmeticIntegerNullableGroup,
                RoundingIntegerNullableGroup,
                DateDiffDaysIntegerNullableGroup,
                ConditionalIntegerNullableGroup,
                AggregateIntegerNullableGroup
            >)
                value
        )
    { }

    public ExactIntegerNullableGroup(AggregateIntegerNullableGroup value)
        : this(
            (OneOf<
                KeyIntegerNullable,
                ParamIntegerNullable,
                LiteralIntegerNullable,
                ArithmeticIntegerNullableGroup,
                RoundingIntegerNullableGroup,
                DateDiffDaysIntegerNullableGroup,
                ConditionalIntegerNullableGroup,
                AggregateIntegerNullableGroup
            >)
                value
        )
    { }

    private ExactIntegerNullableGroup(
        OneOf<
            KeyIntegerNullable,
            ParamIntegerNullable,
            LiteralIntegerNullable,
            ArithmeticIntegerNullableGroup,
            RoundingIntegerNullableGroup,
            DateDiffDaysIntegerNullableGroup,
            ConditionalIntegerNullableGroup,
            AggregateIntegerNullableGroup
        > input
    )
        : base(input) { }
}
