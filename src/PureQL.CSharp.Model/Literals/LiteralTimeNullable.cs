using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Literals;

public sealed record LiteralTimeNullable : ILiteral
{
    public IType Type => new TypeTimeNullable();
}
