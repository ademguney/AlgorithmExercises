int[] A = { 9, 3, 9, 3, 9, 7, 9 };

int solution(int[] A)
{
    var set=new HashSet<int>();
    int result = 0;
    for (int i=0; i<A.Length; i++)
    {
        if (!set.Contains(A[i]))
        {
            set.Add(A[i]);
            result=A[i];
        }
        else
        {
            set.Remove(A[i]);
        }
    }
    return result;
}

solution(A);