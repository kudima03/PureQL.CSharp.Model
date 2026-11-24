using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>tryAsInteger@projection</c>.</summary>
public sealed record TryAsIntegerProjection : IOperator
{
    public TryAsIntegerProjection(StringNullableProjection operand)
    {
        Operand = operand;
    }

    public StringNullableProjection Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
