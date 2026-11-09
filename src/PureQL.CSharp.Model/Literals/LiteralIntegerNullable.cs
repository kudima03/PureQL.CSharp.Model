using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Literals;

/// <summary>PureQL <c>literal.integer.nullable</c>.</summary>
public sealed record LiteralIntegerNullable : ILiteral
{
    public IType Type => new TypeIntegerNullable();
}
