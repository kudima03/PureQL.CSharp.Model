using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Fields;

/// <summary>PureQL <c>field.string</c>.</summary>
public sealed record FieldString : IField
{
    public FieldString(string source, string field)
    {
        Source = source;
        Field = field;
    }

    public string Source { get; }

    public string Field { get; }

    public IType Type => new TypeString();
}
