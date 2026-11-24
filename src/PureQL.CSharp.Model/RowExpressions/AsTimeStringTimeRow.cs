using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>asTime.string.time@row</c>.</summary>
public sealed record AsTimeStringTimeRow : IOperator
{
    public AsTimeStringTimeRow(StringRow operand)
    {
        Operand = operand;
    }

    public StringRow Operand { get; }

    public IType Type => new TypeTime();
}
