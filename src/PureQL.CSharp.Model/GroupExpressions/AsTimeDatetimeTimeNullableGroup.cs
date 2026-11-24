using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>asTime.datetime.time.nullable@group</c>.</summary>
public sealed record AsTimeDatetimeTimeNullableGroup : IOperator
{
    public AsTimeDatetimeTimeNullableGroup(
        DatetimeNullableGroup operand,
        StringNullableGroup? zone = null
    )
    {
        Operand = operand;
        Zone = zone;
    }

    public DatetimeNullableGroup Operand { get; }

    public StringNullableGroup? Zone { get; }

    public IType Type => new TypeTimeNullable();
}
