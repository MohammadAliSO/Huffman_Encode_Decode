namespace Huffman_Coder_Encoder
{

    internal class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("\t1)Compress File\n\r\t2)Decompress File");
                Console.Write("Please enter number of Huffman mode:");
                int mode = Convert.ToInt32(Console.ReadLine());



                switch (mode)
                {
                    case 1:
                        Console.Write("Please enter pathfile for compress:");
                        var cfile=Console.ReadLine();
                        HuffmanEncoder encoder = new HuffmanEncoder(cfile);
                        var resultD =encoder.Encode();

                        Console.WriteLine("File Compressed in :"+ resultD);
                        break;
                    case 2:
                        Console.Write("Please enter pathfile for Decompress:");
                        var dfile = Console.ReadLine();
                        HuffmanDecoder Decoder = new HuffmanDecoder(dfile);
                        var resultC = Decoder.Decode();

                        Console.WriteLine("File Decompressed in :" + resultC);
                        break;
                    default:
                        Console.WriteLine("Incorrect input!\a");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }


        }

    }

}