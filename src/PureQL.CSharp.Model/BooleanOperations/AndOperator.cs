using PureQL.CSharp.Model.Returnings;

namespace PureQL.CSharp.Model.BooleanOperations;

public sealed record AndOperator
{
    public AndOperator(IEnumerable<BooleanReturning> conditions)
    {
        Conditions = conditions;
    }

    public IEnumerable<BooleanReturning> Conditions { get; }
}
