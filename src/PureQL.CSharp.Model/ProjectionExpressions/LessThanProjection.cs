using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class LessThanProjection
    : OneOfBase<
        LessThanDecimalProjection,
        LessThanStringProjection,
        LessThanDateProjection,
        LessThanTimeProjection,
        LessThanDatetimeProjection
    >
{
    public LessThanProjection(LessThanDecimalProjection value)
        : this(
            (OneOf<
                LessThanDecimalProjection,
                LessThanStringProjection,
                LessThanDateProjection,
                LessThanTimeProjection,
                LessThanDatetimeProjection
            >)
                value
        )
    { }

    public LessThanProjection(LessThanStringProjection value)
        : this(
            (OneOf<
                LessThanDecimalProjection,
                LessThanStringProjection,
                LessThanDateProjection,
                LessThanTimeProjection,
                LessThanDatetimeProjection
            >)
                value
        )
    { }

    public LessThanProjection(LessThanDateProjection value)
        : this(
            (OneOf<
                LessThanDecimalProjection,
                LessThanStringProjection,
                LessThanDateProjection,
                LessThanTimeProjection,
                LessThanDatetimeProjection
            >)
                value
        )
    { }

    public LessThanProjection(LessThanTimeProjection value)
        : this(
            (OneOf<
                LessThanDecimalProjection,
                LessThanStringProjection,
                LessThanDateProjection,
                LessThanTimeProjection,
                LessThanDatetimeProjection
            >)
                value
        )
    { }

    public LessThanProjection(LessThanDatetimeProjection value)
        : this(
            (OneOf<
                LessThanDecimalProjection,
                LessThanStringProjection,
                LessThanDateProjection,
                LessThanTimeProjection,
                LessThanDatetimeProjection
            >)
                value
        )
    { }

    private LessThanProjection(
        OneOf<
            LessThanDecimalProjection,
            LessThanStringProjection,
            LessThanDateProjection,
            LessThanTimeProjection,
            LessThanDatetimeProjection
        > input
    )
        : base(input) { }
}
