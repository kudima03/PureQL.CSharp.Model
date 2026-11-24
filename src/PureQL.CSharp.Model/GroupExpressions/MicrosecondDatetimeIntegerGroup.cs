using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>microsecond.datetime.integer@group</c>.</summary>
public sealed record MicrosecondDatetimeIntegerGroup : IOperator
{
    public MicrosecondDatetimeIntegerGroup(DatetimeGroup operand)
    {
        Operand = operand;
    }

    public DatetimeGroup Operand { get; }

    public IType Type => new TypeInteger();
}
