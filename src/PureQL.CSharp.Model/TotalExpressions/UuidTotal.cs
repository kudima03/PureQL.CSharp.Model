using OneOf;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed class UuidTotal : OneOfBase<ParamUuid, LiteralUuid, ConditionalUuidTotal>
{
    public UuidTotal(ParamUuid value)
        : this((OneOf<ParamUuid, LiteralUuid, ConditionalUuidTotal>)value) { }

    public UuidTotal(LiteralUuid value)
        : this((OneOf<ParamUuid, LiteralUuid, ConditionalUuidTotal>)value) { }

    public UuidTotal(ConditionalUuidTotal value)
        : this((OneOf<ParamUuid, LiteralUuid, ConditionalUuidTotal>)value) { }

    private UuidTotal(OneOf<ParamUuid, LiteralUuid, ConditionalUuidTotal> input)
        : base(input) { }
}
