using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class GreaterThanProjection
    : OneOfBase<
        GreaterThanDecimalProjection,
        GreaterThanStringProjection,
        GreaterThanDateProjection,
        GreaterThanTimeProjection,
        GreaterThanDatetimeProjection
    >
{
    public GreaterThanProjection(GreaterThanDecimalProjection value)
        : this(
            (OneOf<
                GreaterThanDecimalProjection,
                GreaterThanStringProjection,
                GreaterThanDateProjection,
                GreaterThanTimeProjection,
                GreaterThanDatetimeProjection
            >)
                value
        )
    { }

    public GreaterThanProjection(GreaterThanStringProjection value)
        : this(
            (OneOf<
                GreaterThanDecimalProjection,
                GreaterThanStringProjection,
                GreaterThanDateProjection,
                GreaterThanTimeProjection,
                GreaterThanDatetimeProjection
            >)
                value
        )
    { }

    public GreaterThanProjection(GreaterThanDateProjection value)
        : this(
            (OneOf<
                GreaterThanDecimalProjection,
                GreaterThanStringProjection,
                GreaterThanDateProjection,
                GreaterThanTimeProjection,
                GreaterThanDatetimeProjection
            >)
                value
        )
    { }

    public GreaterThanProjection(GreaterThanTimeProjection value)
        : this(
            (OneOf<
                GreaterThanDecimalProjection,
                GreaterThanStringProjection,
                GreaterThanDateProjection,
                GreaterThanTimeProjection,
                GreaterThanDatetimeProjection
            >)
                value
        )
    { }

    public GreaterThanProjection(GreaterThanDatetimeProjection value)
        : this(
            (OneOf<
                GreaterThanDecimalProjection,
                GreaterThanStringProjection,
                GreaterThanDateProjection,
                GreaterThanTimeProjection,
                GreaterThanDatetimeProjection
            >)
                value
        )
    { }

    private GreaterThanProjection(
        OneOf<
            GreaterThanDecimalProjection,
            GreaterThanStringProjection,
            GreaterThanDateProjection,
            GreaterThanTimeProjection,
            GreaterThanDatetimeProjection
        > input
    )
        : base(input) { }
}
