using PureQL.CSharp.Model.Lists;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record InUuidProjection : IOperator
{
    public InUuidProjection(UuidNullableProjection operand, ListUuid list)
    {
        Operand = operand;
        List = list;
    }

    public UuidNullableProjection Operand { get; }

    public ListUuid List { get; }

    public IType Type => new TypeBoolean();
}
