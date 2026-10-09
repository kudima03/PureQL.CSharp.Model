using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Literals;

public sealed record LiteralBooleanNullable : ILiteral
{
    public IType Type => new TypeBooleanNullable();
}
