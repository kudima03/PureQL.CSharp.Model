using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>asString.time.string@total</c>.</summary>
public sealed record AsStringTimeStringTotal : IOperator
{
    public AsStringTimeStringTotal(TimeTotal operand)
    {
        Operand = operand;
    }

    public TimeTotal Operand { get; }

    public IType Type => new TypeString();
}
