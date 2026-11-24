using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>greatest.uuid@row</c>.</summary>
public sealed record GreatestUuidRow : IOperator
{
    public GreatestUuidRow(IEnumerable<UuidRow> values)
    {
        Values = values;
    }

    public IEnumerable<UuidRow> Values { get; }

    public IType Type => new TypeUuid();
}
