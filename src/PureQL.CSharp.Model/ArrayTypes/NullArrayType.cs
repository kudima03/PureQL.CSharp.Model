using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ArrayTypes;

public sealed record NullArrayType : IType
{
    public string Name => "nullArray";
}
