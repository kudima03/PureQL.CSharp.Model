using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>asDate.string.date.nullable@projection</c>.</summary>
public sealed record AsDateStringDateNullableProjection : IOperator
{
    public AsDateStringDateNullableProjection(DeclaresStringNullableProjection operand)
    {
        Operand = operand;
    }

    public DeclaresStringNullableProjection Operand { get; }

    public IType Type => new TypeDateNullable();
}
