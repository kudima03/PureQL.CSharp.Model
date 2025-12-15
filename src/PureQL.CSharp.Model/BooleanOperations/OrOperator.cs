using PureQL.CSharp.Model.Returnings;

namespace PureQL.CSharp.Model.BooleanOperations;

public sealed record OrOperator
{
    public OrOperator(IEnumerable<BooleanReturning> conditions)
    {
        Conditions = conditions;
    }

    public IEnumerable<BooleanReturning> Conditions { get; }
}
