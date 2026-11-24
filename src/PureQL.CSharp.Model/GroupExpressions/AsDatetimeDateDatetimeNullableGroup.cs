using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>asDatetime.date.datetime.nullable@group</c>.</summary>
public sealed record AsDatetimeDateDatetimeNullableGroup : IOperator
{
    public AsDatetimeDateDatetimeNullableGroup(
        DateNullableGroup operand,
        StringNullableGroup? zone = null
    )
    {
        Operand = operand;
        Zone = zone;
    }

    public DateNullableGroup Operand { get; }

    public StringNullableGroup? Zone { get; }

    public IType Type => new TypeDatetimeNullable();
}
