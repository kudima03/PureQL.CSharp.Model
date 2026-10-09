namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record FloorIntegerGroup
{
    public FloorIntegerGroup(DecimalGroup value)
    {
        Value = value;
    }

    public DecimalGroup Value { get; }
}
