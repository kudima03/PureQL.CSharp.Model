using OneOf;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed class ConditionalIntegerTotal
    : OneOfBase<IfIntegerTotal, CoalesceIntegerTotal>
{
    public ConditionalIntegerTotal(IfIntegerTotal value)
        : this((OneOf<IfIntegerTotal, CoalesceIntegerTotal>)value) { }

    public ConditionalIntegerTotal(CoalesceIntegerTotal value)
        : this((OneOf<IfIntegerTotal, CoalesceIntegerTotal>)value) { }

    private ConditionalIntegerTotal(OneOf<IfIntegerTotal, CoalesceIntegerTotal> input)
        : base(input) { }
}
