using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class AggregateDateProjection
    : OneOfBase<AverageDateProjection, MinDateProjection, MaxDateProjection>
{
    public AggregateDateProjection(AverageDateProjection value)
        : this((OneOf<AverageDateProjection, MinDateProjection, MaxDateProjection>)value)
    { }

    public AggregateDateProjection(MinDateProjection value)
        : this((OneOf<AverageDateProjection, MinDateProjection, MaxDateProjection>)value)
    { }

    public AggregateDateProjection(MaxDateProjection value)
        : this((OneOf<AverageDateProjection, MinDateProjection, MaxDateProjection>)value)
    { }

    private AggregateDateProjection(
        OneOf<AverageDateProjection, MinDateProjection, MaxDateProjection> input
    )
        : base(input) { }
}
