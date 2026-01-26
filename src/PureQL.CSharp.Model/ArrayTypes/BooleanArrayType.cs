using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ArrayTypes;

public sealed record BooleanArrayType : IType
{
    public string Name => "booleanArray";
}
