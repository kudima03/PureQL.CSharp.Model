using OneOf;
using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class BooleanNullableProjection
    : OneOfBase<
        FieldAsBooleanNullable,
        ParamAsBooleanNullable,
        LiteralAsBooleanNullable,
        LogicalProjection,
        ComparisonProjection,
        ConditionalBooleanNullableProjection,
        AggregateBooleanProjection
    >
{
    public BooleanNullableProjection(FieldAsBooleanNullable value)
        : this(
            (OneOf<
                FieldAsBooleanNullable,
                ParamAsBooleanNullable,
                LiteralAsBooleanNullable,
                LogicalProjection,
                ComparisonProjection,
                ConditionalBooleanNullableProjection,
                AggregateBooleanProjection
            >)
                value
        )
    { }

    public BooleanNullableProjection(ParamAsBooleanNullable value)
        : this(
            (OneOf<
                FieldAsBooleanNullable,
                ParamAsBooleanNullable,
                LiteralAsBooleanNullable,
                LogicalProjection,
                ComparisonProjection,
                ConditionalBooleanNullableProjection,
                AggregateBooleanProjection
            >)
                value
        )
    { }

    public BooleanNullableProjection(LiteralAsBooleanNullable value)
        : this(
            (OneOf<
                FieldAsBooleanNullable,
                ParamAsBooleanNullable,
                LiteralAsBooleanNullable,
                LogicalProjection,
                ComparisonProjection,
                ConditionalBooleanNullableProjection,
                AggregateBooleanProjection
            >)
                value
        )
    { }

    public BooleanNullableProjection(LogicalProjection value)
        : this(
            (OneOf<
                FieldAsBooleanNullable,
                ParamAsBooleanNullable,
                LiteralAsBooleanNullable,
                LogicalProjection,
                ComparisonProjection,
                ConditionalBooleanNullableProjection,
                AggregateBooleanProjection
            >)
                value
        )
    { }

    public BooleanNullableProjection(ComparisonProjection value)
        : this(
            (OneOf<
                FieldAsBooleanNullable,
                ParamAsBooleanNullable,
                LiteralAsBooleanNullable,
                LogicalProjection,
                ComparisonProjection,
                ConditionalBooleanNullableProjection,
                AggregateBooleanProjection
            >)
                value
        )
    { }

    public BooleanNullableProjection(ConditionalBooleanNullableProjection value)
        : this(
            (OneOf<
                FieldAsBooleanNullable,
                ParamAsBooleanNullable,
                LiteralAsBooleanNullable,
                LogicalProjection,
                ComparisonProjection,
                ConditionalBooleanNullableProjection,
                AggregateBooleanProjection
            >)
                value
        )
    { }

    public BooleanNullableProjection(AggregateBooleanProjection value)
        : this(
            (OneOf<
                FieldAsBooleanNullable,
                ParamAsBooleanNullable,
                LiteralAsBooleanNullable,
                LogicalProjection,
                ComparisonProjection,
                ConditionalBooleanNullableProjection,
                AggregateBooleanProjection
            >)
                value
        )
    { }

    private BooleanNullableProjection(
        OneOf<
            FieldAsBooleanNullable,
            ParamAsBooleanNullable,
            LiteralAsBooleanNullable,
            LogicalProjection,
            ComparisonProjection,
            ConditionalBooleanNullableProjection,
            AggregateBooleanProjection
        > input
    )
        : base(input) { }
}
