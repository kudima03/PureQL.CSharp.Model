using PureQL.CSharp.Model.Returnings;

namespace PureQL.CSharp.Model.Aggregates.Numeric;

public sealed record MaxNumber
{
    public MaxNumber(NumberReturning argument)
    {
        Argument = argument;
    }

    public NumberReturning Argument { get; }
}
