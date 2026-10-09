using OneOf;

namespace PureQL.CSharp.Model.GroupKeys;

public sealed class GroupKey : OneOfBase<GroupKeyNonNullable, GroupKeyNullable>
{
    public GroupKey(GroupKeyNonNullable value)
        : this((OneOf<GroupKeyNonNullable, GroupKeyNullable>)value) { }

    public GroupKey(GroupKeyNullable value)
        : this((OneOf<GroupKeyNonNullable, GroupKeyNullable>)value) { }

    private GroupKey(OneOf<GroupKeyNonNullable, GroupKeyNullable> input)
        : base(input) { }
}
