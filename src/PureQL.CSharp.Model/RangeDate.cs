namespace PureQL.CSharp.Model;

/// <summary>PureQL <c>range.date</c>.</summary>
public sealed record RangeDate
{
    public RangeDate(DistanceDate? preceding = null, DistanceDate? following = null)
    {
        Preceding = preceding;
        Following = following;
    }

    public DistanceDate? Preceding { get; }

    public DistanceDate? Following { get; }
}
