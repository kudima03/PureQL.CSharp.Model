using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>asString.date.string@row</c>.</summary>
public sealed record AsStringDateStringRow : IOperator
{
    public AsStringDateStringRow(DateRow operand)
    {
        Operand = operand;
    }

    public DateRow Operand { get; }

    public IType Type => new TypeString();
}
