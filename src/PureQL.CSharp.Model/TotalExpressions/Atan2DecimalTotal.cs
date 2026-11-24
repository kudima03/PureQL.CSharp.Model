using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>atan2.decimal@total</c>.</summary>
public sealed record Atan2DecimalTotal : IOperator
{
    public Atan2DecimalTotal(DecimalTotal y, DecimalTotal x)
    {
        Y = y;
        X = x;
    }

    public DecimalTotal Y { get; }

    public DecimalTotal X { get; }

    public IType Type => new TypeDecimal();
}
