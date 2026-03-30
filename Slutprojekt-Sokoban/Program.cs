using System.ComponentModel;
using Raylib_cs;

Raylib.InitWindow(800, 600, "Simple Frogger");
Raylib.SetTargetFPS(60);

Player frog = new Player();


while (!Raylib.WindowShouldClose())
{
    int mouseX = Raylib.GetMouseX();
    int mouseY = Raylib.GetMouseY();

    frog.position.Y = 400;
    frog.position.X = 300;

    float speed = 200f; // pixels per second

    Raylib.ClearBackground(Color.Black);

    Raylib.BeginDrawing();

    Raylib.DrawRectangleRec(frog.rect, Color.Red);
    Raylib.DrawRectangle(mouseX,mouseY,50,50,Color.SkyBlue);

    Raylib.EndDrawing();
}



