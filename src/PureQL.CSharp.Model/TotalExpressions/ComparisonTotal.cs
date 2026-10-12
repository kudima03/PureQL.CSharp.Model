using OneOf;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed class ComparisonTotal
    : OneOfBase<
        EqualTotal,
        NotEqualTotal,
        InTotal,
        GreaterThanTotal,
        LessThanTotal,
        GreaterThanOrEqualTotal,
        LessThanOrEqualTotal
    >
{
    public ComparisonTotal(EqualTotal value)
        : this(
            (OneOf<
                EqualTotal,
                NotEqualTotal,
                InTotal,
                GreaterThanTotal,
                LessThanTotal,
                GreaterThanOrEqualTotal,
                LessThanOrEqualTotal
            >)
                value
        )
    { }

    public ComparisonTotal(NotEqualTotal value)
        : this(
            (OneOf<
                EqualTotal,
                NotEqualTotal,
                InTotal,
                GreaterThanTotal,
                LessThanTotal,
                GreaterThanOrEqualTotal,
                LessThanOrEqualTotal
            >)
                value
        )
    { }

    public ComparisonTotal(InTotal value)
        : this(
            (OneOf<
                EqualTotal,
                NotEqualTotal,
                InTotal,
                GreaterThanTotal,
                LessThanTotal,
                GreaterThanOrEqualTotal,
                LessThanOrEqualTotal
            >)
                value
        )
    { }

    public ComparisonTotal(GreaterThanTotal value)
        : this(
            (OneOf<
                EqualTotal,
                NotEqualTotal,
                InTotal,
                GreaterThanTotal,
                LessThanTotal,
                GreaterThanOrEqualTotal,
                LessThanOrEqualTotal
            >)
                value
        )
    { }

    public ComparisonTotal(LessThanTotal value)
        : this(
            (OneOf<
                EqualTotal,
                NotEqualTotal,
                InTotal,
                GreaterThanTotal,
                LessThanTotal,
                GreaterThanOrEqualTotal,
                LessThanOrEqualTotal
            >)
                value
        )
    { }

    public ComparisonTotal(GreaterThanOrEqualTotal value)
        : this(
            (OneOf<
                EqualTotal,
                NotEqualTotal,
                InTotal,
                GreaterThanTotal,
                LessThanTotal,
                GreaterThanOrEqualTotal,
                LessThanOrEqualTotal
            >)
                value
        )
    { }

    public ComparisonTotal(LessThanOrEqualTotal value)
        : this(
            (OneOf<
                EqualTotal,
                NotEqualTotal,
                InTotal,
                GreaterThanTotal,
                LessThanTotal,
                GreaterThanOrEqualTotal,
                LessThanOrEqualTotal
            >)
                value
        )
    { }

    private ComparisonTotal(
        OneOf<
            EqualTotal,
            NotEqualTotal,
            InTotal,
            GreaterThanTotal,
            LessThanTotal,
            GreaterThanOrEqualTotal,
            LessThanOrEqualTotal
        > input
    )
        : base(input) { }
}
