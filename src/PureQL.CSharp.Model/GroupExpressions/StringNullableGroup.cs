using OneOf;
using PureQL.CSharp.Model.Keys;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class StringNullableGroup
    : OneOfBase<
        KeyAsStringNullable,
        ParamAsStringNullable,
        LiteralAsStringNullable,
        ConcatStringNullableGroup,
        ConditionalStringNullableGroup,
        AggregateStringNullableGroup
    >
{
    public StringNullableGroup(KeyAsStringNullable value)
        : this(
            (OneOf<
                KeyAsStringNullable,
                ParamAsStringNullable,
                LiteralAsStringNullable,
                ConcatStringNullableGroup,
                ConditionalStringNullableGroup,
                AggregateStringNullableGroup
            >)
                value
        )
    { }

    public StringNullableGroup(ParamAsStringNullable value)
        : this(
            (OneOf<
                KeyAsStringNullable,
                ParamAsStringNullable,
                LiteralAsStringNullable,
                ConcatStringNullableGroup,
                ConditionalStringNullableGroup,
                AggregateStringNullableGroup
            >)
                value
        )
    { }

    public StringNullableGroup(LiteralAsStringNullable value)
        : this(
            (OneOf<
                KeyAsStringNullable,
                ParamAsStringNullable,
                LiteralAsStringNullable,
                ConcatStringNullableGroup,
                ConditionalStringNullableGroup,
                AggregateStringNullableGroup
            >)
                value
        )
    { }

    public StringNullableGroup(ConcatStringNullableGroup value)
        : this(
            (OneOf<
                KeyAsStringNullable,
                ParamAsStringNullable,
                LiteralAsStringNullable,
                ConcatStringNullableGroup,
                ConditionalStringNullableGroup,
                AggregateStringNullableGroup
            >)
                value
        )
    { }

    public StringNullableGroup(ConditionalStringNullableGroup value)
        : this(
            (OneOf<
                KeyAsStringNullable,
                ParamAsStringNullable,
                LiteralAsStringNullable,
                ConcatStringNullableGroup,
                ConditionalStringNullableGroup,
                AggregateStringNullableGroup
            >)
                value
        )
    { }

    public StringNullableGroup(AggregateStringNullableGroup value)
        : this(
            (OneOf<
                KeyAsStringNullable,
                ParamAsStringNullable,
                LiteralAsStringNullable,
                ConcatStringNullableGroup,
                ConditionalStringNullableGroup,
                AggregateStringNullableGroup
            >)
                value
        )
    { }

    private StringNullableGroup(
        OneOf<
            KeyAsStringNullable,
            ParamAsStringNullable,
            LiteralAsStringNullable,
            ConcatStringNullableGroup,
            ConditionalStringNullableGroup,
            AggregateStringNullableGroup
        > input
    )
        : base(input) { }
}
