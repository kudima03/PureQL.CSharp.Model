using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>startOfQuarter.datetime.nullable@group</c>.</summary>
public sealed record StartOfQuarterDatetimeNullableGroup : IOperator
{
    public StartOfQuarterDatetimeNullableGroup(
        DatetimeNullableGroup operand,
        StringNullableGroup? zone = null
    )
    {
        Operand = operand;
        Zone = zone;
    }

    public DatetimeNullableGroup Operand { get; }

    public StringNullableGroup? Zone { get; }

    public IType Type => new TypeDatetimeNullable();
}
