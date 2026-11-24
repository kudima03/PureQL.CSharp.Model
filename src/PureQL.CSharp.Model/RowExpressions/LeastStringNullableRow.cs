using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>least.string.nullable@row</c>.</summary>
public sealed record LeastStringNullableRow : IOperator
{
    public LeastStringNullableRow(IEnumerable<StringNullableRow> values)
    {
        Values = values;
    }

    public IEnumerable<StringNullableRow> Values { get; }

    public IType Type => new TypeStringNullable();
}
