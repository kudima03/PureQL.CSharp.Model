using OneOf;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed class AggregateDatetimeNullableTotal
    : OneOfBase<
        AverageDatetimeNullableTotal,
        MinDatetimeNullableTotal,
        MaxDatetimeNullableTotal
    >
{
    public AggregateDatetimeNullableTotal(AverageDatetimeNullableTotal value)
        : this(
            (OneOf<
                AverageDatetimeNullableTotal,
                MinDatetimeNullableTotal,
                MaxDatetimeNullableTotal
            >)
                value
        )
    { }

    public AggregateDatetimeNullableTotal(MinDatetimeNullableTotal value)
        : this(
            (OneOf<
                AverageDatetimeNullableTotal,
                MinDatetimeNullableTotal,
                MaxDatetimeNullableTotal
            >)
                value
        )
    { }

    public AggregateDatetimeNullableTotal(MaxDatetimeNullableTotal value)
        : this(
            (OneOf<
                AverageDatetimeNullableTotal,
                MinDatetimeNullableTotal,
                MaxDatetimeNullableTotal
            >)
                value
        )
    { }

    private AggregateDatetimeNullableTotal(
        OneOf<
            AverageDatetimeNullableTotal,
            MinDatetimeNullableTotal,
            MaxDatetimeNullableTotal
        > input
    )
        : base(input) { }
}
