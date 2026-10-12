using OneOf;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class LessThanGroup
    : OneOfBase<
        LessThanDecimalGroup,
        LessThanStringGroup,
        LessThanBooleanGroup,
        LessThanDateGroup,
        LessThanTimeGroup,
        LessThanDatetimeGroup,
        LessThanUuidGroup
    >
{
    public LessThanGroup(LessThanDecimalGroup value)
        : this(
            (OneOf<
                LessThanDecimalGroup,
                LessThanStringGroup,
                LessThanBooleanGroup,
                LessThanDateGroup,
                LessThanTimeGroup,
                LessThanDatetimeGroup,
                LessThanUuidGroup
            >)
                value
        )
    { }

    public LessThanGroup(LessThanStringGroup value)
        : this(
            (OneOf<
                LessThanDecimalGroup,
                LessThanStringGroup,
                LessThanBooleanGroup,
                LessThanDateGroup,
                LessThanTimeGroup,
                LessThanDatetimeGroup,
                LessThanUuidGroup
            >)
                value
        )
    { }

    public LessThanGroup(LessThanBooleanGroup value)
        : this(
            (OneOf<
                LessThanDecimalGroup,
                LessThanStringGroup,
                LessThanBooleanGroup,
                LessThanDateGroup,
                LessThanTimeGroup,
                LessThanDatetimeGroup,
                LessThanUuidGroup
            >)
                value
        )
    { }

    public LessThanGroup(LessThanDateGroup value)
        : this(
            (OneOf<
                LessThanDecimalGroup,
                LessThanStringGroup,
                LessThanBooleanGroup,
                LessThanDateGroup,
                LessThanTimeGroup,
                LessThanDatetimeGroup,
                LessThanUuidGroup
            >)
                value
        )
    { }

    public LessThanGroup(LessThanTimeGroup value)
        : this(
            (OneOf<
                LessThanDecimalGroup,
                LessThanStringGroup,
                LessThanBooleanGroup,
                LessThanDateGroup,
                LessThanTimeGroup,
                LessThanDatetimeGroup,
                LessThanUuidGroup
            >)
                value
        )
    { }

    public LessThanGroup(LessThanDatetimeGroup value)
        : this(
            (OneOf<
                LessThanDecimalGroup,
                LessThanStringGroup,
                LessThanBooleanGroup,
                LessThanDateGroup,
                LessThanTimeGroup,
                LessThanDatetimeGroup,
                LessThanUuidGroup
            >)
                value
        )
    { }

    public LessThanGroup(LessThanUuidGroup value)
        : this(
            (OneOf<
                LessThanDecimalGroup,
                LessThanStringGroup,
                LessThanBooleanGroup,
                LessThanDateGroup,
                LessThanTimeGroup,
                LessThanDatetimeGroup,
                LessThanUuidGroup
            >)
                value
        )
    { }

    private LessThanGroup(
        OneOf<
            LessThanDecimalGroup,
            LessThanStringGroup,
            LessThanBooleanGroup,
            LessThanDateGroup,
            LessThanTimeGroup,
            LessThanDatetimeGroup,
            LessThanUuidGroup
        > input
    )
        : base(input) { }
}
