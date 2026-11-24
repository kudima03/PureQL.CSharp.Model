using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>asString.datetime.string@total</c>.</summary>
public sealed record AsStringDatetimeStringTotal : IOperator
{
    public AsStringDatetimeStringTotal(DatetimeTotal operand)
    {
        Operand = operand;
    }

    public DatetimeTotal Operand { get; }

    public IType Type => new TypeString();
}
