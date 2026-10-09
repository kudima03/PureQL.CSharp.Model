using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class LogicalProjection
    : OneOfBase<AndProjection, OrProjection, NotProjection>
{
    public LogicalProjection(AndProjection value)
        : this((OneOf<AndProjection, OrProjection, NotProjection>)value) { }

    public LogicalProjection(OrProjection value)
        : this((OneOf<AndProjection, OrProjection, NotProjection>)value) { }

    public LogicalProjection(NotProjection value)
        : this((OneOf<AndProjection, OrProjection, NotProjection>)value) { }

    private LogicalProjection(OneOf<AndProjection, OrProjection, NotProjection> input)
        : base(input) { }
}
