using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ArrayTypes;

public sealed record UuidArrayType : IType
{
    public string Name => "uuidArray";
}
