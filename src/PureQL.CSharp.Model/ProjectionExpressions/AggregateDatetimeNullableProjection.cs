using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class AggregateDatetimeNullableProjection
    : OneOfBase<
        AverageDatetimeNullableProjection,
        MinDatetimeNullableProjection,
        MaxDatetimeNullableProjection
    >
{
    public AggregateDatetimeNullableProjection(AverageDatetimeNullableProjection value)
        : this(
            (OneOf<
                AverageDatetimeNullableProjection,
                MinDatetimeNullableProjection,
                MaxDatetimeNullableProjection
            >)
                value
        )
    { }

    public AggregateDatetimeNullableProjection(MinDatetimeNullableProjection value)
        : this(
            (OneOf<
                AverageDatetimeNullableProjection,
                MinDatetimeNullableProjection,
                MaxDatetimeNullableProjection
            >)
                value
        )
    { }

    public AggregateDatetimeNullableProjection(MaxDatetimeNullableProjection value)
        : this(
            (OneOf<
                AverageDatetimeNullableProjection,
                MinDatetimeNullableProjection,
                MaxDatetimeNullableProjection
            >)
                value
        )
    { }

    private AggregateDatetimeNullableProjection(
        OneOf<
            AverageDatetimeNullableProjection,
            MinDatetimeNullableProjection,
            MaxDatetimeNullableProjection
        > input
    )
        : base(input) { }
}
