using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>trimStart.string.nullable@projection</c>.</summary>
public sealed record TrimStartStringNullableProjection : IOperator
{
    public TrimStartStringNullableProjection(
        DeclaresStringNullableProjection operand,
        IEnumerable<StringProjection> removables
    )
    {
        Operand = operand;
        Removables = removables;
    }

    public DeclaresStringNullableProjection Operand { get; }

    public IEnumerable<StringProjection> Removables { get; }

    public IType Type => new TypeStringNullable();
}
