using Raylib_cs;

Raylib.InitWindow(800, 600, "Simple Frogger");
Raylib.SetTargetFPS(60);

while (!Raylib.WindowShouldClose())
{
    Raylib.ClearBackground(Color.Black);

    int mouseX = Raylib.GetMouseX();
    int mouseY = Raylib.GetMouseY();

    Raylib.BeginDrawing();

    Raylib.DrawCircle(mouseX, mouseY, 20, Color.Red);

    Raylib.EndDrawing();
}



