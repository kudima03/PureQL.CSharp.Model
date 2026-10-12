using OneOf;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class UuidNullableGroup : OneOfBase<UuidGroup, ExactUuidNullableGroup>
{
    public UuidNullableGroup(UuidGroup value)
        : this((OneOf<UuidGroup, ExactUuidNullableGroup>)value) { }

    public UuidNullableGroup(ExactUuidNullableGroup value)
        : this((OneOf<UuidGroup, ExactUuidNullableGroup>)value) { }

    private UuidNullableGroup(OneOf<UuidGroup, ExactUuidNullableGroup> input)
        : base(input) { }
}
