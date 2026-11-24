using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>tryAsTime@projection</c>.</summary>
public sealed record TryAsTimeProjection : IOperator
{
    public TryAsTimeProjection(StringNullableProjection operand)
    {
        Operand = operand;
    }

    public StringNullableProjection Operand { get; }

    public IType Type => new TypeTimeNullable();
}
