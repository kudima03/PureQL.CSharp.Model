using PureQL.CSharp.Model.Lists;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>in.time@row</c>.</summary>
public sealed record InTimeRow : IOperator
{
    public InTimeRow(TimeNullableRow operand, ListTime list)
    {
        Operand = operand;
        List = list;
    }

    public TimeNullableRow Operand { get; }

    public ListTime List { get; }

    public IType Type => new TypeBoolean();
}
