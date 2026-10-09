using OneOf;
using PureQL.CSharp.Model.Keys;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class BooleanGroup
    : OneOfBase<
        KeyBoolean,
        ParamBoolean,
        LiteralBoolean,
        LogicalGroup,
        ComparisonGroup,
        ConditionalBooleanGroup,
        AggregateBooleanGroup
    >
{
    public BooleanGroup(KeyBoolean value)
        : this(
            (OneOf<
                KeyBoolean,
                ParamBoolean,
                LiteralBoolean,
                LogicalGroup,
                ComparisonGroup,
                ConditionalBooleanGroup,
                AggregateBooleanGroup
            >)
                value
        )
    { }

    public BooleanGroup(ParamBoolean value)
        : this(
            (OneOf<
                KeyBoolean,
                ParamBoolean,
                LiteralBoolean,
                LogicalGroup,
                ComparisonGroup,
                ConditionalBooleanGroup,
                AggregateBooleanGroup
            >)
                value
        )
    { }

    public BooleanGroup(LiteralBoolean value)
        : this(
            (OneOf<
                KeyBoolean,
                ParamBoolean,
                LiteralBoolean,
                LogicalGroup,
                ComparisonGroup,
                ConditionalBooleanGroup,
                AggregateBooleanGroup
            >)
                value
        )
    { }

    public BooleanGroup(LogicalGroup value)
        : this(
            (OneOf<
                KeyBoolean,
                ParamBoolean,
                LiteralBoolean,
                LogicalGroup,
                ComparisonGroup,
                ConditionalBooleanGroup,
                AggregateBooleanGroup
            >)
                value
        )
    { }

    public BooleanGroup(ComparisonGroup value)
        : this(
            (OneOf<
                KeyBoolean,
                ParamBoolean,
                LiteralBoolean,
                LogicalGroup,
                ComparisonGroup,
                ConditionalBooleanGroup,
                AggregateBooleanGroup
            >)
                value
        )
    { }

    public BooleanGroup(ConditionalBooleanGroup value)
        : this(
            (OneOf<
                KeyBoolean,
                ParamBoolean,
                LiteralBoolean,
                LogicalGroup,
                ComparisonGroup,
                ConditionalBooleanGroup,
                AggregateBooleanGroup
            >)
                value
        )
    { }

    public BooleanGroup(AggregateBooleanGroup value)
        : this(
            (OneOf<
                KeyBoolean,
                ParamBoolean,
                LiteralBoolean,
                LogicalGroup,
                ComparisonGroup,
                ConditionalBooleanGroup,
                AggregateBooleanGroup
            >)
                value
        )
    { }

    private BooleanGroup(
        OneOf<
            KeyBoolean,
            ParamBoolean,
            LiteralBoolean,
            LogicalGroup,
            ComparisonGroup,
            ConditionalBooleanGroup,
            AggregateBooleanGroup
        > input
    )
        : base(input) { }
}
