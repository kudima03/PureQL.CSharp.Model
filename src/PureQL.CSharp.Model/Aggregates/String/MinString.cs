using PureQL.CSharp.Model.ArrayReturnings;

namespace PureQL.CSharp.Model.Aggregates.String;

public sealed record MinString
{
    public MinString(StringArrayReturning argument)
    {
        Argument = argument;
    }

    public StringArrayReturning Argument { get; }
}
