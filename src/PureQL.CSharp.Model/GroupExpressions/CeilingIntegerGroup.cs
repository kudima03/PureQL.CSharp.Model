namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record CeilingIntegerGroup
{
    public CeilingIntegerGroup(DecimalGroup value)
    {
        Value = value;
    }

    public DecimalGroup Value { get; }
}
