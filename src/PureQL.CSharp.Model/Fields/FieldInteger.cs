using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Fields;

/// <summary>PureQL <c>field.integer</c>.</summary>
public sealed record FieldInteger : IField
{
    public FieldInteger(string source, string field)
    {
        Source = source;
        Field = field;
    }

    public string Source { get; }

    public string Field { get; }

    public IType Type => new TypeInteger();
}
