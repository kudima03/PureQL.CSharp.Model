using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ArrayTypes;

public sealed record StringArrayType : IType
{
    public string Name => "stringArray";
}
