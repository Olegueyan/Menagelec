namespace Menagelec.Component;

public class Filter
{
    private string Column { get; }

    public Filter(string column)
    {
        Column = column;
    }

    public FilterStruct With(object value)
    {
        return new FilterStruct
        {
            Column = Column,
            Value = value
        };
    }
}