using PureQL.CSharp.Model.Returnings;

namespace PureQL.CSharp.Model.Aggregates.Numeric;

public sealed record MinNumber
{
    public MinNumber(NumberReturning argument)
    {
        Argument = argument;
    }

    public NumberReturning Argument { get; private set; }
}
