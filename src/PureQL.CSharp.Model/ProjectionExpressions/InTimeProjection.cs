using PureQL.CSharp.Model.Lists;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record InTimeProjection : IOperator
{
    public InTimeProjection(TimeNullableProjection operand, ListTime list)
    {
        Operand = operand;
        List = list;
    }

    public TimeNullableProjection Operand { get; }

    public ListTime List { get; }

    public IType Type => new TypeBoolean();
}
