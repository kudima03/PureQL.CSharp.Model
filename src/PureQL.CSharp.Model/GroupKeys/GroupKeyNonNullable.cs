using OneOf;

namespace PureQL.CSharp.Model.GroupKeys;

public sealed class GroupKeyNonNullable
    : OneOfBase<
        GroupKeyInteger,
        GroupKeyDecimal,
        GroupKeyString,
        GroupKeyBoolean,
        GroupKeyDate,
        GroupKeyTime,
        GroupKeyDatetime,
        GroupKeyUuid
    >
{
    public GroupKeyNonNullable(GroupKeyInteger value)
        : this(
            (OneOf<
                GroupKeyInteger,
                GroupKeyDecimal,
                GroupKeyString,
                GroupKeyBoolean,
                GroupKeyDate,
                GroupKeyTime,
                GroupKeyDatetime,
                GroupKeyUuid
            >)
                value
        )
    { }

    public GroupKeyNonNullable(GroupKeyDecimal value)
        : this(
            (OneOf<
                GroupKeyInteger,
                GroupKeyDecimal,
                GroupKeyString,
                GroupKeyBoolean,
                GroupKeyDate,
                GroupKeyTime,
                GroupKeyDatetime,
                GroupKeyUuid
            >)
                value
        )
    { }

    public GroupKeyNonNullable(GroupKeyString value)
        : this(
            (OneOf<
                GroupKeyInteger,
                GroupKeyDecimal,
                GroupKeyString,
                GroupKeyBoolean,
                GroupKeyDate,
                GroupKeyTime,
                GroupKeyDatetime,
                GroupKeyUuid
            >)
                value
        )
    { }

    public GroupKeyNonNullable(GroupKeyBoolean value)
        : this(
            (OneOf<
                GroupKeyInteger,
                GroupKeyDecimal,
                GroupKeyString,
                GroupKeyBoolean,
                GroupKeyDate,
                GroupKeyTime,
                GroupKeyDatetime,
                GroupKeyUuid
            >)
                value
        )
    { }

    public GroupKeyNonNullable(GroupKeyDate value)
        : this(
            (OneOf<
                GroupKeyInteger,
                GroupKeyDecimal,
                GroupKeyString,
                GroupKeyBoolean,
                GroupKeyDate,
                GroupKeyTime,
                GroupKeyDatetime,
                GroupKeyUuid
            >)
                value
        )
    { }

    public GroupKeyNonNullable(GroupKeyTime value)
        : this(
            (OneOf<
                GroupKeyInteger,
                GroupKeyDecimal,
                GroupKeyString,
                GroupKeyBoolean,
                GroupKeyDate,
                GroupKeyTime,
                GroupKeyDatetime,
                GroupKeyUuid
            >)
                value
        )
    { }

    public GroupKeyNonNullable(GroupKeyDatetime value)
        : this(
            (OneOf<
                GroupKeyInteger,
                GroupKeyDecimal,
                GroupKeyString,
                GroupKeyBoolean,
                GroupKeyDate,
                GroupKeyTime,
                GroupKeyDatetime,
                GroupKeyUuid
            >)
                value
        )
    { }

    public GroupKeyNonNullable(GroupKeyUuid value)
        : this(
            (OneOf<
                GroupKeyInteger,
                GroupKeyDecimal,
                GroupKeyString,
                GroupKeyBoolean,
                GroupKeyDate,
                GroupKeyTime,
                GroupKeyDatetime,
                GroupKeyUuid
            >)
                value
        )
    { }

    private GroupKeyNonNullable(
        OneOf<
            GroupKeyInteger,
            GroupKeyDecimal,
            GroupKeyString,
            GroupKeyBoolean,
            GroupKeyDate,
            GroupKeyTime,
            GroupKeyDatetime,
            GroupKeyUuid
        > input
    )
        : base(input) { }
}
