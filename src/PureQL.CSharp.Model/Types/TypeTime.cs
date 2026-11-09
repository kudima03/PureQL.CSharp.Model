namespace PureQL.CSharp.Model.Types;

/// <summary>PureQL <c>type.time</c>.</summary>
public sealed record TypeTime : IType
{
    public string Name => "time";

    public bool Nullable => false;
}
