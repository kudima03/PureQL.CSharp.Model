using OneOf;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class DecimalGroup : OneOfBase<ExactDecimalGroup, IntegerGroup>
{
    public DecimalGroup(ExactDecimalGroup value)
        : this((OneOf<ExactDecimalGroup, IntegerGroup>)value) { }

    public DecimalGroup(IntegerGroup value)
        : this((OneOf<ExactDecimalGroup, IntegerGroup>)value) { }

    private DecimalGroup(OneOf<ExactDecimalGroup, IntegerGroup> input)
        : base(input) { }
}
