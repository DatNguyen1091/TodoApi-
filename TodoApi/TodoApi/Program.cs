var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var arr = new[] { 8, 2, 6, 4, 1, 6, 9, 7, 5, 10, 3 };

app.MapGet("/", () =>
{
    var Arr = arr.ToArray();
    return Arr;
});


app.MapGet("/sort=0", () => 
{   
    Array.Sort(arr);
    return arr;
});

app.MapGet("/sort=1", () =>
{
    for (int i = 0; i < arr.Length; i++)
        for (int j = arr.Length - 1; j > i; j--)
            if (arr[j] > arr[j - 1])
            {
                int temp = arr[j];
                arr[j] = arr[j - 1];
                arr[j - 1] = temp;
            }
    return arr;
});

app.Run();