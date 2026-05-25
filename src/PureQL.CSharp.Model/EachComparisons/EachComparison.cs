using OneOf;

namespace PureQL.CSharp.Model.EachComparisons;

public sealed class EachComparison
    : OneOfBase<
        EachNumberComparison,
        EachStringComparison,
        EachDateComparison,
        EachDateTimeComparison,
        EachTimeComparison
    >
{
    public EachComparison(EachNumberComparison comparison)
        : this(
            (OneOf<
                EachNumberComparison,
                EachStringComparison,
                EachDateComparison,
                EachDateTimeComparison,
                EachTimeComparison
            >)
                comparison
        )
    { }

    public EachComparison(EachStringComparison comparison)
        : this(
            (OneOf<
                EachNumberComparison,
                EachStringComparison,
                EachDateComparison,
                EachDateTimeComparison,
                EachTimeComparison
            >)
                comparison
        )
    { }

    public EachComparison(EachDateComparison comparison)
        : this(
            (OneOf<
                EachNumberComparison,
                EachStringComparison,
                EachDateComparison,
                EachDateTimeComparison,
                EachTimeComparison
            >)
                comparison
        )
    { }

    public EachComparison(EachDateTimeComparison comparison)
        : this(
            (OneOf<
                EachNumberComparison,
                EachStringComparison,
                EachDateComparison,
                EachDateTimeComparison,
                EachTimeComparison
            >)
                comparison
        )
    { }

    public EachComparison(EachTimeComparison comparison)
        : this(
            (OneOf<
                EachNumberComparison,
                EachStringComparison,
                EachDateComparison,
                EachDateTimeComparison,
                EachTimeComparison
            >)
                comparison
        )
    { }

    private EachComparison(
        OneOf<
            EachNumberComparison,
            EachStringComparison,
            EachDateComparison,
            EachDateTimeComparison,
            EachTimeComparison
        > input
    )
        : base(input) { }
}
