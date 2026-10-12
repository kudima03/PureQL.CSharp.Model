using PureQL.CSharp.Model.Lists;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

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
