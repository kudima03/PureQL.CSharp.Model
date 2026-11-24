using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>startOfSecond.datetime.nullable@projection</c>.</summary>
public sealed record StartOfSecondDatetimeNullableProjection : IOperator
{
    public StartOfSecondDatetimeNullableProjection(
        DeclaresDatetimeNullableProjection operand
    )
    {
        Operand = operand;
    }

    public DeclaresDatetimeNullableProjection Operand { get; }

    public IType Type => new TypeDatetimeNullable();
}
