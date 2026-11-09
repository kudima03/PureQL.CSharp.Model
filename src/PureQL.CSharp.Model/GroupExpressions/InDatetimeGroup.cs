using PureQL.CSharp.Model.Lists;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>in.datetime@group</c>.</summary>
public sealed record InDatetimeGroup : IOperator
{
    public InDatetimeGroup(DatetimeNullableGroup operand, ListDatetime list)
    {
        Operand = operand;
        List = list;
    }

    public DatetimeNullableGroup Operand { get; }

    public ListDatetime List { get; }

    public IType Type => new TypeBoolean();
}
