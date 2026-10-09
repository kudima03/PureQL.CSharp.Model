using OneOf;

namespace PureQL.CSharp.Model.GroupKeys;

public sealed class GroupKeyNullable
    : OneOfBase<
        GroupKeyIntegerNullable,
        GroupKeyDecimalNullable,
        GroupKeyStringNullable,
        GroupKeyBooleanNullable,
        GroupKeyDateNullable,
        GroupKeyTimeNullable,
        GroupKeyDatetimeNullable,
        GroupKeyUuidNullable
    >
{
    public GroupKeyNullable(GroupKeyIntegerNullable value)
        : this(
            (OneOf<
                GroupKeyIntegerNullable,
                GroupKeyDecimalNullable,
                GroupKeyStringNullable,
                GroupKeyBooleanNullable,
                GroupKeyDateNullable,
                GroupKeyTimeNullable,
                GroupKeyDatetimeNullable,
                GroupKeyUuidNullable
            >)
                value
        )
    { }

    public GroupKeyNullable(GroupKeyDecimalNullable value)
        : this(
            (OneOf<
                GroupKeyIntegerNullable,
                GroupKeyDecimalNullable,
                GroupKeyStringNullable,
                GroupKeyBooleanNullable,
                GroupKeyDateNullable,
                GroupKeyTimeNullable,
                GroupKeyDatetimeNullable,
                GroupKeyUuidNullable
            >)
                value
        )
    { }

    public GroupKeyNullable(GroupKeyStringNullable value)
        : this(
            (OneOf<
                GroupKeyIntegerNullable,
                GroupKeyDecimalNullable,
                GroupKeyStringNullable,
                GroupKeyBooleanNullable,
                GroupKeyDateNullable,
                GroupKeyTimeNullable,
                GroupKeyDatetimeNullable,
                GroupKeyUuidNullable
            >)
                value
        )
    { }

    public GroupKeyNullable(GroupKeyBooleanNullable value)
        : this(
            (OneOf<
                GroupKeyIntegerNullable,
                GroupKeyDecimalNullable,
                GroupKeyStringNullable,
                GroupKeyBooleanNullable,
                GroupKeyDateNullable,
                GroupKeyTimeNullable,
                GroupKeyDatetimeNullable,
                GroupKeyUuidNullable
            >)
                value
        )
    { }

    public GroupKeyNullable(GroupKeyDateNullable value)
        : this(
            (OneOf<
                GroupKeyIntegerNullable,
                GroupKeyDecimalNullable,
                GroupKeyStringNullable,
                GroupKeyBooleanNullable,
                GroupKeyDateNullable,
                GroupKeyTimeNullable,
                GroupKeyDatetimeNullable,
                GroupKeyUuidNullable
            >)
                value
        )
    { }

    public GroupKeyNullable(GroupKeyTimeNullable value)
        : this(
            (OneOf<
                GroupKeyIntegerNullable,
                GroupKeyDecimalNullable,
                GroupKeyStringNullable,
                GroupKeyBooleanNullable,
                GroupKeyDateNullable,
                GroupKeyTimeNullable,
                GroupKeyDatetimeNullable,
                GroupKeyUuidNullable
            >)
                value
        )
    { }

    public GroupKeyNullable(GroupKeyDatetimeNullable value)
        : this(
            (OneOf<
                GroupKeyIntegerNullable,
                GroupKeyDecimalNullable,
                GroupKeyStringNullable,
                GroupKeyBooleanNullable,
                GroupKeyDateNullable,
                GroupKeyTimeNullable,
                GroupKeyDatetimeNullable,
                GroupKeyUuidNullable
            >)
                value
        )
    { }

    public GroupKeyNullable(GroupKeyUuidNullable value)
        : this(
            (OneOf<
                GroupKeyIntegerNullable,
                GroupKeyDecimalNullable,
                GroupKeyStringNullable,
                GroupKeyBooleanNullable,
                GroupKeyDateNullable,
                GroupKeyTimeNullable,
                GroupKeyDatetimeNullable,
                GroupKeyUuidNullable
            >)
                value
        )
    { }

    private GroupKeyNullable(
        OneOf<
            GroupKeyIntegerNullable,
            GroupKeyDecimalNullable,
            GroupKeyStringNullable,
            GroupKeyBooleanNullable,
            GroupKeyDateNullable,
            GroupKeyTimeNullable,
            GroupKeyDatetimeNullable,
            GroupKeyUuidNullable
        > input
    )
        : base(input) { }
}
