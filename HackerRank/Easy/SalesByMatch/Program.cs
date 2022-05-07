int n = 9;
List<int> ar = new List<int> { 10, 20, 20, 10, 10, 30, 50, 10, 20 };
int result;

static int SockMerchant(int n, List<int> ar)
{
    int pairs=0;
    var socksSet=new HashSet<int>();


    foreach (var item in ar)
    {
        if (!socksSet.Contains(item))
        {
            socksSet.Add(item);
        }
        else
        {
            pairs++;
            socksSet.Remove(item);
        }
    }  
    return pairs;
   
}


result=SockMerchant(n, ar);
Console.WriteLine("Pair Socks: {0}",result);
Console.ReadLine();