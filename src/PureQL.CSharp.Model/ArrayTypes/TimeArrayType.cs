using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ArrayTypes;

public sealed record TimeArrayType : IType
{
    public string Name => "timeArray";
}
