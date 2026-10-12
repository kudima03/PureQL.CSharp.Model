using OneOf;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class BooleanNullableGroup
    : OneOfBase<BooleanGroup, ExactBooleanNullableGroup>
{
    public BooleanNullableGroup(BooleanGroup value)
        : this((OneOf<BooleanGroup, ExactBooleanNullableGroup>)value) { }

    public BooleanNullableGroup(ExactBooleanNullableGroup value)
        : this((OneOf<BooleanGroup, ExactBooleanNullableGroup>)value) { }

    private BooleanNullableGroup(OneOf<BooleanGroup, ExactBooleanNullableGroup> input)
        : base(input) { }
}
