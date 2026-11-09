namespace PureQL.CSharp.Model.Types;

/// <summary>PureQL <c>type.string</c>.</summary>
public sealed record TypeString : IType
{
    public string Name => "string";

    public bool Nullable => false;
}
