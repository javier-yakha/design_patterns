using System;
namespace Bridge;
public class Circle : Shape
{
  private int x;
  private int y;
  private int width;
  private int height;
  public Circle(IDrawAPI drawAPI, int x, int y, int width, int height)
    : base(drawAPI)
  {
    this.x = x;
    this.y = y;
    this.width = width;
    this.height = height;
  }
  public override void Draw()
  {
    drawAPI.Draw(x, y, width, height);
  }
}
