using System;

namespace DbcFile
{
    class Program
    {
        static void Main(string[] args)
        {
            File file = new File();            
            
            Console.WriteLine($"Enter VERSION name followed by an enter key.{Environment.NewLine}");
            file.Version = Console.ReadLine();

            Console.WriteLine($"Enter Node name followed by an enter key.{Environment.NewLine}");
            Node node = new Node();
            node.Name = Console.ReadLine();
            file.Nodes.Add(node);

            Console.WriteLine($"Enter Message ID followed by an enter key.");
            Message message = new Message();
            message.Id = Console.ReadLine();
            Console.WriteLine($"Enter Message Name followed by an enter key.");
            message.Name = Console.ReadLine();
            Console.WriteLine($"Enter Message Size followed by an enter key.");
            message.Size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Enter Message Transmitter followed by an enter key.");
            message.Transmitter = Console.ReadLine();
            node.Messages.Add(message);
            
            int counter = 1;
            while (true)
            {
                Console.WriteLine($"Adding data for Signal # {counter}.......");
                Signal signal = new Signal();

                Console.WriteLine("Enter Signal name");
                signal.Name = Console.ReadLine();

                Console.WriteLine("Enter Multiplexer switch");
                signal.MultiplexerSwitch = Console.ReadLine();

                Console.WriteLine("Enter Start bit");
                signal.StartBit = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Size");
                signal.Size = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Byte order (0 | 1)");
                signal.ByteOrder = Console.ReadLine() == "1" ? true : false;

                Console.WriteLine("Enter Value type (+ | -)");
                signal.StartBit = Convert.ToChar(Console.ReadLine());

                Console.WriteLine("Enter Factor");
                signal.Factor = float.Parse((Console.ReadLine()));

                Console.WriteLine("Enter Offset");
                signal.Offset = float.Parse((Console.ReadLine()));

                Console.WriteLine("Enter Minimum");
                signal.Minimum = float.Parse((Console.ReadLine()));

                Console.WriteLine("Enter Maximum");
                signal.Maximum = float.Parse((Console.ReadLine()));
                
                Console.WriteLine("Enter Unit");
                signal.Unit = Console.ReadLine();

                Console.WriteLine("Enter Receiver");
                signal.Receiver = Console.ReadLine();

                message.Signals.Add(signal);

                Console.WriteLine("DO YOU WANT TO ADD ANOTHER SINGLA. PRESS 'Y' FOR YES AND 'N' FOR NO.");
                var input = Console.ReadLine();
                if (input == "n" || input == "N")
                    break;

                counter++;
            }

            Console.WriteLine($"Printing DBC file content.{Environment.NewLine}");
            Console.WriteLine(file.ToString());
        }
    }
}
