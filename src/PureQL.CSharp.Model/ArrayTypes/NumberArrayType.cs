using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ArrayTypes;

public sealed record NumberArrayType : IType
{
    public string Name => "numberArray";
}
