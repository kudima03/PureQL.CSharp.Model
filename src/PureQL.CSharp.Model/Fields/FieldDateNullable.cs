using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Fields;

public sealed record FieldDateNullable : IField
{
    public FieldDateNullable(string source, string field)
    {
        Source = source;
        Field = field;
    }

    public string Source { get; }

    public string Field { get; }

    public IType Type => new TypeDateNullable();
}
