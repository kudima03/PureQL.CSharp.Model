using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>asDate.datetime.date.nullable@group</c>.</summary>
public sealed record AsDateDatetimeDateNullableGroup : IOperator
{
    public AsDateDatetimeDateNullableGroup(
        DatetimeNullableGroup operand,
        StringNullableGroup? zone = null
    )
    {
        Operand = operand;
        Zone = zone;
    }

    public DatetimeNullableGroup Operand { get; }

    public StringNullableGroup? Zone { get; }

    public IType Type => new TypeDateNullable();
}
