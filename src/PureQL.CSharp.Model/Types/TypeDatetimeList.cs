namespace PureQL.CSharp.Model.Types;

public sealed record TypeDatetimeList : IType
{
    public string Name => "datetimeList";

    public bool Nullable => false;
}
