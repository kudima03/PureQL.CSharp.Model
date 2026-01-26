using PureQL.CSharp.Model.ArrayReturnings;

namespace PureQL.CSharp.Model.Aggregates.String;

public sealed record MaxString
{
    public MaxString(StringArrayReturning argument)
    {
        Argument = argument;
    }

    public StringArrayReturning Argument { get; }
}
