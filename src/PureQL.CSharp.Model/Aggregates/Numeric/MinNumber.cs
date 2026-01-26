using PureQL.CSharp.Model.ArrayReturnings;

namespace PureQL.CSharp.Model.Aggregates.Numeric;

public sealed record MinNumber
{
    public MinNumber(NumberArrayReturning argument)
    {
        Argument = argument;
    }

    public NumberArrayReturning Argument { get; }
}
