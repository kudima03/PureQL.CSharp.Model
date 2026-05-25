using PureQL.CSharp.Model.ArrayReturnings;

namespace PureQL.CSharp.Model.EachBooleanOperations;

public sealed record EachAndOperator
{
    public EachAndOperator(IEnumerable<BooleanArrayReturning> conditions)
    {
        Conditions = conditions;
    }

    public IEnumerable<BooleanArrayReturning> Conditions { get; }
}
