using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Fields;

/// <summary>PureQL <c>field.string.nullable</c>.</summary>
public sealed record FieldStringNullable : IField
{
    public FieldStringNullable(string source, string field)
    {
        Source = source;
        Field = field;
    }

    public string Source { get; }

    public string Field { get; }

    public IType Type => new TypeStringNullable();
}
