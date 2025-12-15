using PureQL.CSharp.Model.Returnings;

namespace PureQL.CSharp.Model.Aggregates.String;

public sealed record MinString
{
    public MinString(StringReturning argument)
    {
        Argument = argument;
    }

    public StringReturning Argument { get; private set; }
}
