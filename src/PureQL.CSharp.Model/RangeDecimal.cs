namespace PureQL.CSharp.Model;

/// <summary>PureQL <c>range.decimal</c>.</summary>
public sealed record RangeDecimal
{
    public RangeDecimal(
        DistanceDecimal? preceding = null,
        DistanceDecimal? following = null
    )
    {
        Preceding = preceding;
        Following = following;
    }

    public DistanceDecimal? Preceding { get; }

    public DistanceDecimal? Following { get; }
}
