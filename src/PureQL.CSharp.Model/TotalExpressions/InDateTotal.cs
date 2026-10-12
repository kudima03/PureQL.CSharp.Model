using PureQL.CSharp.Model.Lists;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed record InDateTotal : IOperator
{
    public InDateTotal(DateNullableTotal operand, ListDate list)
    {
        Operand = operand;
        List = list;
    }

    public DateNullableTotal Operand { get; }

    public ListDate List { get; }

    public IType Type => new TypeBoolean();
}
