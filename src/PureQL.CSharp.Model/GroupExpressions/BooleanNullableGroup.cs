using OneOf;
using PureQL.CSharp.Model.Keys;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class BooleanNullableGroup
    : OneOfBase<
        KeyAsBooleanNullable,
        ParamAsBooleanNullable,
        LiteralAsBooleanNullable,
        LogicalGroup,
        ComparisonGroup,
        ConditionalBooleanNullableGroup,
        AggregateBooleanGroup
    >
{
    public BooleanNullableGroup(KeyAsBooleanNullable value)
        : this(
            (OneOf<
                KeyAsBooleanNullable,
                ParamAsBooleanNullable,
                LiteralAsBooleanNullable,
                LogicalGroup,
                ComparisonGroup,
                ConditionalBooleanNullableGroup,
                AggregateBooleanGroup
            >)
                value
        )
    { }

    public BooleanNullableGroup(ParamAsBooleanNullable value)
        : this(
            (OneOf<
                KeyAsBooleanNullable,
                ParamAsBooleanNullable,
                LiteralAsBooleanNullable,
                LogicalGroup,
                ComparisonGroup,
                ConditionalBooleanNullableGroup,
                AggregateBooleanGroup
            >)
                value
        )
    { }

    public BooleanNullableGroup(LiteralAsBooleanNullable value)
        : this(
            (OneOf<
                KeyAsBooleanNullable,
                ParamAsBooleanNullable,
                LiteralAsBooleanNullable,
                LogicalGroup,
                ComparisonGroup,
                ConditionalBooleanNullableGroup,
                AggregateBooleanGroup
            >)
                value
        )
    { }

    public BooleanNullableGroup(LogicalGroup value)
        : this(
            (OneOf<
                KeyAsBooleanNullable,
                ParamAsBooleanNullable,
                LiteralAsBooleanNullable,
                LogicalGroup,
                ComparisonGroup,
                ConditionalBooleanNullableGroup,
                AggregateBooleanGroup
            >)
                value
        )
    { }

    public BooleanNullableGroup(ComparisonGroup value)
        : this(
            (OneOf<
                KeyAsBooleanNullable,
                ParamAsBooleanNullable,
                LiteralAsBooleanNullable,
                LogicalGroup,
                ComparisonGroup,
                ConditionalBooleanNullableGroup,
                AggregateBooleanGroup
            >)
                value
        )
    { }

    public BooleanNullableGroup(ConditionalBooleanNullableGroup value)
        : this(
            (OneOf<
                KeyAsBooleanNullable,
                ParamAsBooleanNullable,
                LiteralAsBooleanNullable,
                LogicalGroup,
                ComparisonGroup,
                ConditionalBooleanNullableGroup,
                AggregateBooleanGroup
            >)
                value
        )
    { }

    public BooleanNullableGroup(AggregateBooleanGroup value)
        : this(
            (OneOf<
                KeyAsBooleanNullable,
                ParamAsBooleanNullable,
                LiteralAsBooleanNullable,
                LogicalGroup,
                ComparisonGroup,
                ConditionalBooleanNullableGroup,
                AggregateBooleanGroup
            >)
                value
        )
    { }

    private BooleanNullableGroup(
        OneOf<
            KeyAsBooleanNullable,
            ParamAsBooleanNullable,
            LiteralAsBooleanNullable,
            LogicalGroup,
            ComparisonGroup,
            ConditionalBooleanNullableGroup,
            AggregateBooleanGroup
        > input
    )
        : base(input) { }
}
