using OneOf;
using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed class BooleanNullableRow
    : OneOfBase<
        FieldAsBooleanNullable,
        ParamAsBooleanNullable,
        LiteralAsBooleanNullable,
        LogicalRow,
        ComparisonRow,
        ConditionalBooleanNullableRow
    >
{
    public BooleanNullableRow(FieldAsBooleanNullable value)
        : this(
            (OneOf<
                FieldAsBooleanNullable,
                ParamAsBooleanNullable,
                LiteralAsBooleanNullable,
                LogicalRow,
                ComparisonRow,
                ConditionalBooleanNullableRow
            >)
                value
        )
    { }

    public BooleanNullableRow(ParamAsBooleanNullable value)
        : this(
            (OneOf<
                FieldAsBooleanNullable,
                ParamAsBooleanNullable,
                LiteralAsBooleanNullable,
                LogicalRow,
                ComparisonRow,
                ConditionalBooleanNullableRow
            >)
                value
        )
    { }

    public BooleanNullableRow(LiteralAsBooleanNullable value)
        : this(
            (OneOf<
                FieldAsBooleanNullable,
                ParamAsBooleanNullable,
                LiteralAsBooleanNullable,
                LogicalRow,
                ComparisonRow,
                ConditionalBooleanNullableRow
            >)
                value
        )
    { }

    public BooleanNullableRow(LogicalRow value)
        : this(
            (OneOf<
                FieldAsBooleanNullable,
                ParamAsBooleanNullable,
                LiteralAsBooleanNullable,
                LogicalRow,
                ComparisonRow,
                ConditionalBooleanNullableRow
            >)
                value
        )
    { }

    public BooleanNullableRow(ComparisonRow value)
        : this(
            (OneOf<
                FieldAsBooleanNullable,
                ParamAsBooleanNullable,
                LiteralAsBooleanNullable,
                LogicalRow,
                ComparisonRow,
                ConditionalBooleanNullableRow
            >)
                value
        )
    { }

    public BooleanNullableRow(ConditionalBooleanNullableRow value)
        : this(
            (OneOf<
                FieldAsBooleanNullable,
                ParamAsBooleanNullable,
                LiteralAsBooleanNullable,
                LogicalRow,
                ComparisonRow,
                ConditionalBooleanNullableRow
            >)
                value
        )
    { }

    private BooleanNullableRow(
        OneOf<
            FieldAsBooleanNullable,
            ParamAsBooleanNullable,
            LiteralAsBooleanNullable,
            LogicalRow,
            ComparisonRow,
            ConditionalBooleanNullableRow
        > input
    )
        : base(input) { }
}
