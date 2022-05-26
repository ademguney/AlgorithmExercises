int X = 10, Y = 85, D = 30;

int solution(int X, int Y, int D)
{
    int jumpCount = 0;
    while (X<=Y)
    {
        X = X + D;
        jumpCount++;
    }

    return jumpCount;
}

solution(X, Y, D);  
