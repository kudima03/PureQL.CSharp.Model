using PureQL.CSharp.Model.Returnings;

namespace PureQL.CSharp.Model.Aggregates.String;

public sealed record MaxString
{
    public MaxString(StringReturning argument)
    {
        Argument = argument;
    }

    public StringReturning Argument { get; }
}
