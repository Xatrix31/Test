﻿using System.Data.Entity;
using test.Models.Entities;

namespace test.Data.Context
{
    public class Model : DbContext
    {
        // Контекст настроен для использования строки подключения "Model" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "test.Data.Context.Model" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "Model" 
        // в файле конфигурации приложения.
        public Model()
            : base("name=Model")
        {
        }

        public static Model Create()
        {
            return new Model();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Pupil>().ToTable("Pupils");
            modelBuilder.Entity<Teacher>().ToTable("Teachers");
        }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Pupil> Pupils { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
    }
}