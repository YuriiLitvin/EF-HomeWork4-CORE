using EF_HomeWork_4_CORE.Entity;
using EF_HomeWork_4_CORE.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.Linq;

namespace EF_HomeWork_4_CORE
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new FitnessDbContext();
            context.Database.EnsureCreated();
        }
    }
}
