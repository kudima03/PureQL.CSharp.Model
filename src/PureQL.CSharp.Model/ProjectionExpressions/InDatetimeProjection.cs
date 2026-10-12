using PureQL.CSharp.Model.Lists;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record InDatetimeProjection : IOperator
{
    public InDatetimeProjection(DatetimeNullableProjection operand, ListDatetime list)
    {
        Operand = operand;
        List = list;
    }

    public DatetimeNullableProjection Operand { get; }

    public ListDatetime List { get; }

    public IType Type => new TypeBoolean();
}
