using OneOf;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed class ConditionalDecimalTotal
    : OneOfBase<IfDecimalTotal, CoalesceDecimalTotal>
{
    public ConditionalDecimalTotal(IfDecimalTotal value)
        : this((OneOf<IfDecimalTotal, CoalesceDecimalTotal>)value) { }

    public ConditionalDecimalTotal(CoalesceDecimalTotal value)
        : this((OneOf<IfDecimalTotal, CoalesceDecimalTotal>)value) { }

    private ConditionalDecimalTotal(OneOf<IfDecimalTotal, CoalesceDecimalTotal> input)
        : base(input) { }
}
