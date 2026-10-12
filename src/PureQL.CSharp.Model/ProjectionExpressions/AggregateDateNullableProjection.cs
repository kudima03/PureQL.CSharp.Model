using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class AggregateDateNullableProjection
    : OneOfBase<
        AverageDateNullableProjection,
        MinDateNullableProjection,
        MaxDateNullableProjection
    >
{
    public AggregateDateNullableProjection(AverageDateNullableProjection value)
        : this(
            (OneOf<
                AverageDateNullableProjection,
                MinDateNullableProjection,
                MaxDateNullableProjection
            >)
                value
        )
    { }

    public AggregateDateNullableProjection(MinDateNullableProjection value)
        : this(
            (OneOf<
                AverageDateNullableProjection,
                MinDateNullableProjection,
                MaxDateNullableProjection
            >)
                value
        )
    { }

    public AggregateDateNullableProjection(MaxDateNullableProjection value)
        : this(
            (OneOf<
                AverageDateNullableProjection,
                MinDateNullableProjection,
                MaxDateNullableProjection
            >)
                value
        )
    { }

    private AggregateDateNullableProjection(
        OneOf<
            AverageDateNullableProjection,
            MinDateNullableProjection,
            MaxDateNullableProjection
        > input
    )
        : base(input) { }
}
