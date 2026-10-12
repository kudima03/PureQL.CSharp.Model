using PureQL.CSharp.Model.Lists;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed record InBooleanRow : IOperator
{
    public InBooleanRow(BooleanNullableRow operand, ListBoolean list)
    {
        Operand = operand;
        List = list;
    }

    public BooleanNullableRow Operand { get; }

    public ListBoolean List { get; }

    public IType Type => new TypeBoolean();
}
