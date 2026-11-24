using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>pi@projection</c>.</summary>
public sealed record PiProjection : IOperator
{
    public IType Type => new TypeDecimal();
}
