using OneOf;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed class UuidNullableTotal : OneOfBase<UuidTotal, ExactUuidNullableTotal>
{
    public UuidNullableTotal(UuidTotal value)
        : this((OneOf<UuidTotal, ExactUuidNullableTotal>)value) { }

    public UuidNullableTotal(ExactUuidNullableTotal value)
        : this((OneOf<UuidTotal, ExactUuidNullableTotal>)value) { }

    private UuidNullableTotal(OneOf<UuidTotal, ExactUuidNullableTotal> input)
        : base(input) { }
}
