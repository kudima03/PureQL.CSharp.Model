using OneOf;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed class AggregateStringNullableTotal
    : OneOfBase<MinStringNullableTotal, MaxStringNullableTotal>
{
    public AggregateStringNullableTotal(MinStringNullableTotal value)
        : this((OneOf<MinStringNullableTotal, MaxStringNullableTotal>)value) { }

    public AggregateStringNullableTotal(MaxStringNullableTotal value)
        : this((OneOf<MinStringNullableTotal, MaxStringNullableTotal>)value) { }

    private AggregateStringNullableTotal(
        OneOf<MinStringNullableTotal, MaxStringNullableTotal> input
    )
        : base(input) { }
}
