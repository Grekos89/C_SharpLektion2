﻿void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }

}

void PrintArray(int[] coll)
{
    int count = coll.Length;
    int position = 0;
    while(position < count)
    {
        System.Console.WriteLine(coll[position]);
        position++;
    }

}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; //если нужного элемента Find нету, то мы получим ответ -1 
    while(index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}


int[]array = new int[10]; // new int[n] создай новый массив с n  элементов

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 44);
Console.WriteLine(pos);