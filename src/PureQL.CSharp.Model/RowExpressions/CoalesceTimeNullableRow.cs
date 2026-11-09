using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>coalesce.time.nullable@row</c>.</summary>
public sealed record CoalesceTimeNullableRow : IOperator
{
    public CoalesceTimeNullableRow(IEnumerable<DeclaresTimeNullableRow> values)
    {
        Values = values;
    }

    public IEnumerable<DeclaresTimeNullableRow> Values { get; }

    public IType Type => new TypeTimeNullable();
}
