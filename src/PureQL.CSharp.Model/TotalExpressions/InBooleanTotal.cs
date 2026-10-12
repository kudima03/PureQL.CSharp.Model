using PureQL.CSharp.Model.Lists;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed record InBooleanTotal : IOperator
{
    public InBooleanTotal(BooleanNullableTotal operand, ListBoolean list)
    {
        Operand = operand;
        List = list;
    }

    public BooleanNullableTotal Operand { get; }

    public ListBoolean List { get; }

    public IType Type => new TypeBoolean();
}
