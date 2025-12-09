using ClaimTheSquareFullstack.ViewModel;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();

var textObjects = new List<TextObject>
{
    new TextObject(40, "Terje", "blue", "white"),
};

app.MapGet("/text-objects", () =>
{
    return textObjects;
});

app.MapPost("/text-objects", (TextObject textObject) =>
{
    textObjects.Add(textObject);
    return true;
});

//var texts = new List<string>
//{
//    "En", "To", "Tre"
//};

//app.MapGet("/texts", () =>
//{
//    return texts;
//});

//app.MapPost("/texts", (AddTextModel addTextModel) =>
//{
//    texts.Add(addTextModel.Text);
//    return true;
//});


app.Run();
