using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Literals;

public interface ILiteral
{
    public IType Type { get; }
}
