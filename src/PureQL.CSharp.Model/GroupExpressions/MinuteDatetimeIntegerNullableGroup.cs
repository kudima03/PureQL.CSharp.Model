using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>minute.datetime.integer.nullable@group</c>.</summary>
public sealed record MinuteDatetimeIntegerNullableGroup : IOperator
{
    public MinuteDatetimeIntegerNullableGroup(
        DatetimeNullableGroup operand,
        StringNullableGroup? zone = null
    )
    {
        Operand = operand;
        Zone = zone;
    }

    public DatetimeNullableGroup Operand { get; }

    public StringNullableGroup? Zone { get; }

    public IType Type => new TypeIntegerNullable();
}
