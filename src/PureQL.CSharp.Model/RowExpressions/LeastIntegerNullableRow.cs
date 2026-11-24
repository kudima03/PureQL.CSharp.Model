using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>least.integer.nullable@row</c>.</summary>
public sealed record LeastIntegerNullableRow : IOperator
{
    public LeastIntegerNullableRow(IEnumerable<IntegerNullableRow> values)
    {
        Values = values;
    }

    public IEnumerable<IntegerNullableRow> Values { get; }

    public IType Type => new TypeIntegerNullable();
}
