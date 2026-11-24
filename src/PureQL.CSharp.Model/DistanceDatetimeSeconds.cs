namespace PureQL.CSharp.Model;

public sealed record DistanceDatetimeSeconds
{
    public DistanceDatetimeSeconds(DistanceDatetimeSecondsSeconds seconds)
    {
        Seconds = seconds;
    }

    public DistanceDatetimeSecondsSeconds Seconds { get; }
}
