using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>least.uuid@row</c>.</summary>
public sealed record LeastUuidRow : IOperator
{
    public LeastUuidRow(IEnumerable<UuidRow> values)
    {
        Values = values;
    }

    public IEnumerable<UuidRow> Values { get; }

    public IType Type => new TypeUuid();
}
