using OneOf;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class LogicalGroup : OneOfBase<AndGroup, OrGroup, NotGroup>
{
    public LogicalGroup(AndGroup value)
        : this((OneOf<AndGroup, OrGroup, NotGroup>)value) { }

    public LogicalGroup(OrGroup value)
        : this((OneOf<AndGroup, OrGroup, NotGroup>)value) { }

    public LogicalGroup(NotGroup value)
        : this((OneOf<AndGroup, OrGroup, NotGroup>)value) { }

    private LogicalGroup(OneOf<AndGroup, OrGroup, NotGroup> input)
        : base(input) { }
}
