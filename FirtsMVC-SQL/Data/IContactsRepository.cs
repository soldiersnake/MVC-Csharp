using FirtsMVC_SQL.Models;

namespace FirtsMVC_SQL.Data
{
    public interface IContactsRepository
    {
        Task<IEnumerable<Contact>> GetAll(); //task lo declara asincrono
        Task<Contact> GetDetails(int id);
        Task Insert(Contact contact);
        Task Update(Contact contact);
        Task Delete(int id);
    }
}
