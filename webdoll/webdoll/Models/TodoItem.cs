using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webdoll.Models
{
    public class TodoItem
    {
        public long Id { get; set; } //idプロパティは、RDB内の一意のキーとして機能する
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
