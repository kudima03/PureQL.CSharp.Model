namespace PureQL.CSharp.Model.Types;

public sealed record TypeUuidNullable : IType
{
    public string Name => "uuid";

    public bool Nullable => true;
}
