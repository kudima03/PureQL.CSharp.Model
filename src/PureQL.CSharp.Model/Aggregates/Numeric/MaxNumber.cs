using PureQL.CSharp.Model.ArrayReturnings;

namespace PureQL.CSharp.Model.Aggregates.Numeric;

public sealed record MaxNumber
{
    public MaxNumber(NumberArrayReturning argument)
    {
        Argument = argument;
    }

    public NumberArrayReturning Argument { get; }
}
