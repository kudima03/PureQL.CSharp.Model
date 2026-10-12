using OneOf;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class IntegerNullableGroup
    : OneOfBase<IntegerGroup, ExactIntegerNullableGroup>
{
    public IntegerNullableGroup(IntegerGroup value)
        : this((OneOf<IntegerGroup, ExactIntegerNullableGroup>)value) { }

    public IntegerNullableGroup(ExactIntegerNullableGroup value)
        : this((OneOf<IntegerGroup, ExactIntegerNullableGroup>)value) { }

    private IntegerNullableGroup(OneOf<IntegerGroup, ExactIntegerNullableGroup> input)
        : base(input) { }
}
