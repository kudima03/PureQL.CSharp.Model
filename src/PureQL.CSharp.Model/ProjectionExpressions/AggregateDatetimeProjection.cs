using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class AggregateDatetimeProjection
    : OneOfBase<AverageDatetimeProjection, MinDatetimeProjection, MaxDatetimeProjection>
{
    public AggregateDatetimeProjection(AverageDatetimeProjection value)
        : this(
            (OneOf<
                AverageDatetimeProjection,
                MinDatetimeProjection,
                MaxDatetimeProjection
            >)
                value
        )
    { }

    public AggregateDatetimeProjection(MinDatetimeProjection value)
        : this(
            (OneOf<
                AverageDatetimeProjection,
                MinDatetimeProjection,
                MaxDatetimeProjection
            >)
                value
        )
    { }

    public AggregateDatetimeProjection(MaxDatetimeProjection value)
        : this(
            (OneOf<
                AverageDatetimeProjection,
                MinDatetimeProjection,
                MaxDatetimeProjection
            >)
                value
        )
    { }

    private AggregateDatetimeProjection(
        OneOf<
            AverageDatetimeProjection,
            MinDatetimeProjection,
            MaxDatetimeProjection
        > input
    )
        : base(input) { }
}
