namespace BlockUsing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// Caminho do arquivo a ser lido.
            /// </summary>
            string path = @"C:\Projetos\Udemy\FileManipulation\file.txt";
            try
            {
                /// <summary>
                /// Utiliza o bloco 'using' para garantir que o StreamReader seja fechado automaticamente após o uso.
                /// </summary>
                using (StreamReader sr = File.OpenText(path))
                {
                    /// <summary>
                    /// Lê o arquivo linha por linha até o final.
                    /// </summary>
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {
                /// <summary>
                /// Captura e trata exceções de E/S que possam ocorrer durante a leitura do arquivo.
                /// </summary>
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
