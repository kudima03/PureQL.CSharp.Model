namespace PureQL.CSharp.Model.Types;

public sealed record TypeUuid : IType
{
    public string Name => "uuid";

    public bool Nullable => false;
}
