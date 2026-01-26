using PureQL.CSharp.Model.ArrayReturnings;

namespace PureQL.CSharp.Model.Aggregates;

public sealed record Count
{
    public Count(ArrayReturning argument)
    {
        Argument = argument;
    }

    public ArrayReturning Argument { get; }
}
