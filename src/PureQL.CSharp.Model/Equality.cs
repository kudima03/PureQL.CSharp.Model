using OneOf;
using PureQL.CSharp.Model.ArrayEqualities;
using PureQL.CSharp.Model.Equalities;

namespace PureQL.CSharp.Model;

public sealed class Equality : OneOfBase<SingleValueEquality, ArrayEquality>
{
    public Equality(SingleValueEquality equality)
        : this((OneOf<SingleValueEquality, ArrayEquality>)equality) { }

    public Equality(ArrayEquality equality)
        : this((OneOf<SingleValueEquality, ArrayEquality>)equality) { }

    private Equality(OneOf<SingleValueEquality, ArrayEquality> input)
        : base(input) { }
}
