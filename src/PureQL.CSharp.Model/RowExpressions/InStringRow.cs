using PureQL.CSharp.Model.Lists;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>in.string@row</c>.</summary>
public sealed record InStringRow : IOperator
{
    public InStringRow(StringNullableRow operand, ListString list)
    {
        Operand = operand;
        List = list;
    }

    public StringNullableRow Operand { get; }

    public ListString List { get; }

    public IType Type => new TypeBoolean();
}
