using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tutor_Appointments_MVC.Models;

namespace Tutor_Appointments_MVC.Data
{
    public class Tutor_Appointments_DBContext : DbContext
    {
        public Tutor_Appointments_DBContext (DbContextOptions<Tutor_Appointments_DBContext> options)
            : base(options)
        {
        }

        public DbSet<Tutor_Appointments_MVC.Models.Tutor> Tutor { get; set; }

        public DbSet<Tutor_Appointments_MVC.Models.Student> Student { get; set; }

        public DbSet<Tutor_Appointments_MVC.Models.Faculty> Faculty { get; set; }

        public DbSet<Tutor_Appointments_MVC.Models.Appointment> Appointment { get; set; }
    }
}
