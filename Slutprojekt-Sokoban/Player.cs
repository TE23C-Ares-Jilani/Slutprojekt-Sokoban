using System.Dynamic;
using System.Numerics;
using System.Runtime.CompilerServices;
using Raylib_cs;

public class Player
{
public Vector2 position = new(400, 300);
public int PosX;
public int PosY;
    public void update()
    {
        if(Raylib.IsKeyDown(KeyboardKey.W))
        {
            PosY -=2;
        }
        if(Raylib.IsKeyDown(KeyboardKey.A))
        {
            PosX -=2;
        }
        if(Raylib.IsKeyDown(KeyboardKey.S))
        {
            PosY +=2;
        }
        if(Raylib.IsKeyDown(KeyboardKey.D))
        {
            PosX +=2;
        }
    }
}
