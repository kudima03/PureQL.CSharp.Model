using PureQL.CSharp.Model.Lists;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed record InDateRow : IOperator
{
    public InDateRow(DateNullableRow operand, ListDate list)
    {
        Operand = operand;
        List = list;
    }

    public DateNullableRow Operand { get; }

    public ListDate List { get; }

    public IType Type => new TypeBoolean();
}
