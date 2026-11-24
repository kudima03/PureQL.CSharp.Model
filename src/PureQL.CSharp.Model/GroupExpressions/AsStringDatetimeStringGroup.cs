using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>asString.datetime.string@group</c>.</summary>
public sealed record AsStringDatetimeStringGroup : IOperator
{
    public AsStringDatetimeStringGroup(DatetimeGroup operand)
    {
        Operand = operand;
    }

    public DatetimeGroup Operand { get; }

    public IType Type => new TypeString();
}
