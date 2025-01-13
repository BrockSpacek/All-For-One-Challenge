using All_For_One_Challenge.services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<AddNumbersServices>();
builder.Services.AddScoped<AskTwoQuestionsServices>();
builder.Services.AddScoped<GreaterOrLessServices>();
builder.Services.AddScoped<GuessItServices>();
builder.Services.AddScoped<MadLibServices>();
builder.Services.AddScoped<Magic8BallServices>();
builder.Services.AddScoped<OddOrEvenServices>();
builder.Services.AddScoped<RestarauntPickerServices>();
builder.Services.AddScoped<ReverseItServices>();
builder.Services.AddScoped<SayHelloServices>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
