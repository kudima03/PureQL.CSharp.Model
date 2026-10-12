using PureQL.CSharp.Model.Lists;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed record InTimeTotal : IOperator
{
    public InTimeTotal(TimeNullableTotal operand, ListTime list)
    {
        Operand = operand;
        List = list;
    }

    public TimeNullableTotal Operand { get; }

    public ListTime List { get; }

    public IType Type => new TypeBoolean();
}
