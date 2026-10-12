using OneOf;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class GreaterThanGroup
    : OneOfBase<
        GreaterThanDecimalGroup,
        GreaterThanStringGroup,
        GreaterThanBooleanGroup,
        GreaterThanDateGroup,
        GreaterThanTimeGroup,
        GreaterThanDatetimeGroup,
        GreaterThanUuidGroup
    >
{
    public GreaterThanGroup(GreaterThanDecimalGroup value)
        : this(
            (OneOf<
                GreaterThanDecimalGroup,
                GreaterThanStringGroup,
                GreaterThanBooleanGroup,
                GreaterThanDateGroup,
                GreaterThanTimeGroup,
                GreaterThanDatetimeGroup,
                GreaterThanUuidGroup
            >)
                value
        )
    { }

    public GreaterThanGroup(GreaterThanStringGroup value)
        : this(
            (OneOf<
                GreaterThanDecimalGroup,
                GreaterThanStringGroup,
                GreaterThanBooleanGroup,
                GreaterThanDateGroup,
                GreaterThanTimeGroup,
                GreaterThanDatetimeGroup,
                GreaterThanUuidGroup
            >)
                value
        )
    { }

    public GreaterThanGroup(GreaterThanBooleanGroup value)
        : this(
            (OneOf<
                GreaterThanDecimalGroup,
                GreaterThanStringGroup,
                GreaterThanBooleanGroup,
                GreaterThanDateGroup,
                GreaterThanTimeGroup,
                GreaterThanDatetimeGroup,
                GreaterThanUuidGroup
            >)
                value
        )
    { }

    public GreaterThanGroup(GreaterThanDateGroup value)
        : this(
            (OneOf<
                GreaterThanDecimalGroup,
                GreaterThanStringGroup,
                GreaterThanBooleanGroup,
                GreaterThanDateGroup,
                GreaterThanTimeGroup,
                GreaterThanDatetimeGroup,
                GreaterThanUuidGroup
            >)
                value
        )
    { }

    public GreaterThanGroup(GreaterThanTimeGroup value)
        : this(
            (OneOf<
                GreaterThanDecimalGroup,
                GreaterThanStringGroup,
                GreaterThanBooleanGroup,
                GreaterThanDateGroup,
                GreaterThanTimeGroup,
                GreaterThanDatetimeGroup,
                GreaterThanUuidGroup
            >)
                value
        )
    { }

    public GreaterThanGroup(GreaterThanDatetimeGroup value)
        : this(
            (OneOf<
                GreaterThanDecimalGroup,
                GreaterThanStringGroup,
                GreaterThanBooleanGroup,
                GreaterThanDateGroup,
                GreaterThanTimeGroup,
                GreaterThanDatetimeGroup,
                GreaterThanUuidGroup
            >)
                value
        )
    { }

    public GreaterThanGroup(GreaterThanUuidGroup value)
        : this(
            (OneOf<
                GreaterThanDecimalGroup,
                GreaterThanStringGroup,
                GreaterThanBooleanGroup,
                GreaterThanDateGroup,
                GreaterThanTimeGroup,
                GreaterThanDatetimeGroup,
                GreaterThanUuidGroup
            >)
                value
        )
    { }

    private GreaterThanGroup(
        OneOf<
            GreaterThanDecimalGroup,
            GreaterThanStringGroup,
            GreaterThanBooleanGroup,
            GreaterThanDateGroup,
            GreaterThanTimeGroup,
            GreaterThanDatetimeGroup,
            GreaterThanUuidGroup
        > input
    )
        : base(input) { }
}
