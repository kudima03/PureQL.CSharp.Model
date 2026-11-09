using PureQL.CSharp.Model.Lists;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>in.date@projection</c>.</summary>
public sealed record InDateProjection : IOperator
{
    public InDateProjection(DateNullableProjection operand, ListDate list)
    {
        Operand = operand;
        List = list;
    }

    public DateNullableProjection Operand { get; }

    public ListDate List { get; }

    public IType Type => new TypeBoolean();
}
