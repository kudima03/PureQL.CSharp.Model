using OneOf;
using PureQL.CSharp.Model.Keys;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class ExactStringNullableGroup
    : OneOfBase<
        KeyStringNullable,
        ParamStringNullable,
        LiteralStringNullable,
        ConcatStringNullableGroup,
        ConditionalStringNullableGroup,
        AggregateStringNullableGroup
    >
{
    public ExactStringNullableGroup(KeyStringNullable value)
        : this(
            (OneOf<
                KeyStringNullable,
                ParamStringNullable,
                LiteralStringNullable,
                ConcatStringNullableGroup,
                ConditionalStringNullableGroup,
                AggregateStringNullableGroup
            >)
                value
        )
    { }

    public ExactStringNullableGroup(ParamStringNullable value)
        : this(
            (OneOf<
                KeyStringNullable,
                ParamStringNullable,
                LiteralStringNullable,
                ConcatStringNullableGroup,
                ConditionalStringNullableGroup,
                AggregateStringNullableGroup
            >)
                value
        )
    { }

    public ExactStringNullableGroup(LiteralStringNullable value)
        : this(
            (OneOf<
                KeyStringNullable,
                ParamStringNullable,
                LiteralStringNullable,
                ConcatStringNullableGroup,
                ConditionalStringNullableGroup,
                AggregateStringNullableGroup
            >)
                value
        )
    { }

    public ExactStringNullableGroup(ConcatStringNullableGroup value)
        : this(
            (OneOf<
                KeyStringNullable,
                ParamStringNullable,
                LiteralStringNullable,
                ConcatStringNullableGroup,
                ConditionalStringNullableGroup,
                AggregateStringNullableGroup
            >)
                value
        )
    { }

    public ExactStringNullableGroup(ConditionalStringNullableGroup value)
        : this(
            (OneOf<
                KeyStringNullable,
                ParamStringNullable,
                LiteralStringNullable,
                ConcatStringNullableGroup,
                ConditionalStringNullableGroup,
                AggregateStringNullableGroup
            >)
                value
        )
    { }

    public ExactStringNullableGroup(AggregateStringNullableGroup value)
        : this(
            (OneOf<
                KeyStringNullable,
                ParamStringNullable,
                LiteralStringNullable,
                ConcatStringNullableGroup,
                ConditionalStringNullableGroup,
                AggregateStringNullableGroup
            >)
                value
        )
    { }

    private ExactStringNullableGroup(
        OneOf<
            KeyStringNullable,
            ParamStringNullable,
            LiteralStringNullable,
            ConcatStringNullableGroup,
            ConditionalStringNullableGroup,
            AggregateStringNullableGroup
        > input
    )
        : base(input) { }
}
