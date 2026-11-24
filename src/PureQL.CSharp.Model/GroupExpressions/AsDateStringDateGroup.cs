using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>asDate.string.date@group</c>.</summary>
public sealed record AsDateStringDateGroup : IOperator
{
    public AsDateStringDateGroup(StringGroup operand)
    {
        Operand = operand;
    }

    public StringGroup Operand { get; }

    public IType Type => new TypeDate();
}
