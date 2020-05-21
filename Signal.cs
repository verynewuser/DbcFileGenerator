namespace DbcFile
{
    // SG nodes
    class Signal
    {
        public string Name { get; set; }
        public string MultiplexerSwitch { get; set; } // ' ' | 'M' | m integer
        public int StartBit { get; set; }
        public int Size { get; set; }
        public bool ByteOrder { get; set; }
        public char ValueType { get; set; }
        public float Factor { get; set; }
        public float Offset { get; set; }
        public float Minimum { get; set; }
        public float Maximum { get; set; }
        public string Unit { get; set; }
        public string Receiver { get; set; }

        public override string ToString()
        {
            return $"SG_ {Name} {MultiplexerSwitch} : {StartBit} | {Size} @ {ByteOrder} {ValueType} ( {Factor} , {Offset} [ {Minimum} | {Maximum}] {Unit} {Receiver} )";
        }
    }
}
