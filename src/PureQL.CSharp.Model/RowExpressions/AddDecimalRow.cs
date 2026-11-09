using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>add.decimal@row</c>.</summary>
public sealed record AddDecimalRow : IOperator
{
    public AddDecimalRow(IEnumerable<DecimalRow> values)
    {
        Values = values;
    }

    public IEnumerable<DecimalRow> Values { get; }

    public IType Type => new TypeDecimal();
}
