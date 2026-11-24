using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>pi@row</c>.</summary>
public sealed record PiRow : IOperator
{
    public IType Type => new TypeDecimal();
}
