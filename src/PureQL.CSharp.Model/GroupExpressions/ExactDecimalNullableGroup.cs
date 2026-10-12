using OneOf;
using PureQL.CSharp.Model.Keys;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class ExactDecimalNullableGroup
    : OneOfBase<
        KeyDecimalNullable,
        ParamDecimalNullable,
        LiteralDecimalNullable,
        ArithmeticDecimalNullableGroup,
        RoundDecimalNullableGroup,
        DifferenceDecimalNullableGroup,
        ConditionalDecimalNullableGroup,
        AggregateDecimalNullableGroup
    >
{
    public ExactDecimalNullableGroup(KeyDecimalNullable value)
        : this(
            (OneOf<
                KeyDecimalNullable,
                ParamDecimalNullable,
                LiteralDecimalNullable,
                ArithmeticDecimalNullableGroup,
                RoundDecimalNullableGroup,
                DifferenceDecimalNullableGroup,
                ConditionalDecimalNullableGroup,
                AggregateDecimalNullableGroup
            >)
                value
        )
    { }

    public ExactDecimalNullableGroup(ParamDecimalNullable value)
        : this(
            (OneOf<
                KeyDecimalNullable,
                ParamDecimalNullable,
                LiteralDecimalNullable,
                ArithmeticDecimalNullableGroup,
                RoundDecimalNullableGroup,
                DifferenceDecimalNullableGroup,
                ConditionalDecimalNullableGroup,
                AggregateDecimalNullableGroup
            >)
                value
        )
    { }

    public ExactDecimalNullableGroup(LiteralDecimalNullable value)
        : this(
            (OneOf<
                KeyDecimalNullable,
                ParamDecimalNullable,
                LiteralDecimalNullable,
                ArithmeticDecimalNullableGroup,
                RoundDecimalNullableGroup,
                DifferenceDecimalNullableGroup,
                ConditionalDecimalNullableGroup,
                AggregateDecimalNullableGroup
            >)
                value
        )
    { }

    public ExactDecimalNullableGroup(ArithmeticDecimalNullableGroup value)
        : this(
            (OneOf<
                KeyDecimalNullable,
                ParamDecimalNullable,
                LiteralDecimalNullable,
                ArithmeticDecimalNullableGroup,
                RoundDecimalNullableGroup,
                DifferenceDecimalNullableGroup,
                ConditionalDecimalNullableGroup,
                AggregateDecimalNullableGroup
            >)
                value
        )
    { }

    public ExactDecimalNullableGroup(RoundDecimalNullableGroup value)
        : this(
            (OneOf<
                KeyDecimalNullable,
                ParamDecimalNullable,
                LiteralDecimalNullable,
                ArithmeticDecimalNullableGroup,
                RoundDecimalNullableGroup,
                DifferenceDecimalNullableGroup,
                ConditionalDecimalNullableGroup,
                AggregateDecimalNullableGroup
            >)
                value
        )
    { }

    public ExactDecimalNullableGroup(DifferenceDecimalNullableGroup value)
        : this(
            (OneOf<
                KeyDecimalNullable,
                ParamDecimalNullable,
                LiteralDecimalNullable,
                ArithmeticDecimalNullableGroup,
                RoundDecimalNullableGroup,
                DifferenceDecimalNullableGroup,
                ConditionalDecimalNullableGroup,
                AggregateDecimalNullableGroup
            >)
                value
        )
    { }

    public ExactDecimalNullableGroup(ConditionalDecimalNullableGroup value)
        : this(
            (OneOf<
                KeyDecimalNullable,
                ParamDecimalNullable,
                LiteralDecimalNullable,
                ArithmeticDecimalNullableGroup,
                RoundDecimalNullableGroup,
                DifferenceDecimalNullableGroup,
                ConditionalDecimalNullableGroup,
                AggregateDecimalNullableGroup
            >)
                value
        )
    { }

    public ExactDecimalNullableGroup(AggregateDecimalNullableGroup value)
        : this(
            (OneOf<
                KeyDecimalNullable,
                ParamDecimalNullable,
                LiteralDecimalNullable,
                ArithmeticDecimalNullableGroup,
                RoundDecimalNullableGroup,
                DifferenceDecimalNullableGroup,
                ConditionalDecimalNullableGroup,
                AggregateDecimalNullableGroup
            >)
                value
        )
    { }

    private ExactDecimalNullableGroup(
        OneOf<
            KeyDecimalNullable,
            ParamDecimalNullable,
            LiteralDecimalNullable,
            ArithmeticDecimalNullableGroup,
            RoundDecimalNullableGroup,
            DifferenceDecimalNullableGroup,
            ConditionalDecimalNullableGroup,
            AggregateDecimalNullableGroup
        > input
    )
        : base(input) { }
}
