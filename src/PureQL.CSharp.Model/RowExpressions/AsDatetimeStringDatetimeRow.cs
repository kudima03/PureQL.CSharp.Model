using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>asDatetime.string.datetime@row</c>.</summary>
public sealed record AsDatetimeStringDatetimeRow : IOperator
{
    public AsDatetimeStringDatetimeRow(StringRow operand)
    {
        Operand = operand;
    }

    public StringRow Operand { get; }

    public IType Type => new TypeDatetime();
}
