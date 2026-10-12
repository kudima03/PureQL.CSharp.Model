using OneOf;
using PureQL.CSharp.Model.Keys;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class ExactBooleanNullableGroup
    : OneOfBase<
        KeyBooleanNullable,
        ParamBooleanNullable,
        LiteralBooleanNullable,
        ConditionalBooleanNullableGroup,
        AggregateBooleanNullableGroup
    >
{
    public ExactBooleanNullableGroup(KeyBooleanNullable value)
        : this(
            (OneOf<
                KeyBooleanNullable,
                ParamBooleanNullable,
                LiteralBooleanNullable,
                ConditionalBooleanNullableGroup,
                AggregateBooleanNullableGroup
            >)
                value
        )
    { }

    public ExactBooleanNullableGroup(ParamBooleanNullable value)
        : this(
            (OneOf<
                KeyBooleanNullable,
                ParamBooleanNullable,
                LiteralBooleanNullable,
                ConditionalBooleanNullableGroup,
                AggregateBooleanNullableGroup
            >)
                value
        )
    { }

    public ExactBooleanNullableGroup(LiteralBooleanNullable value)
        : this(
            (OneOf<
                KeyBooleanNullable,
                ParamBooleanNullable,
                LiteralBooleanNullable,
                ConditionalBooleanNullableGroup,
                AggregateBooleanNullableGroup
            >)
                value
        )
    { }

    public ExactBooleanNullableGroup(ConditionalBooleanNullableGroup value)
        : this(
            (OneOf<
                KeyBooleanNullable,
                ParamBooleanNullable,
                LiteralBooleanNullable,
                ConditionalBooleanNullableGroup,
                AggregateBooleanNullableGroup
            >)
                value
        )
    { }

    public ExactBooleanNullableGroup(AggregateBooleanNullableGroup value)
        : this(
            (OneOf<
                KeyBooleanNullable,
                ParamBooleanNullable,
                LiteralBooleanNullable,
                ConditionalBooleanNullableGroup,
                AggregateBooleanNullableGroup
            >)
                value
        )
    { }

    private ExactBooleanNullableGroup(
        OneOf<
            KeyBooleanNullable,
            ParamBooleanNullable,
            LiteralBooleanNullable,
            ConditionalBooleanNullableGroup,
            AggregateBooleanNullableGroup
        > input
    )
        : base(input) { }
}
