using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TakeHome.Models.InvoiceViewModels;
using TakeHomeTask.InvoiceManager.Services.Abstract;

namespace TakeHomeTask.InvoiceManager.Data.Concrete
{
    public class ClientService : IClientService
    {
        public async Task<IEnumerable<Client>> GetClients() => await GetAllClients();
        public async Task<List<Client>> GetAllClients()
        {
            return new List<Client> {
            new Client{Id=1,EmailAddress="KLogistics@gmail.com",ClientName="KLogistics",PhoneNumber="09033208156"},
            new Client{Id=2,EmailAddress="ZobaInc@gmail.com",ClientName="ZobaInc",PhoneNumber="09033208156"},
            new Client{Id=3,EmailAddress="Emmabb@gmail.com",ClientName="Emmabb Ent.",PhoneNumber="09033208156"},
            new Client{Id=4,EmailAddress="Steveson@gmail.com",ClientName="Steve & Sons",PhoneNumber="09033208156"},
            new Client{Id=5,EmailAddress="Goddyfurniture@gmail.com",ClientName="Goddy Fortune",PhoneNumber="09033208156"}
            };
        }
    }
}
