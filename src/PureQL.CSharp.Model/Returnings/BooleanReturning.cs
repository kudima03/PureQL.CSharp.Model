using OneOf;
using PureQL.CSharp.Model.BooleanOperations;
using PureQL.CSharp.Model.Equalities;
using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Parameters;
using PureQL.CSharp.Model.Scalars;

namespace PureQL.CSharp.Model.Returnings;

public sealed class BooleanReturning
    : OneOfBase<
        BooleanField,
        BooleanParameter,
        BooleanScalar,
        Equality,
        BooleanOperator,
        Comparisons.Comparison
    >
{
    public BooleanReturning(BooleanOperator booleanOperator)
        : this(
            (OneOf<
                BooleanField,
                BooleanParameter,
                BooleanScalar,
                Equality,
                BooleanOperator,
                Comparisons.Comparison
            >)
                booleanOperator
        )
    { }

    public BooleanReturning(Equality field)
        : this(
            (OneOf<
                BooleanField,
                BooleanParameter,
                BooleanScalar,
                Equality,
                BooleanOperator,
                Comparisons.Comparison
            >)
                field
        )
    { }

    public BooleanReturning(BooleanField field)
        : this(
            (OneOf<
                BooleanField,
                BooleanParameter,
                BooleanScalar,
                Equality,
                BooleanOperator,
                Comparisons.Comparison
            >)
                field
        )
    { }

    public BooleanReturning(BooleanParameter parameter)
        : this(
            (OneOf<
                BooleanField,
                BooleanParameter,
                BooleanScalar,
                Equality,
                BooleanOperator,
                Comparisons.Comparison
            >)
                parameter
        )
    { }

    public BooleanReturning(BooleanScalar scalar)
        : this(
            (OneOf<
                BooleanField,
                BooleanParameter,
                BooleanScalar,
                Equality,
                BooleanOperator,
                Comparisons.Comparison
            >)
                scalar
        )
    { }

    public BooleanReturning(Comparisons.Comparison comparison)
        : this(
            (OneOf<
                BooleanField,
                BooleanParameter,
                BooleanScalar,
                Equality,
                BooleanOperator,
                Comparisons.Comparison
            >)
                comparison
        )
    { }

    private BooleanReturning(
        OneOf<
            BooleanField,
            BooleanParameter,
            BooleanScalar,
            Equality,
            BooleanOperator,
            Comparisons.Comparison
        > input
    )
        : base(input) { }
}
