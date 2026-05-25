using OneOf;

namespace PureQL.CSharp.Model.EachBooleanOperations;

public sealed class EachBooleanOperator
    : OneOfBase<EachAndOperator, EachOrOperator, EachNotOperator>
{
    public EachBooleanOperator(EachAndOperator @operator)
        : this((OneOf<EachAndOperator, EachOrOperator, EachNotOperator>)@operator) { }

    public EachBooleanOperator(EachOrOperator @operator)
        : this((OneOf<EachAndOperator, EachOrOperator, EachNotOperator>)@operator) { }

    public EachBooleanOperator(EachNotOperator @operator)
        : this((OneOf<EachAndOperator, EachOrOperator, EachNotOperator>)@operator) { }

    private EachBooleanOperator(
        OneOf<EachAndOperator, EachOrOperator, EachNotOperator> input
    )
        : base(input) { }
}
