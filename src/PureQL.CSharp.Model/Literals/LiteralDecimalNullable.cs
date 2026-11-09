using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Literals;

/// <summary>PureQL <c>literal.decimal.nullable</c>.</summary>
public sealed record LiteralDecimalNullable : ILiteral
{
    public IType Type => new TypeDecimalNullable();
}
