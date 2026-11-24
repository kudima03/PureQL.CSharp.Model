using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>tryAsDatetime@projection</c>.</summary>
public sealed record TryAsDatetimeProjection : IOperator
{
    public TryAsDatetimeProjection(StringNullableProjection operand)
    {
        Operand = operand;
    }

    public StringNullableProjection Operand { get; }

    public IType Type => new TypeDatetimeNullable();
}
