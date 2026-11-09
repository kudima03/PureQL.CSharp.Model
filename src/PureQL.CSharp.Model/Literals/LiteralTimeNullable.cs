using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Literals;

/// <summary>PureQL <c>literal.time.nullable</c>.</summary>
public sealed record LiteralTimeNullable : ILiteral
{
    public IType Type => new TypeTimeNullable();
}
