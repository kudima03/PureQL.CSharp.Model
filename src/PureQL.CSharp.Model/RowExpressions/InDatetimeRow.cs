using PureQL.CSharp.Model.Lists;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed record InDatetimeRow : IOperator
{
    public InDatetimeRow(DatetimeNullableRow operand, ListDatetime list)
    {
        Operand = operand;
        List = list;
    }

    public DatetimeNullableRow Operand { get; }

    public ListDatetime List { get; }

    public IType Type => new TypeBoolean();
}
