using System;
using System.Collections.Generic;

namespace SeaTaskWin.ModelDataBase
{
    public partial class Country
    {
        public Country()
        {
            Organizations = new HashSet<Organization>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Organization> Organizations { get; set; }
    }
}
