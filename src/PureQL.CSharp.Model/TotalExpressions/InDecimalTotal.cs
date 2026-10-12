using PureQL.CSharp.Model.Lists;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed record InDecimalTotal : IOperator
{
    public InDecimalTotal(DecimalNullableTotal operand, ListDecimal list)
    {
        Operand = operand;
        List = list;
    }

    public DecimalNullableTotal Operand { get; }

    public ListDecimal List { get; }

    public IType Type => new TypeBoolean();
}
