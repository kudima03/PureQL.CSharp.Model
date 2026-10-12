using OneOf;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed class AggregateBooleanNullableTotal
    : OneOfBase<MinBooleanNullableTotal, MaxBooleanNullableTotal>
{
    public AggregateBooleanNullableTotal(MinBooleanNullableTotal value)
        : this((OneOf<MinBooleanNullableTotal, MaxBooleanNullableTotal>)value) { }

    public AggregateBooleanNullableTotal(MaxBooleanNullableTotal value)
        : this((OneOf<MinBooleanNullableTotal, MaxBooleanNullableTotal>)value) { }

    private AggregateBooleanNullableTotal(
        OneOf<MinBooleanNullableTotal, MaxBooleanNullableTotal> input
    )
        : base(input) { }
}
