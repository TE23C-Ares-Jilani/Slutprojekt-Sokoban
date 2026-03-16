using System.Numerics;
using System.Runtime.CompilerServices;
using Raylib_cs;

public class Player
{
public Vector2 position;
public Rectangle rect;
    public void update()
    {

        rect = new(position.X, position.Y, 100, 100);
        if(Raylib.IsKeyDown(KeyboardKey.W))
        {
            rect.X ++;
        }
    }
}
