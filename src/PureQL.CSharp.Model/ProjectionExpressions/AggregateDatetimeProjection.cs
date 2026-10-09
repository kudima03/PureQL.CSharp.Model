using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class AggregateDatetimeProjection
    : OneOfBase<
        AverageDatetimeNullableProjection,
        MinDatetimeNullableProjection,
        MaxDatetimeNullableProjection
    >
{
    public AggregateDatetimeProjection(AverageDatetimeNullableProjection value)
        : this(
            (OneOf<
                AverageDatetimeNullableProjection,
                MinDatetimeNullableProjection,
                MaxDatetimeNullableProjection
            >)
                value
        )
    { }

    public AggregateDatetimeProjection(MinDatetimeNullableProjection value)
        : this(
            (OneOf<
                AverageDatetimeNullableProjection,
                MinDatetimeNullableProjection,
                MaxDatetimeNullableProjection
            >)
                value
        )
    { }

    public AggregateDatetimeProjection(MaxDatetimeNullableProjection value)
        : this(
            (OneOf<
                AverageDatetimeNullableProjection,
                MinDatetimeNullableProjection,
                MaxDatetimeNullableProjection
            >)
                value
        )
    { }

    private AggregateDatetimeProjection(
        OneOf<
            AverageDatetimeNullableProjection,
            MinDatetimeNullableProjection,
            MaxDatetimeNullableProjection
        > input
    )
        : base(input) { }
}
