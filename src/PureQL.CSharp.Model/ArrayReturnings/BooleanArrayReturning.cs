using OneOf;
using PureQL.CSharp.Model.ArrayParameters;
using PureQL.CSharp.Model.ArrayScalars;
using PureQL.CSharp.Model.EachBooleanOperations;
using PureQL.CSharp.Model.EachComparisons;
using PureQL.CSharp.Model.EachEqualities;
using PureQL.CSharp.Model.Fields;

namespace PureQL.CSharp.Model.ArrayReturnings;

public sealed class BooleanArrayReturning
    : OneOfBase<
        BooleanArrayScalar,
        BooleanField,
        BooleanArrayParameter,
        EachComparison,
        EachEquality,
        EachAndOperator,
        EachOrOperator,
        EachNotOperator
    >
{
    public BooleanArrayReturning(BooleanArrayScalar scalar)
        : this(
            (OneOf<
                BooleanArrayScalar,
                BooleanField,
                BooleanArrayParameter,
                EachComparison,
                EachEquality,
                EachAndOperator,
                EachOrOperator,
                EachNotOperator
            >)
                scalar
        )
    { }

    public BooleanArrayReturning(BooleanField field)
        : this(
            (OneOf<
                BooleanArrayScalar,
                BooleanField,
                BooleanArrayParameter,
                EachComparison,
                EachEquality,
                EachAndOperator,
                EachOrOperator,
                EachNotOperator
            >)
                field
        )
    { }

    public BooleanArrayReturning(BooleanArrayParameter parameter)
        : this(
            (OneOf<
                BooleanArrayScalar,
                BooleanField,
                BooleanArrayParameter,
                EachComparison,
                EachEquality,
                EachAndOperator,
                EachOrOperator,
                EachNotOperator
            >)
                parameter
        )
    { }

    public BooleanArrayReturning(EachComparison comparison)
        : this(
            (OneOf<
                BooleanArrayScalar,
                BooleanField,
                BooleanArrayParameter,
                EachComparison,
                EachEquality,
                EachAndOperator,
                EachOrOperator,
                EachNotOperator
            >)
                comparison
        )
    { }

    public BooleanArrayReturning(EachEquality equality)
        : this(
            (OneOf<
                BooleanArrayScalar,
                BooleanField,
                BooleanArrayParameter,
                EachComparison,
                EachEquality,
                EachAndOperator,
                EachOrOperator,
                EachNotOperator
            >)
                equality
        )
    { }

    public BooleanArrayReturning(EachAndOperator @operator)
        : this(
            (OneOf<
                BooleanArrayScalar,
                BooleanField,
                BooleanArrayParameter,
                EachComparison,
                EachEquality,
                EachAndOperator,
                EachOrOperator,
                EachNotOperator
            >)
                @operator
        )
    { }

    public BooleanArrayReturning(EachOrOperator @operator)
        : this(
            (OneOf<
                BooleanArrayScalar,
                BooleanField,
                BooleanArrayParameter,
                EachComparison,
                EachEquality,
                EachAndOperator,
                EachOrOperator,
                EachNotOperator
            >)
                @operator
        )
    { }

    public BooleanArrayReturning(EachNotOperator @operator)
        : this(
            (OneOf<
                BooleanArrayScalar,
                BooleanField,
                BooleanArrayParameter,
                EachComparison,
                EachEquality,
                EachAndOperator,
                EachOrOperator,
                EachNotOperator
            >)
                @operator
        )
    { }

    private BooleanArrayReturning(
        OneOf<
            BooleanArrayScalar,
            BooleanField,
            BooleanArrayParameter,
            EachComparison,
            EachEquality,
            EachAndOperator,
            EachOrOperator,
            EachNotOperator
        > input
    )
        : base(input) { }
}
