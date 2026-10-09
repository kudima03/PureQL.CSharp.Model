using OneOf;
using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class BooleanProjection
    : OneOfBase<
        FieldBoolean,
        ParamBoolean,
        LiteralBoolean,
        LogicalProjection,
        ComparisonProjection,
        ConditionalBooleanProjection,
        AggregateBooleanProjection
    >
{
    public BooleanProjection(FieldBoolean value)
        : this(
            (OneOf<
                FieldBoolean,
                ParamBoolean,
                LiteralBoolean,
                LogicalProjection,
                ComparisonProjection,
                ConditionalBooleanProjection,
                AggregateBooleanProjection
            >)
                value
        )
    { }

    public BooleanProjection(ParamBoolean value)
        : this(
            (OneOf<
                FieldBoolean,
                ParamBoolean,
                LiteralBoolean,
                LogicalProjection,
                ComparisonProjection,
                ConditionalBooleanProjection,
                AggregateBooleanProjection
            >)
                value
        )
    { }

    public BooleanProjection(LiteralBoolean value)
        : this(
            (OneOf<
                FieldBoolean,
                ParamBoolean,
                LiteralBoolean,
                LogicalProjection,
                ComparisonProjection,
                ConditionalBooleanProjection,
                AggregateBooleanProjection
            >)
                value
        )
    { }

    public BooleanProjection(LogicalProjection value)
        : this(
            (OneOf<
                FieldBoolean,
                ParamBoolean,
                LiteralBoolean,
                LogicalProjection,
                ComparisonProjection,
                ConditionalBooleanProjection,
                AggregateBooleanProjection
            >)
                value
        )
    { }

    public BooleanProjection(ComparisonProjection value)
        : this(
            (OneOf<
                FieldBoolean,
                ParamBoolean,
                LiteralBoolean,
                LogicalProjection,
                ComparisonProjection,
                ConditionalBooleanProjection,
                AggregateBooleanProjection
            >)
                value
        )
    { }

    public BooleanProjection(ConditionalBooleanProjection value)
        : this(
            (OneOf<
                FieldBoolean,
                ParamBoolean,
                LiteralBoolean,
                LogicalProjection,
                ComparisonProjection,
                ConditionalBooleanProjection,
                AggregateBooleanProjection
            >)
                value
        )
    { }

    public BooleanProjection(AggregateBooleanProjection value)
        : this(
            (OneOf<
                FieldBoolean,
                ParamBoolean,
                LiteralBoolean,
                LogicalProjection,
                ComparisonProjection,
                ConditionalBooleanProjection,
                AggregateBooleanProjection
            >)
                value
        )
    { }

    private BooleanProjection(
        OneOf<
            FieldBoolean,
            ParamBoolean,
            LiteralBoolean,
            LogicalProjection,
            ComparisonProjection,
            ConditionalBooleanProjection,
            AggregateBooleanProjection
        > input
    )
        : base(input) { }
}
