using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Lists;

public interface ISubqueryColumn
{
    public string Subquery { get; }

    public string Field { get; }

    public IType Type { get; }
}
