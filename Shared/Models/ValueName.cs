using System;

namespace Mock_SQL_DATA.Shared.Models
{
    public class ValueName
{
    public int IdValue { get; set; }
    public string Name { get; set; }
    public int IdType { get; set; }
    public virtual TypeName IdTypeNameNavigation { get; set; }
}
}
