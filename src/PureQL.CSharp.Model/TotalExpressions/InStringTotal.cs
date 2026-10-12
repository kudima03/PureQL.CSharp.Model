using PureQL.CSharp.Model.Lists;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed record InStringTotal : IOperator
{
    public InStringTotal(StringNullableTotal operand, ListString list)
    {
        Operand = operand;
        List = list;
    }

    public StringNullableTotal Operand { get; }

    public ListString List { get; }

    public IType Type => new TypeBoolean();
}
