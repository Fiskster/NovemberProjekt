using System;
using Raylib_cs;
namespace novemberProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            //Planen är simpel, Ha en slags hub som finns i rpg-spel i starwars-tema där man kan interacta med saker som uppfyller alla kraven på A-nivå.
            //Detta då i star wars tema :) 
            Raylib.InitWindow(800, 600, "Hello World");

            float x = 100;
            float y = 400;

            var bruh = Raylib.LoadImage(@"C:\Users\axel.lilja2\Documents\PROG02\NovemberProjekt\novemberProjekt\bin\Debug\netcoreapp3.1\MainChar.png");
            Texture2D texture = Raylib.LoadTextureFromImage(bruh);



            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();

                Raylib.ClearBackground(Color.BLUE);

              Raylib.DrawTexture(texture, (int)x, (int)y, Color.WHITE);


                Raylib.EndDrawing();
            }


        }
    }
}
