using OneOf;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed class ConditionalTimeTotal : OneOfBase<IfTimeTotal, CoalesceTimeTotal>
{
    public ConditionalTimeTotal(IfTimeTotal value)
        : this((OneOf<IfTimeTotal, CoalesceTimeTotal>)value) { }

    public ConditionalTimeTotal(CoalesceTimeTotal value)
        : this((OneOf<IfTimeTotal, CoalesceTimeTotal>)value) { }

    private ConditionalTimeTotal(OneOf<IfTimeTotal, CoalesceTimeTotal> input)
        : base(input) { }
}
