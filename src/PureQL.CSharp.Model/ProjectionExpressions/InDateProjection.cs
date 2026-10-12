using PureQL.CSharp.Model.Lists;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

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
