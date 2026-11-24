namespace PureQL.CSharp.Model;

/// <summary>PureQL <c>range.datetime</c>.</summary>
public sealed record RangeDatetime
{
    public RangeDatetime(
        DistanceDatetime? preceding = null,
        DistanceDatetime? following = null
    )
    {
        Preceding = preceding;
        Following = following;
    }

    public DistanceDatetime? Preceding { get; }

    public DistanceDatetime? Following { get; }
}
