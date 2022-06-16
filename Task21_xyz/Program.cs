int ax = Input("Введите значение X для точки А: ");
int ay = Input("Введите значение Y для точки А: ");
int az = Input("Введите значение Z для точки А: ");
int bx = Input("Введите значение X для точки B: ");
int by = Input("Введите значение Y для точки B: ");
int bz = Input("Введите значение Z для точки B: ");

int cx = ax;
int cy = by;

int distanceY = CalcDist(cy, ay);
int distanceX = CalcDist(bx, cx);
int distanceZ = CalcDist(az, bz);

double result = (Math.Sqrt(Quadro(distanceX) + Quadro(distanceY)));

double hipotXY = SokrDoSot(result);

double hipotXY2 = hipotXY * hipotXY;

double result2 = (Math.Sqrt(hipotXY2 + Quadro(distanceZ)));

double hipotXYZ = SokrDoSot(result2);

Console.WriteLine("Расстояние между точками равно " + hipotXYZ);



int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

int Quadro(int a)
{
    return a * a;
}

int CalcDist(int a, int b)
{
    return a - b;
}

double SokrDoSot(double a)
{
    double kor = a * 100;
    int kor2 = Convert.ToInt32(kor);
    double kor3 = Convert.ToDouble(kor2);
    double res = kor3 / 100;
    return res;
}