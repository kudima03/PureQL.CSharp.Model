using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>asString.date.string@total</c>.</summary>
public sealed record AsStringDateStringTotal : IOperator
{
    public AsStringDateStringTotal(DateTotal operand)
    {
        Operand = operand;
    }

    public DateTotal Operand { get; }

    public IType Type => new TypeString();
}
