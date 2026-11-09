using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>coalesce.uuid@row</c>.</summary>
public sealed record CoalesceUuidRow : IOperator
{
    public CoalesceUuidRow(IEnumerable<UuidNullableRow> values)
    {
        Values = values;
    }

    public IEnumerable<UuidNullableRow> Values { get; }

    public IType Type => new TypeUuid();
}
