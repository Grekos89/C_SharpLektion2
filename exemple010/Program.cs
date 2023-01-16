int[] array = {21, 24, 53,19, 95, 63, 75, 78, 19};

int n = array.Length;
int find = 19;

int index = 0;

while(index < n)
{
    if(array[index] == find )
    {
        System.Console.WriteLine(index);
        break;
    }
    index++ ; // index = index + 1
}