using PureQL.CSharp.Model.Lists;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed record InUuidTotal : IOperator
{
    public InUuidTotal(UuidNullableTotal operand, ListUuid list)
    {
        Operand = operand;
        List = list;
    }

    public UuidNullableTotal Operand { get; }

    public ListUuid List { get; }

    public IType Type => new TypeBoolean();
}
