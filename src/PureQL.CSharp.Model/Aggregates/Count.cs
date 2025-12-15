using PureQL.CSharp.Model.Fields;

namespace PureQL.CSharp.Model.Aggregates;

public sealed record Count
{
    public Count(Field argument)
    {
        Argument = argument;
    }

    public Field Argument { get; }
}
