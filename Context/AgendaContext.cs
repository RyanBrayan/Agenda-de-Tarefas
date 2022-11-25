using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using agenda_de_Tarefa.Models;
using Microsoft.EntityFrameworkCore;

namespace agenda_de_Tarefa.Context
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options){

        }

        public DbSet<Tarefa> Tarefas { get; set; }

    }
}