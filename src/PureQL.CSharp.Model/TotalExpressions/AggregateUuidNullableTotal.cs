using OneOf;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed class AggregateUuidNullableTotal
    : OneOfBase<MinUuidNullableTotal, MaxUuidNullableTotal>
{
    public AggregateUuidNullableTotal(MinUuidNullableTotal value)
        : this((OneOf<MinUuidNullableTotal, MaxUuidNullableTotal>)value) { }

    public AggregateUuidNullableTotal(MaxUuidNullableTotal value)
        : this((OneOf<MinUuidNullableTotal, MaxUuidNullableTotal>)value) { }

    private AggregateUuidNullableTotal(
        OneOf<MinUuidNullableTotal, MaxUuidNullableTotal> input
    )
        : base(input) { }
}
