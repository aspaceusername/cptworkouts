﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CPTWorkouts.Data;
using Microsoft.AspNetCore.Identity;
using CPTWorkouts.Models;
using System.Configuration;
using CPTWorkouts.Services.Mail;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<CPTWorkoutsContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("CPTWorkoutsContext") ?? throw new InvalidOperationException("Connection string 'CPTWorkoutsContext' not found.")));

builder.Services.AddIdentity<IdentityUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = false)
.AddEntityFrameworkStores<CPTWorkoutsContext>();

builder.Services.Configure<MailSettings>(builder.Configuration.GetSection("MailSettings"));

builder.Services.AddTransient<IMailService, MailService>();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAuthentication();
app.UseAuthorization();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
