using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ArrayTypes;

public sealed record DateArrayType : IType
{
    public string Name => "dateArray";
}
