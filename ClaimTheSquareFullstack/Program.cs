var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();

var texts = new List<string>
{
    "En", "To", "Tre"
};

app.MapGet("/texts", () =>
{
    return texts;
});

app.MapPost("/texts", (string text) =>
{
    texts.Add(text);
});


app.Run();
