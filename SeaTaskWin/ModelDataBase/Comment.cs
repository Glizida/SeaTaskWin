using System;
using System.Collections.Generic;

namespace SeaTaskWin.ModelDataBase
{
    public partial class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; } = null!;
        public int UserId { get; set; }
        public int TaskId { get; set; }

        public virtual Task Task { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
