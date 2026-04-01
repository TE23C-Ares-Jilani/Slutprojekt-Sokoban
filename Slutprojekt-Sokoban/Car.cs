using System.ComponentModel;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

public class Car
{
    public Rectangle obs;
    static public List<Car> cars = [];

    public Car()
    {
        cars.Add(this);

        
    }
}
