using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>greatest.decimal@row</c>.</summary>
public sealed record GreatestDecimalRow : IOperator
{
    public GreatestDecimalRow(IEnumerable<DecimalRow> values)
    {
        Values = values;
    }

    public IEnumerable<DecimalRow> Values { get; }

    public IType Type => new TypeDecimal();
}
