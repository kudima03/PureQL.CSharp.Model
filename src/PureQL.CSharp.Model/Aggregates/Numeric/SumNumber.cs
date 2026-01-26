using PureQL.CSharp.Model.ArrayReturnings;

namespace PureQL.CSharp.Model.Aggregates.Numeric;

public sealed record SumNumber
{
    public SumNumber(NumberArrayReturning argument)
    {
        Argument = argument;
    }

    public NumberArrayReturning Argument { get; }
}
