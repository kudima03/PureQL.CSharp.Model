using PureQL.CSharp.Model.Lists;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record InDecimalProjection : IOperator
{
    public InDecimalProjection(DecimalNullableProjection operand, ListDecimal list)
    {
        Operand = operand;
        List = list;
    }

    public DecimalNullableProjection Operand { get; }

    public ListDecimal List { get; }

    public IType Type => new TypeBoolean();
}
