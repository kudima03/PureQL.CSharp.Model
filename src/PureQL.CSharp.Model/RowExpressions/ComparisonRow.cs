using OneOf;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed class ComparisonRow
    : OneOfBase<
        EqualRow,
        NotEqualRow,
        InRow,
        GreaterThanRow,
        LessThanRow,
        GreaterThanOrEqualRow,
        LessThanOrEqualRow
    >
{
    public ComparisonRow(EqualRow value)
        : this(
            (OneOf<
                EqualRow,
                NotEqualRow,
                InRow,
                GreaterThanRow,
                LessThanRow,
                GreaterThanOrEqualRow,
                LessThanOrEqualRow
            >)
                value
        )
    { }

    public ComparisonRow(NotEqualRow value)
        : this(
            (OneOf<
                EqualRow,
                NotEqualRow,
                InRow,
                GreaterThanRow,
                LessThanRow,
                GreaterThanOrEqualRow,
                LessThanOrEqualRow
            >)
                value
        )
    { }

    public ComparisonRow(InRow value)
        : this(
            (OneOf<
                EqualRow,
                NotEqualRow,
                InRow,
                GreaterThanRow,
                LessThanRow,
                GreaterThanOrEqualRow,
                LessThanOrEqualRow
            >)
                value
        )
    { }

    public ComparisonRow(GreaterThanRow value)
        : this(
            (OneOf<
                EqualRow,
                NotEqualRow,
                InRow,
                GreaterThanRow,
                LessThanRow,
                GreaterThanOrEqualRow,
                LessThanOrEqualRow
            >)
                value
        )
    { }

    public ComparisonRow(LessThanRow value)
        : this(
            (OneOf<
                EqualRow,
                NotEqualRow,
                InRow,
                GreaterThanRow,
                LessThanRow,
                GreaterThanOrEqualRow,
                LessThanOrEqualRow
            >)
                value
        )
    { }

    public ComparisonRow(GreaterThanOrEqualRow value)
        : this(
            (OneOf<
                EqualRow,
                NotEqualRow,
                InRow,
                GreaterThanRow,
                LessThanRow,
                GreaterThanOrEqualRow,
                LessThanOrEqualRow
            >)
                value
        )
    { }

    public ComparisonRow(LessThanOrEqualRow value)
        : this(
            (OneOf<
                EqualRow,
                NotEqualRow,
                InRow,
                GreaterThanRow,
                LessThanRow,
                GreaterThanOrEqualRow,
                LessThanOrEqualRow
            >)
                value
        )
    { }

    private ComparisonRow(
        OneOf<
            EqualRow,
            NotEqualRow,
            InRow,
            GreaterThanRow,
            LessThanRow,
            GreaterThanOrEqualRow,
            LessThanOrEqualRow
        > input
    )
        : base(input) { }
}
