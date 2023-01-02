namespace esquire.Models;

public class ModelType<T>
{
    public string ColumnName { get; set; } = "";
    public T value { get; set; }
}