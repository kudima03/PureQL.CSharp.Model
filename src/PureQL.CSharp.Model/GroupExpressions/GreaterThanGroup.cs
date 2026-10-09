using OneOf;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class GreaterThanGroup
    : OneOfBase<
        GreaterThanDecimalGroup,
        GreaterThanStringGroup,
        GreaterThanDateGroup,
        GreaterThanTimeGroup,
        GreaterThanDatetimeGroup
    >
{
    public GreaterThanGroup(GreaterThanDecimalGroup value)
        : this(
            (OneOf<
                GreaterThanDecimalGroup,
                GreaterThanStringGroup,
                GreaterThanDateGroup,
                GreaterThanTimeGroup,
                GreaterThanDatetimeGroup
            >)
                value
        )
    { }

    public GreaterThanGroup(GreaterThanStringGroup value)
        : this(
            (OneOf<
                GreaterThanDecimalGroup,
                GreaterThanStringGroup,
                GreaterThanDateGroup,
                GreaterThanTimeGroup,
                GreaterThanDatetimeGroup
            >)
                value
        )
    { }

    public GreaterThanGroup(GreaterThanDateGroup value)
        : this(
            (OneOf<
                GreaterThanDecimalGroup,
                GreaterThanStringGroup,
                GreaterThanDateGroup,
                GreaterThanTimeGroup,
                GreaterThanDatetimeGroup
            >)
                value
        )
    { }

    public GreaterThanGroup(GreaterThanTimeGroup value)
        : this(
            (OneOf<
                GreaterThanDecimalGroup,
                GreaterThanStringGroup,
                GreaterThanDateGroup,
                GreaterThanTimeGroup,
                GreaterThanDatetimeGroup
            >)
                value
        )
    { }

    public GreaterThanGroup(GreaterThanDatetimeGroup value)
        : this(
            (OneOf<
                GreaterThanDecimalGroup,
                GreaterThanStringGroup,
                GreaterThanDateGroup,
                GreaterThanTimeGroup,
                GreaterThanDatetimeGroup
            >)
                value
        )
    { }

    private GreaterThanGroup(
        OneOf<
            GreaterThanDecimalGroup,
            GreaterThanStringGroup,
            GreaterThanDateGroup,
            GreaterThanTimeGroup,
            GreaterThanDatetimeGroup
        > input
    )
        : base(input) { }
}
