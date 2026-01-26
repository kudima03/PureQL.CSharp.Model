using PureQL.CSharp.Model.ArrayReturnings;

namespace PureQL.CSharp.Model.Aggregates.Numeric;

public sealed record AverageNumber
{
    public AverageNumber(NumberArrayReturning argument)
    {
        Argument = argument;
    }

    public NumberArrayReturning Argument { get; }
}
