using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>atan2.decimal@group</c>.</summary>
public sealed record Atan2DecimalGroup : IOperator
{
    public Atan2DecimalGroup(DecimalGroup y, DecimalGroup x)
    {
        Y = y;
        X = x;
    }

    public DecimalGroup Y { get; }

    public DecimalGroup X { get; }

    public IType Type => new TypeDecimal();
}
