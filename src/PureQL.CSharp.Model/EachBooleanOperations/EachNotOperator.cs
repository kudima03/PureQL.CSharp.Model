using PureQL.CSharp.Model.ArrayReturnings;

namespace PureQL.CSharp.Model.EachBooleanOperations;

public sealed record EachNotOperator
{
    public EachNotOperator(BooleanArrayReturning condition)
    {
        Condition = condition;
    }

    public BooleanArrayReturning Condition { get; }
}
