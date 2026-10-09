using OneOf;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class AggregateBooleanGroup : OneOfBase<AnyGroup, AllGroup>
{
    public AggregateBooleanGroup(AnyGroup value)
        : this((OneOf<AnyGroup, AllGroup>)value) { }

    public AggregateBooleanGroup(AllGroup value)
        : this((OneOf<AnyGroup, AllGroup>)value) { }

    private AggregateBooleanGroup(OneOf<AnyGroup, AllGroup> input)
        : base(input) { }
}
