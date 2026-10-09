using OneOf;
using PureQL.CSharp.Model.Keys;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class DecimalNullableGroup
    : OneOfBase<
        KeyAsDecimalNullable,
        ParamAsDecimalNullable,
        LiteralAsDecimalNullable,
        ArithmeticDecimalNullableGroup,
        RoundingDecimalNullableGroup,
        DifferenceDecimalNullableGroup,
        ConditionalDecimalNullableGroup,
        AggregateDecimalNullableGroup
    >
{
    public DecimalNullableGroup(KeyAsDecimalNullable value)
        : this(
            (OneOf<
                KeyAsDecimalNullable,
                ParamAsDecimalNullable,
                LiteralAsDecimalNullable,
                ArithmeticDecimalNullableGroup,
                RoundingDecimalNullableGroup,
                DifferenceDecimalNullableGroup,
                ConditionalDecimalNullableGroup,
                AggregateDecimalNullableGroup
            >)
                value
        )
    { }

    public DecimalNullableGroup(ParamAsDecimalNullable value)
        : this(
            (OneOf<
                KeyAsDecimalNullable,
                ParamAsDecimalNullable,
                LiteralAsDecimalNullable,
                ArithmeticDecimalNullableGroup,
                RoundingDecimalNullableGroup,
                DifferenceDecimalNullableGroup,
                ConditionalDecimalNullableGroup,
                AggregateDecimalNullableGroup
            >)
                value
        )
    { }

    public DecimalNullableGroup(LiteralAsDecimalNullable value)
        : this(
            (OneOf<
                KeyAsDecimalNullable,
                ParamAsDecimalNullable,
                LiteralAsDecimalNullable,
                ArithmeticDecimalNullableGroup,
                RoundingDecimalNullableGroup,
                DifferenceDecimalNullableGroup,
                ConditionalDecimalNullableGroup,
                AggregateDecimalNullableGroup
            >)
                value
        )
    { }

    public DecimalNullableGroup(ArithmeticDecimalNullableGroup value)
        : this(
            (OneOf<
                KeyAsDecimalNullable,
                ParamAsDecimalNullable,
                LiteralAsDecimalNullable,
                ArithmeticDecimalNullableGroup,
                RoundingDecimalNullableGroup,
                DifferenceDecimalNullableGroup,
                ConditionalDecimalNullableGroup,
                AggregateDecimalNullableGroup
            >)
                value
        )
    { }

    public DecimalNullableGroup(RoundingDecimalNullableGroup value)
        : this(
            (OneOf<
                KeyAsDecimalNullable,
                ParamAsDecimalNullable,
                LiteralAsDecimalNullable,
                ArithmeticDecimalNullableGroup,
                RoundingDecimalNullableGroup,
                DifferenceDecimalNullableGroup,
                ConditionalDecimalNullableGroup,
                AggregateDecimalNullableGroup
            >)
                value
        )
    { }

    public DecimalNullableGroup(DifferenceDecimalNullableGroup value)
        : this(
            (OneOf<
                KeyAsDecimalNullable,
                ParamAsDecimalNullable,
                LiteralAsDecimalNullable,
                ArithmeticDecimalNullableGroup,
                RoundingDecimalNullableGroup,
                DifferenceDecimalNullableGroup,
                ConditionalDecimalNullableGroup,
                AggregateDecimalNullableGroup
            >)
                value
        )
    { }

    public DecimalNullableGroup(ConditionalDecimalNullableGroup value)
        : this(
            (OneOf<
                KeyAsDecimalNullable,
                ParamAsDecimalNullable,
                LiteralAsDecimalNullable,
                ArithmeticDecimalNullableGroup,
                RoundingDecimalNullableGroup,
                DifferenceDecimalNullableGroup,
                ConditionalDecimalNullableGroup,
                AggregateDecimalNullableGroup
            >)
                value
        )
    { }

    public DecimalNullableGroup(AggregateDecimalNullableGroup value)
        : this(
            (OneOf<
                KeyAsDecimalNullable,
                ParamAsDecimalNullable,
                LiteralAsDecimalNullable,
                ArithmeticDecimalNullableGroup,
                RoundingDecimalNullableGroup,
                DifferenceDecimalNullableGroup,
                ConditionalDecimalNullableGroup,
                AggregateDecimalNullableGroup
            >)
                value
        )
    { }

    private DecimalNullableGroup(
        OneOf<
            KeyAsDecimalNullable,
            ParamAsDecimalNullable,
            LiteralAsDecimalNullable,
            ArithmeticDecimalNullableGroup,
            RoundingDecimalNullableGroup,
            DifferenceDecimalNullableGroup,
            ConditionalDecimalNullableGroup,
            AggregateDecimalNullableGroup
        > input
    )
        : base(input) { }
}
