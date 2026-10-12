using OneOf;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed class ConditionalStringTotal : OneOfBase<IfStringTotal, CoalesceStringTotal>
{
    public ConditionalStringTotal(IfStringTotal value)
        : this((OneOf<IfStringTotal, CoalesceStringTotal>)value) { }

    public ConditionalStringTotal(CoalesceStringTotal value)
        : this((OneOf<IfStringTotal, CoalesceStringTotal>)value) { }

    private ConditionalStringTotal(OneOf<IfStringTotal, CoalesceStringTotal> input)
        : base(input) { }
}
