using PureQL.CSharp.Model.Lists;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>in.uuid@group</c>.</summary>
public sealed record InUuidGroup : IOperator
{
    public InUuidGroup(UuidNullableGroup operand, ListUuid list)
    {
        Operand = operand;
        List = list;
    }

    public UuidNullableGroup Operand { get; }

    public ListUuid List { get; }

    public IType Type => new TypeBoolean();
}
