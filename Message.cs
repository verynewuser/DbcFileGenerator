using System;
using System.Collections.Generic;
using System.Text;

namespace DbcFile
{
    // BO nodes
    class Message
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Size { get; set; }
        public string Transmitter { get; set; }
        public List<Signal> Signals { get; set; } = new List<Signal>();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder($"BO_ {Id} {Name} : {Size} {Transmitter}{Environment.NewLine}");
            foreach (var item in Signals)
            {
                sb.Append($"  {item.ToString()}{Environment.NewLine}");
            }
            return sb.ToString();
        }
    }
}
