using OneOf;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed class AggregateIntegerNullableTotal
    : OneOfBase<MinIntegerNullableTotal, MaxIntegerNullableTotal>
{
    public AggregateIntegerNullableTotal(MinIntegerNullableTotal value)
        : this((OneOf<MinIntegerNullableTotal, MaxIntegerNullableTotal>)value) { }

    public AggregateIntegerNullableTotal(MaxIntegerNullableTotal value)
        : this((OneOf<MinIntegerNullableTotal, MaxIntegerNullableTotal>)value) { }

    private AggregateIntegerNullableTotal(
        OneOf<MinIntegerNullableTotal, MaxIntegerNullableTotal> input
    )
        : base(input) { }
}
