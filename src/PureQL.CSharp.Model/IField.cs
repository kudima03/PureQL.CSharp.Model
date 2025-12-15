using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model;

public interface IField
{
    public string Entity { get; }

    public string Field { get; }

    public IType Type { get; }
}
