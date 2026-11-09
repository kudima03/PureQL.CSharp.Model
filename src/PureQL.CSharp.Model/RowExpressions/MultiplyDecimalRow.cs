using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>multiply.decimal@row</c>.</summary>
public sealed record MultiplyDecimalRow : IOperator
{
    public MultiplyDecimalRow(IEnumerable<DecimalRow> values)
    {
        Values = values;
    }

    public IEnumerable<DecimalRow> Values { get; }

    public IType Type => new TypeDecimal();
}
