using System.Collections.ObjectModel;

namespace Menagelec.Component;

public class FilterStruct
{
    public string Column;
    public object Value;

    public string AsClause()
    {
        return string.Join("=", Column, Value);
    }

    public static string WhereClause(params FilterStruct[] filterStructs)
    {
        var where = new Collection<string>();
        foreach (var filterStruct in filterStructs) where.Add(filterStruct.AsClause());
        return string.Join(" AND ", where);
    }
}