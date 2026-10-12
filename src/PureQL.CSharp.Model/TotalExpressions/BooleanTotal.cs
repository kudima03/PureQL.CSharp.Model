using OneOf;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed class BooleanTotal
    : OneOfBase<
        ParamBoolean,
        LiteralBoolean,
        LogicalTotal,
        ComparisonTotal,
        ConditionalBooleanTotal,
        AggregateBooleanTotal
    >
{
    public BooleanTotal(ParamBoolean value)
        : this(
            (OneOf<
                ParamBoolean,
                LiteralBoolean,
                LogicalTotal,
                ComparisonTotal,
                ConditionalBooleanTotal,
                AggregateBooleanTotal
            >)
                value
        )
    { }

    public BooleanTotal(LiteralBoolean value)
        : this(
            (OneOf<
                ParamBoolean,
                LiteralBoolean,
                LogicalTotal,
                ComparisonTotal,
                ConditionalBooleanTotal,
                AggregateBooleanTotal
            >)
                value
        )
    { }

    public BooleanTotal(LogicalTotal value)
        : this(
            (OneOf<
                ParamBoolean,
                LiteralBoolean,
                LogicalTotal,
                ComparisonTotal,
                ConditionalBooleanTotal,
                AggregateBooleanTotal
            >)
                value
        )
    { }

    public BooleanTotal(ComparisonTotal value)
        : this(
            (OneOf<
                ParamBoolean,
                LiteralBoolean,
                LogicalTotal,
                ComparisonTotal,
                ConditionalBooleanTotal,
                AggregateBooleanTotal
            >)
                value
        )
    { }

    public BooleanTotal(ConditionalBooleanTotal value)
        : this(
            (OneOf<
                ParamBoolean,
                LiteralBoolean,
                LogicalTotal,
                ComparisonTotal,
                ConditionalBooleanTotal,
                AggregateBooleanTotal
            >)
                value
        )
    { }

    public BooleanTotal(AggregateBooleanTotal value)
        : this(
            (OneOf<
                ParamBoolean,
                LiteralBoolean,
                LogicalTotal,
                ComparisonTotal,
                ConditionalBooleanTotal,
                AggregateBooleanTotal
            >)
                value
        )
    { }

    private BooleanTotal(
        OneOf<
            ParamBoolean,
            LiteralBoolean,
            LogicalTotal,
            ComparisonTotal,
            ConditionalBooleanTotal,
            AggregateBooleanTotal
        > input
    )
        : base(input) { }
}
