using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>asDatetime.string.datetime@group</c>.</summary>
public sealed record AsDatetimeStringDatetimeGroup : IOperator
{
    public AsDatetimeStringDatetimeGroup(StringGroup operand)
    {
        Operand = operand;
    }

    public StringGroup Operand { get; }

    public IType Type => new TypeDatetime();
}
