using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class AggregateDateProjection
    : OneOfBase<
        AverageDateNullableProjection,
        MinDateNullableProjection,
        MaxDateNullableProjection
    >
{
    public AggregateDateProjection(AverageDateNullableProjection value)
        : this(
            (OneOf<
                AverageDateNullableProjection,
                MinDateNullableProjection,
                MaxDateNullableProjection
            >)
                value
        )
    { }

    public AggregateDateProjection(MinDateNullableProjection value)
        : this(
            (OneOf<
                AverageDateNullableProjection,
                MinDateNullableProjection,
                MaxDateNullableProjection
            >)
                value
        )
    { }

    public AggregateDateProjection(MaxDateNullableProjection value)
        : this(
            (OneOf<
                AverageDateNullableProjection,
                MinDateNullableProjection,
                MaxDateNullableProjection
            >)
                value
        )
    { }

    private AggregateDateProjection(
        OneOf<
            AverageDateNullableProjection,
            MinDateNullableProjection,
            MaxDateNullableProjection
        > input
    )
        : base(input) { }
}
