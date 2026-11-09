using PureQL.CSharp.Model.Lists;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>in.boolean@projection</c>.</summary>
public sealed record InBooleanProjection : IOperator
{
    public InBooleanProjection(BooleanNullableProjection operand, ListBoolean list)
    {
        Operand = operand;
        List = list;
    }

    public BooleanNullableProjection Operand { get; }

    public ListBoolean List { get; }

    public IType Type => new TypeBoolean();
}
