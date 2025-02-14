using Microsoft.AspNetCore.Http.Extensions;

var builder = WebApplication.CreateBuilder();
builder.Services.AddLogging();
builder.Services.AddRazorPages();

var app = builder.Build();

app.MapGet("/", async context =>
{
    var logger = context.RequestServices.GetRequiredService<ILogger<Program>>();

    logger.LogInformation($"Incoming Request: {context.Request.Method} {context.Request.GetDisplayUrl()}");
    logger.LogInformation($"Outgoing Response: {context.Response.StatusCode}");

    await context.Response.WriteAsync(
        @"<style>
        body {
        background-color:#ffb703;}
        </style>
        <script>function wrt()
            {" +
                $"document.body.innerHTML += '<h1 >You Clicked the Button</h1>'" +
            "} " +
        "</script>" +

        "<h1 style='color:#023047;text-align:center;'>" +
            "Welcome to Middleware Demo " +
        "</h1>" +

        "<h3 style='color:#d81159;'>" +
            "Click on the buttons to send the request" +
        "</h3>" +

        "<button onclick='wrt()' style = 'padding:10px; font-weight: 800; width: 100px; border-radius:20px; border: 3px solid #000; background-color:#caf0f8;'>" +
            "Click Me!" +
         "</button>" +
          "<h3 style='color:#d81159;'>" +
            "Your Log history will be displayed here" +
        "</h3>");
});
app.Run();