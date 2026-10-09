using OneOf;
using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed class BooleanRow
    : OneOfBase<
        FieldBoolean,
        ParamBoolean,
        LiteralBoolean,
        LogicalRow,
        ComparisonRow,
        ConditionalBooleanRow
    >
{
    public BooleanRow(FieldBoolean value)
        : this(
            (OneOf<
                FieldBoolean,
                ParamBoolean,
                LiteralBoolean,
                LogicalRow,
                ComparisonRow,
                ConditionalBooleanRow
            >)
                value
        )
    { }

    public BooleanRow(ParamBoolean value)
        : this(
            (OneOf<
                FieldBoolean,
                ParamBoolean,
                LiteralBoolean,
                LogicalRow,
                ComparisonRow,
                ConditionalBooleanRow
            >)
                value
        )
    { }

    public BooleanRow(LiteralBoolean value)
        : this(
            (OneOf<
                FieldBoolean,
                ParamBoolean,
                LiteralBoolean,
                LogicalRow,
                ComparisonRow,
                ConditionalBooleanRow
            >)
                value
        )
    { }

    public BooleanRow(LogicalRow value)
        : this(
            (OneOf<
                FieldBoolean,
                ParamBoolean,
                LiteralBoolean,
                LogicalRow,
                ComparisonRow,
                ConditionalBooleanRow
            >)
                value
        )
    { }

    public BooleanRow(ComparisonRow value)
        : this(
            (OneOf<
                FieldBoolean,
                ParamBoolean,
                LiteralBoolean,
                LogicalRow,
                ComparisonRow,
                ConditionalBooleanRow
            >)
                value
        )
    { }

    public BooleanRow(ConditionalBooleanRow value)
        : this(
            (OneOf<
                FieldBoolean,
                ParamBoolean,
                LiteralBoolean,
                LogicalRow,
                ComparisonRow,
                ConditionalBooleanRow
            >)
                value
        )
    { }

    private BooleanRow(
        OneOf<
            FieldBoolean,
            ParamBoolean,
            LiteralBoolean,
            LogicalRow,
            ComparisonRow,
            ConditionalBooleanRow
        > input
    )
        : base(input) { }
}
