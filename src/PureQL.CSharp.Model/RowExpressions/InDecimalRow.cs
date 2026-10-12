using PureQL.CSharp.Model.Lists;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed record InDecimalRow : IOperator
{
    public InDecimalRow(DecimalNullableRow operand, ListDecimal list)
    {
        Operand = operand;
        List = list;
    }

    public DecimalNullableRow Operand { get; }

    public ListDecimal List { get; }

    public IType Type => new TypeBoolean();
}
