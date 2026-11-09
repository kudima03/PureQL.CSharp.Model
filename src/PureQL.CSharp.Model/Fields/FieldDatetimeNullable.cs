using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Fields;

/// <summary>PureQL <c>field.datetime.nullable</c>.</summary>
public sealed record FieldDatetimeNullable : IField
{
    public FieldDatetimeNullable(string source, string field)
    {
        Source = source;
        Field = field;
    }

    public string Source { get; }

    public string Field { get; }

    public IType Type => new TypeDatetimeNullable();
}
