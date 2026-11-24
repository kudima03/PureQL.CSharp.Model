using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>startOfYear.datetime.nullable@group</c>.</summary>
public sealed record StartOfYearDatetimeNullableGroup : IOperator
{
    public StartOfYearDatetimeNullableGroup(
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
