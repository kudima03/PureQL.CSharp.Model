namespace PureQL.CSharp.Model.Types;

/// <summary>PureQL <c>type.datetimeList</c>.</summary>
public sealed record TypeDatetimeList : IType
{
    public string Name => "datetimeList";

    public bool Nullable => false;
}
