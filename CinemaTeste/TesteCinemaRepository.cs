using CinemaDomain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace CinemaTeste
{
    [TestClass]
    public class TesteCinemaRepository
    {
        public partial class MyDBContext : DbContext
        {
            public DbSet<Genero> Genero { get; set; }
            public DbSet<Filme> Filme { get; set; }
            public DbSet<Sala> Sala { get; set; }
            public DbSet<Sessao> Sessao { get; set; }
            public DbSet<Ingresso> Ingresso { get; set; }
            public DbSet<IngressoItem> IngressoItem { get; set; }
            public MyDBContext()
            {
                Database.EnsureCreated();

            }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                base.OnConfiguring(optionsBuilder);
                var server = "localhost";
                var port = "5433";
                var username = "postgres";
                var password = "";
                var database = "CinemaDB";
                var conStr = $"Host={server};Port={port};User Id={username};Password={password};Database={database};";
                if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseNpgsql(conStr);
                }
            }
        }
            [TestMethod]
        public void CriarBanco()
        {
            using (var db = new MyDBContext())
            {
                var genero = new Genero { Id = 1, Nome = "Drama" };
                db.Genero.Add(genero);
                genero = new Genero { Id = 2, Nome = "Ação" };
                db.Genero.Add(genero);
                genero = new Genero { Id = 3, Nome = "Comédia" };
                db.Genero.Add(genero);
                db.SaveChanges();

            }
        }
        [TestMethod]
        public void ListarGenero()
        {
            using (var db = new MyDBContext())
            {
                foreach (var item in db.Genero)
                {
                    Console.WriteLine(JsonSerializer.Serialize(item));
                }
            }
        }
    }
}
