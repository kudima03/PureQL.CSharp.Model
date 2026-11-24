using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>log.decimal@group</c>.</summary>
public sealed record LogDecimalGroup : IOperator
{
    public LogDecimalGroup(DecimalGroup operand, DecimalGroup @base)
    {
        Operand = operand;
        Base = @base;
    }

    public DecimalGroup Operand { get; }

    public DecimalGroup Base { get; }

    public IType Type => new TypeDecimal();
}
