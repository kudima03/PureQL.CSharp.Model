using OneOf;
using PureQL.CSharp.Model.Keys;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class ExactUuidNullableGroup
    : OneOfBase<
        KeyUuidNullable,
        ParamUuidNullable,
        LiteralUuidNullable,
        ConditionalUuidNullableGroup,
        AggregateUuidNullableGroup
    >
{
    public ExactUuidNullableGroup(KeyUuidNullable value)
        : this(
            (OneOf<
                KeyUuidNullable,
                ParamUuidNullable,
                LiteralUuidNullable,
                ConditionalUuidNullableGroup,
                AggregateUuidNullableGroup
            >)
                value
        )
    { }

    public ExactUuidNullableGroup(ParamUuidNullable value)
        : this(
            (OneOf<
                KeyUuidNullable,
                ParamUuidNullable,
                LiteralUuidNullable,
                ConditionalUuidNullableGroup,
                AggregateUuidNullableGroup
            >)
                value
        )
    { }

    public ExactUuidNullableGroup(LiteralUuidNullable value)
        : this(
            (OneOf<
                KeyUuidNullable,
                ParamUuidNullable,
                LiteralUuidNullable,
                ConditionalUuidNullableGroup,
                AggregateUuidNullableGroup
            >)
                value
        )
    { }

    public ExactUuidNullableGroup(ConditionalUuidNullableGroup value)
        : this(
            (OneOf<
                KeyUuidNullable,
                ParamUuidNullable,
                LiteralUuidNullable,
                ConditionalUuidNullableGroup,
                AggregateUuidNullableGroup
            >)
                value
        )
    { }

    public ExactUuidNullableGroup(AggregateUuidNullableGroup value)
        : this(
            (OneOf<
                KeyUuidNullable,
                ParamUuidNullable,
                LiteralUuidNullable,
                ConditionalUuidNullableGroup,
                AggregateUuidNullableGroup
            >)
                value
        )
    { }

    private ExactUuidNullableGroup(
        OneOf<
            KeyUuidNullable,
            ParamUuidNullable,
            LiteralUuidNullable,
            ConditionalUuidNullableGroup,
            AggregateUuidNullableGroup
        > input
    )
        : base(input) { }
}
