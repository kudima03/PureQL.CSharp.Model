using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>asString.time.string@row</c>.</summary>
public sealed record AsStringTimeStringRow : IOperator
{
    public AsStringTimeStringRow(TimeRow operand)
    {
        Operand = operand;
    }

    public TimeRow Operand { get; }

    public IType Type => new TypeString();
}
