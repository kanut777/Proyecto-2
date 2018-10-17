using Xenko.Engine;

namespace prueba
{
    class pruebaApp
    {
        static void Main(string[] args)
        {
            using (var game = new Game())
            {
                game.Run();
            }
        }
    }
}
