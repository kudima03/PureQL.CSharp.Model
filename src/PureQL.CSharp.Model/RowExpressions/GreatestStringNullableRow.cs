using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>greatest.string.nullable@row</c>.</summary>
public sealed record GreatestStringNullableRow : IOperator
{
    public GreatestStringNullableRow(IEnumerable<StringNullableRow> values)
    {
        Values = values;
    }

    public IEnumerable<StringNullableRow> Values { get; }

    public IType Type => new TypeStringNullable();
}
