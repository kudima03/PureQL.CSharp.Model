using OneOf;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed class AggregateIntegerTotal : OneOfBase<CountTotal, SumIntegerTotal>
{
    public AggregateIntegerTotal(CountTotal value)
        : this((OneOf<CountTotal, SumIntegerTotal>)value) { }

    public AggregateIntegerTotal(SumIntegerTotal value)
        : this((OneOf<CountTotal, SumIntegerTotal>)value) { }

    private AggregateIntegerTotal(OneOf<CountTotal, SumIntegerTotal> input)
        : base(input) { }
}
