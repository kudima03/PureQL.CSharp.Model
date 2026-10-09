namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record RoundIntegerGroup
{
    public RoundIntegerGroup(DecimalGroup value)
    {
        Value = value;
    }

    public DecimalGroup Value { get; }
}
