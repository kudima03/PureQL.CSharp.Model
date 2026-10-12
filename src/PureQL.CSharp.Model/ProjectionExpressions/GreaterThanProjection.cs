using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class GreaterThanProjection
    : OneOfBase<
        GreaterThanDecimalProjection,
        GreaterThanStringProjection,
        GreaterThanBooleanProjection,
        GreaterThanDateProjection,
        GreaterThanTimeProjection,
        GreaterThanDatetimeProjection,
        GreaterThanUuidProjection
    >
{
    public GreaterThanProjection(GreaterThanDecimalProjection value)
        : this(
            (OneOf<
                GreaterThanDecimalProjection,
                GreaterThanStringProjection,
                GreaterThanBooleanProjection,
                GreaterThanDateProjection,
                GreaterThanTimeProjection,
                GreaterThanDatetimeProjection,
                GreaterThanUuidProjection
            >)
                value
        )
    { }

    public GreaterThanProjection(GreaterThanStringProjection value)
        : this(
            (OneOf<
                GreaterThanDecimalProjection,
                GreaterThanStringProjection,
                GreaterThanBooleanProjection,
                GreaterThanDateProjection,
                GreaterThanTimeProjection,
                GreaterThanDatetimeProjection,
                GreaterThanUuidProjection
            >)
                value
        )
    { }

    public GreaterThanProjection(GreaterThanBooleanProjection value)
        : this(
            (OneOf<
                GreaterThanDecimalProjection,
                GreaterThanStringProjection,
                GreaterThanBooleanProjection,
                GreaterThanDateProjection,
                GreaterThanTimeProjection,
                GreaterThanDatetimeProjection,
                GreaterThanUuidProjection
            >)
                value
        )
    { }

    public GreaterThanProjection(GreaterThanDateProjection value)
        : this(
            (OneOf<
                GreaterThanDecimalProjection,
                GreaterThanStringProjection,
                GreaterThanBooleanProjection,
                GreaterThanDateProjection,
                GreaterThanTimeProjection,
                GreaterThanDatetimeProjection,
                GreaterThanUuidProjection
            >)
                value
        )
    { }

    public GreaterThanProjection(GreaterThanTimeProjection value)
        : this(
            (OneOf<
                GreaterThanDecimalProjection,
                GreaterThanStringProjection,
                GreaterThanBooleanProjection,
                GreaterThanDateProjection,
                GreaterThanTimeProjection,
                GreaterThanDatetimeProjection,
                GreaterThanUuidProjection
            >)
                value
        )
    { }

    public GreaterThanProjection(GreaterThanDatetimeProjection value)
        : this(
            (OneOf<
                GreaterThanDecimalProjection,
                GreaterThanStringProjection,
                GreaterThanBooleanProjection,
                GreaterThanDateProjection,
                GreaterThanTimeProjection,
                GreaterThanDatetimeProjection,
                GreaterThanUuidProjection
            >)
                value
        )
    { }

    public GreaterThanProjection(GreaterThanUuidProjection value)
        : this(
            (OneOf<
                GreaterThanDecimalProjection,
                GreaterThanStringProjection,
                GreaterThanBooleanProjection,
                GreaterThanDateProjection,
                GreaterThanTimeProjection,
                GreaterThanDatetimeProjection,
                GreaterThanUuidProjection
            >)
                value
        )
    { }

    private GreaterThanProjection(
        OneOf<
            GreaterThanDecimalProjection,
            GreaterThanStringProjection,
            GreaterThanBooleanProjection,
            GreaterThanDateProjection,
            GreaterThanTimeProjection,
            GreaterThanDatetimeProjection,
            GreaterThanUuidProjection
        > input
    )
        : base(input) { }
}
