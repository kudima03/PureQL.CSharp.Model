using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Fields;

/// <summary>PureQL <c>field.time.nullable</c>.</summary>
public sealed record FieldTimeNullable : IField
{
    public FieldTimeNullable(string source, string field)
    {
        Source = source;
        Field = field;
    }

    public string Source { get; }

    public string Field { get; }

    public IType Type => new TypeTimeNullable();
}
