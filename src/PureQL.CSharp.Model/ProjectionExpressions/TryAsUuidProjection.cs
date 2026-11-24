using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>tryAsUuid@projection</c>.</summary>
public sealed record TryAsUuidProjection : IOperator
{
    public TryAsUuidProjection(StringNullableProjection operand)
    {
        Operand = operand;
    }

    public StringNullableProjection Operand { get; }

    public IType Type => new TypeUuidNullable();
}
