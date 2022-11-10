﻿using System;
using System.Collections.Generic;

namespace SeaTaskWin.ModelDataBase
{
    public partial class UserOrganization
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int OrganizationId { get; set; }

        public virtual Organization Organization { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
