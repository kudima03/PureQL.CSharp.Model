using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>asDatetime.string.datetime.nullable@projection</c>.</summary>
public sealed record AsDatetimeStringDatetimeNullableProjection : IOperator
{
    public AsDatetimeStringDatetimeNullableProjection(
        DeclaresStringNullableProjection operand
    )
    {
        Operand = operand;
    }

    public DeclaresStringNullableProjection Operand { get; }

    public IType Type => new TypeDatetimeNullable();
}
