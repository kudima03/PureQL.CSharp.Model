using PureQL.CSharp.Model.ArrayReturnings;

namespace PureQL.CSharp.Model.EachBooleanOperations;

public sealed record EachOrOperator
{
    public EachOrOperator(IEnumerable<BooleanArrayReturning> conditions)
    {
        Conditions = conditions;
    }

    public IEnumerable<BooleanArrayReturning> Conditions { get; }
}
