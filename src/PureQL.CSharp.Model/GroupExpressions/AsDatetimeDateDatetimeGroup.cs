using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>asDatetime.date.datetime@group</c>.</summary>
public sealed record AsDatetimeDateDatetimeGroup : IOperator
{
    public AsDatetimeDateDatetimeGroup(DateGroup operand, StringGroup? zone = null)
    {
        Operand = operand;
        Zone = zone;
    }

    public DateGroup Operand { get; }

    public StringGroup? Zone { get; }

    public IType Type => new TypeDatetime();
}
