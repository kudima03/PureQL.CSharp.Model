using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>subtract.decimal@row</c>.</summary>
public sealed record SubtractDecimalRow : IOperator
{
    public SubtractDecimalRow(IEnumerable<DecimalRow> values)
    {
        Values = values;
    }

    public IEnumerable<DecimalRow> Values { get; }

    public IType Type => new TypeDecimal();
}
