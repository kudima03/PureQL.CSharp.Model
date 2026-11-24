using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>startOfSecond.datetime@row</c>.</summary>
public sealed record StartOfSecondDatetimeRow : IOperator
{
    public StartOfSecondDatetimeRow(DatetimeRow operand)
    {
        Operand = operand;
    }

    public DatetimeRow Operand { get; }

    public IType Type => new TypeDatetime();
}
