using System;
using System.Collections.Generic;
using System.Text;

namespace DbcFile
{
    class Node
    {
        public string Name { get; set; }
        public List<Message> Messages { get; set; } = new List<Message>();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder($"BU_: {Name}{Environment.NewLine}{Environment.NewLine}");
            foreach (var item in Messages)
            {
                sb.Append($"{item.ToString()}{Environment.NewLine}");
            }
            return sb.ToString();
        }
    }
}
