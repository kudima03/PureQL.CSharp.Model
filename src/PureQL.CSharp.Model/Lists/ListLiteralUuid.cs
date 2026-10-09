using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Lists;

public sealed record ListLiteralUuid : ILiteral
{
    public ListLiteralUuid(IEnumerable<Guid> value)
    {
        Value = value;
    }

    public IEnumerable<Guid> Value { get; }

    public IType Type => new TypeUuidList();
}
