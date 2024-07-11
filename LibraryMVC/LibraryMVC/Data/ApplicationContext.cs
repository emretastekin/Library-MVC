using System;
using LibraryMVC.Models;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using Microsoft.EntityFrameworkCore;

namespace LibraryMVC.Data;

public class ApplicationContext : DbContext
{
    public ApplicationContext(DbContextOptions<ApplicationContext> options): base(options)
    {
    }
    public DbSet<Location>? Locations { get; set; }
    public DbSet<Language>? Languages { get; set; }
    public DbSet<Category>? Categories { get; set; }
    public DbSet<SubCategory>? SubCategories { get; set; } 
    public DbSet<Publisher>? Publishers { get; set; }
    public DbSet<Author>? Authors { get; set; }
    public DbSet<Book>? Books { get; set; }








}
