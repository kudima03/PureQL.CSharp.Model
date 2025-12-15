using PureQL.CSharp.Model.Returnings;

namespace PureQL.CSharp.Model.BooleanOperations;

public sealed record NotOperator
{
    public NotOperator(BooleanReturning condition)
    {
        Condition = condition;
    }

    public BooleanReturning Condition { get; }
}
