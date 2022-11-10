using System;
using System.Collections.Generic;

namespace SeaTaskWin.ModelDataBase
{
    public partial class TasksUser
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int TaskId { get; set; }
        public int? AccessLevel { get; set; }

        public virtual Task Task { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
