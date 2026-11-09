using PureQL.CSharp.Model.Lists;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>in.time@projection</c>.</summary>
public sealed record InTimeProjection : IOperator
{
    public InTimeProjection(TimeNullableProjection operand, ListTime list)
    {
        Operand = operand;
        List = list;
    }

    public TimeNullableProjection Operand { get; }

    public ListTime List { get; }

    public IType Type => new TypeBoolean();
}
