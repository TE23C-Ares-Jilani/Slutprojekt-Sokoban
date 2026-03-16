using System.Numerics;
using System.Runtime.CompilerServices;
using Raylib_cs;

public class Player
{
public Vector2 position;
public Rectangle rect;
    public void update()
    {
        if(Raylib.IsKeyDown(KeyboardKey.W))
        {
            rect.X ++;
        }
    }
}
