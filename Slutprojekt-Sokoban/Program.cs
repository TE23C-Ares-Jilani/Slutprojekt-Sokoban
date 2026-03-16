using System.ComponentModel;
using Raylib_cs;

Raylib.InitWindow(800, 600, "Simple Frogger");
Raylib.SetTargetFPS(60);

int tileSize = 40;

int cols = 800 / tileSize;
int rows = 600 / tileSize;

int[,] grid = new int[10,15];

Player frog = new Player();


while (!Raylib.WindowShouldClose())
{
    int mouseX = Raylib.GetMouseX();
    int mouseY = Raylib.GetMouseY();

    frog.position.Y = 400;
    frog.position.X = 300;

    Raylib.ClearBackground(Color.Black);

    Raylib.BeginDrawing();

    Raylib.DrawRectangleRec(frog.rect, Color.Red);
    Raylib.DrawRectangle(mouseX,mouseY,100,100,Color.DarkGray);

    Raylib.EndDrawing();
}



