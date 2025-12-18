namespace PureQL.CSharp.Model.Types;

public sealed record NullType : IType
{
    public string Name => "null";
}
