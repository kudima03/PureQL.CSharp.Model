using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>tryAsDate@projection</c>.</summary>
public sealed record TryAsDateProjection : IOperator
{
    public TryAsDateProjection(StringNullableProjection operand)
    {
        Operand = operand;
    }

    public StringNullableProjection Operand { get; }

    public IType Type => new TypeDateNullable();
}
