using System.Collections.Generic;

namespace Mock_SQL_DATA.Shared.Models
{
    public class TypeName
{
    public TypeName()
    {
        Values = new HashSet<ValueName>();
    }

    public int IdType { get; set; }

    public string Name { get; set; }

    public virtual ICollection<ValueName> Values { get; set; }
}
}
