Console.Clear();
int xa = 40, ya = 1;
Console.SetCursorPosition(xa,ya);
Console.WriteLine("+");
int xb = 1, yb = 30;
Console.SetCursorPosition(xb,yb);
Console.WriteLine("+");
int xc = 80, yc = 30;
Console.SetCursorPosition(xc,yc);
Console.WriteLine("+");
int x = xa, y = xb;
int count = 0;
while(count < 100000)
{
    int rand = new Random().Next(0, 3);
    if(rand == 0)
    {
        x = (x + xa)/2;
        y = (y + ya)/2;
    }
    if(rand == 1)
    {
        x = (x + xb)/2;
        y = (y + yb)/2;
    }
    if(rand == 2)
    {
        x = (x + xc)/2;
        y = (y + yc)/2;
    }
    Console.SetCursorPosition(x,y);
    Console.WriteLine("+");
    count++;
}