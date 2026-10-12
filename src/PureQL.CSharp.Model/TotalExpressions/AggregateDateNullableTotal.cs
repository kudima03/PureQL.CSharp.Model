using OneOf;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed class AggregateDateNullableTotal
    : OneOfBase<AverageDateNullableTotal, MinDateNullableTotal, MaxDateNullableTotal>
{
    public AggregateDateNullableTotal(AverageDateNullableTotal value)
        : this(
            (OneOf<AverageDateNullableTotal, MinDateNullableTotal, MaxDateNullableTotal>)
                value
        )
    { }

    public AggregateDateNullableTotal(MinDateNullableTotal value)
        : this(
            (OneOf<AverageDateNullableTotal, MinDateNullableTotal, MaxDateNullableTotal>)
                value
        )
    { }

    public AggregateDateNullableTotal(MaxDateNullableTotal value)
        : this(
            (OneOf<AverageDateNullableTotal, MinDateNullableTotal, MaxDateNullableTotal>)
                value
        )
    { }

    private AggregateDateNullableTotal(
        OneOf<AverageDateNullableTotal, MinDateNullableTotal, MaxDateNullableTotal> input
    )
        : base(input) { }
}
