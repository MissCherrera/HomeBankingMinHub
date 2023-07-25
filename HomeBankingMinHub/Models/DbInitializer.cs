using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace HomeBankingMinHub.Models
{
    public class DbInitializer
    {
        public static void Initialize(HomeBankingContext context) 
        {
            if(!context.Clients.Any())
            
                //Se crea datos de prueba para la base de datos. arreglos
            {
                var clients= new Client []
                {
                    //Objeto de cliente
                    new Client  {
                        FirstName = "Cintia",
                        LastName = "Herrera",
                        Email = "cintia.ch.herrera@gmail.com",
                        Password = "123456",
                    },
                    new Client  {
                        FirstName = "Ramiro",
                        LastName = "Olivencia",
                        Email = "ramirOlivencia@gmail.com",
                        Password = "87654321",
                    },

                };
                //Para agregar nuevos datos a la base
                foreach(var client in clients)
                {
                    // Se añade Clients al nuevo Cliente
                    context.Clients.Add(client);
                }
                
            }
            // Por fuera de la logica, se guardan los datos almacenados, contexto
            context.SaveChanges();

        }
    }
}
