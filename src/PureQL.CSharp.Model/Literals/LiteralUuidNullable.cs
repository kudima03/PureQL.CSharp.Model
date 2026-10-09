using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Literals;

public sealed record LiteralUuidNullable : ILiteral
{
    public IType Type => new TypeUuidNullable();
}
