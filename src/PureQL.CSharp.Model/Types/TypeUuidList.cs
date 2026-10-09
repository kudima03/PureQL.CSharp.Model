namespace PureQL.CSharp.Model.Types;

public sealed record TypeUuidList : IType
{
    public string Name => "uuidList";

    public bool Nullable => false;
}
