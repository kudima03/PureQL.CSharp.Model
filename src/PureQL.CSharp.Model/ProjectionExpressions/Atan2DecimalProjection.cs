using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>atan2.decimal@projection</c>.</summary>
public sealed record Atan2DecimalProjection : IOperator
{
    public Atan2DecimalProjection(DecimalProjection y, DecimalProjection x)
    {
        Y = y;
        X = x;
    }

    public DecimalProjection Y { get; }

    public DecimalProjection X { get; }

    public IType Type => new TypeDecimal();
}
