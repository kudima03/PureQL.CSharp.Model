using PureQL.CSharp.Model.Lists;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>in.uuid@row</c>.</summary>
public sealed record InUuidRow : IOperator
{
    public InUuidRow(UuidNullableRow operand, ListUuid list)
    {
        Operand = operand;
        List = list;
    }

    public UuidNullableRow Operand { get; }

    public ListUuid List { get; }

    public IType Type => new TypeBoolean();
}
