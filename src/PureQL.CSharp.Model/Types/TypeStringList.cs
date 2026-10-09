namespace PureQL.CSharp.Model.Types;

public sealed record TypeStringList : IType
{
    public string Name => "stringList";

    public bool Nullable => false;
}
