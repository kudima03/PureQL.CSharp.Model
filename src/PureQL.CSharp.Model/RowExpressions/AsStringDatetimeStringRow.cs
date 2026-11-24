using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>asString.datetime.string@row</c>.</summary>
public sealed record AsStringDatetimeStringRow : IOperator
{
    public AsStringDatetimeStringRow(DatetimeRow operand)
    {
        Operand = operand;
    }

    public DatetimeRow Operand { get; }

    public IType Type => new TypeString();
}
