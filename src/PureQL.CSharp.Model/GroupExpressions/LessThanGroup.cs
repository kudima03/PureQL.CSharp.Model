using OneOf;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class LessThanGroup
    : OneOfBase<
        LessThanDecimalGroup,
        LessThanStringGroup,
        LessThanDateGroup,
        LessThanTimeGroup,
        LessThanDatetimeGroup
    >
{
    public LessThanGroup(LessThanDecimalGroup value)
        : this(
            (OneOf<
                LessThanDecimalGroup,
                LessThanStringGroup,
                LessThanDateGroup,
                LessThanTimeGroup,
                LessThanDatetimeGroup
            >)
                value
        )
    { }

    public LessThanGroup(LessThanStringGroup value)
        : this(
            (OneOf<
                LessThanDecimalGroup,
                LessThanStringGroup,
                LessThanDateGroup,
                LessThanTimeGroup,
                LessThanDatetimeGroup
            >)
                value
        )
    { }

    public LessThanGroup(LessThanDateGroup value)
        : this(
            (OneOf<
                LessThanDecimalGroup,
                LessThanStringGroup,
                LessThanDateGroup,
                LessThanTimeGroup,
                LessThanDatetimeGroup
            >)
                value
        )
    { }

    public LessThanGroup(LessThanTimeGroup value)
        : this(
            (OneOf<
                LessThanDecimalGroup,
                LessThanStringGroup,
                LessThanDateGroup,
                LessThanTimeGroup,
                LessThanDatetimeGroup
            >)
                value
        )
    { }

    public LessThanGroup(LessThanDatetimeGroup value)
        : this(
            (OneOf<
                LessThanDecimalGroup,
                LessThanStringGroup,
                LessThanDateGroup,
                LessThanTimeGroup,
                LessThanDatetimeGroup
            >)
                value
        )
    { }

    private LessThanGroup(
        OneOf<
            LessThanDecimalGroup,
            LessThanStringGroup,
            LessThanDateGroup,
            LessThanTimeGroup,
            LessThanDatetimeGroup
        > input
    )
        : base(input) { }
}
