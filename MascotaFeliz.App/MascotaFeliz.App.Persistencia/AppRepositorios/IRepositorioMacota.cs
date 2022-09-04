using MascotaFeliz.App.Dominio;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace MascotaFeliz.App.Persistencia
{
   public interface IRepositorioVeterinario
   {
    IEnumerable<Cliente> GetAllCliente();
        Agenda AddAgenda (Agenda  Agenda);
        Agenda UpdateAgenda (Agenda  Agenda);
        void DeleteAgenda(int IdAgenda);
        Agenda GetAgenda (int IdAgenda);


        

      
   }
}