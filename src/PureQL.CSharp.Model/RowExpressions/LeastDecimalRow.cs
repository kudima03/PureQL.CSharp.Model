using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>least.decimal@row</c>.</summary>
public sealed record LeastDecimalRow : IOperator
{
    public LeastDecimalRow(IEnumerable<DecimalRow> values)
    {
        Values = values;
    }

    public IEnumerable<DecimalRow> Values { get; }

    public IType Type => new TypeDecimal();
}
