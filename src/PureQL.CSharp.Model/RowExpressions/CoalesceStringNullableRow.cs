using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>coalesce.string.nullable@row</c>.</summary>
public sealed record CoalesceStringNullableRow : IOperator
{
    public CoalesceStringNullableRow(IEnumerable<DeclaresStringNullableRow> values)
    {
        Values = values;
    }

    public IEnumerable<DeclaresStringNullableRow> Values { get; }

    public IType Type => new TypeStringNullable();
}
