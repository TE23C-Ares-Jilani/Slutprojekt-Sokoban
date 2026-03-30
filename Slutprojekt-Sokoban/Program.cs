using System.ComponentModel;
using System.Data;
using Raylib_cs;

Raylib.InitWindow(800, 600, "Simple Frogger");
Raylib.SetTargetFPS(60);

Player frog = new Player();

    frog.PosX = 375;
    frog.PosY = 550;

while (!Raylib.WindowShouldClose())
{

    Raylib.ClearBackground(Color.Black);

    Raylib.BeginDrawing();

    frog.update();

    Raylib.DrawRectangle(frog.PosX,frog.PosY,50,50,Color.SkyBlue);

    Raylib.EndDrawing();
}



