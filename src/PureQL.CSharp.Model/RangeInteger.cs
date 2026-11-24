namespace PureQL.CSharp.Model;

/// <summary>PureQL <c>range.integer</c>.</summary>
public sealed record RangeInteger
{
    public RangeInteger(
        DistanceInteger? preceding = null,
        DistanceInteger? following = null
    )
    {
        Preceding = preceding;
        Following = following;
    }

    public DistanceInteger? Preceding { get; }

    public DistanceInteger? Following { get; }
}
