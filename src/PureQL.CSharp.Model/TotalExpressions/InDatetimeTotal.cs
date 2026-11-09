using PureQL.CSharp.Model.Lists;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>in.datetime@total</c>.</summary>
public sealed record InDatetimeTotal : IOperator
{
    public InDatetimeTotal(DatetimeNullableTotal operand, ListDatetime list)
    {
        Operand = operand;
        List = list;
    }

    public DatetimeNullableTotal Operand { get; }

    public ListDatetime List { get; }

    public IType Type => new TypeBoolean();
}
