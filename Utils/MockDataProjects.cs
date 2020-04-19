using csharp_dotnetcore_projects.Models;
using System.Collections.Generic;

namespace csharp_dotnetcore_projects.Utils
{

    public class MockDataProjects
    {
        private ApplicationDbContext context;


        public MockDataProjects(ApplicationDbContext context)
        {
            this.context = context;
        }

        public void SetData()
        {
            context.Projects.AddRange(new List<Project>() {
                new Project(){
                   Name = "Proyecto Seguridad",
                   Description = "Proyecto de Seguridad",
                   State = "Inactivo",
                   CreatedDate = "27-05-2019"
                },
                new Project(){
                   Name = "Proyecto Educacion",
                   Description = "Proyecto de Educacion",
                   State = "Activo",
                   CreatedDate = "01-01-2020"
                },
                new Project(){
                   Name = "Proyecto Deportes",
                   Description = "Proyecto de Deportes",
                   State = "Activo",
                   CreatedDate = "01-01-2020"
                },
                new Project(){
                   Name = "Proyecto Informatica",
                   Description = "Proyecto de Informatica",
                   State = "Activo",
                   CreatedDate = "01-01-2020"
                },
                new Project(){
                   Name = "Proyecto Ingenieria",
                   Description = "Proyecto de Ingenieria",
                   State = "Activo",
                   CreatedDate = "28-02-2020"
                }
            });
            context.SaveChanges();
        }
    }
}
