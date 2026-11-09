using PureQL.CSharp.Model.Lists;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>in.decimal@group</c>.</summary>
public sealed record InDecimalGroup : IOperator
{
    public InDecimalGroup(DecimalNullableGroup operand, ListDecimal list)
    {
        Operand = operand;
        List = list;
    }

    public DecimalNullableGroup Operand { get; }

    public ListDecimal List { get; }

    public IType Type => new TypeBoolean();
}
