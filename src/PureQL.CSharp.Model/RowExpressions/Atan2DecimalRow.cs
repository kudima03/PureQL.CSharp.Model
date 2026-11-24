using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>atan2.decimal@row</c>.</summary>
public sealed record Atan2DecimalRow : IOperator
{
    public Atan2DecimalRow(DecimalRow y, DecimalRow x)
    {
        Y = y;
        X = x;
    }

    public DecimalRow Y { get; }

    public DecimalRow X { get; }

    public IType Type => new TypeDecimal();
}
