using Domain.Models;
using Domain.Repository;
using Domain.Services.Contracts;
using System.Linq;
using System.Web.Services;

namespace ASMX
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class WebService : System.Web.Services.WebService
    {
        private readonly ICatalogRepository _catalogRepository;

        public WebService()
        {
            _catalogRepository = new CatalogRepository();
        }

        [WebMethod(Description = "получить полный список из справочника телефонов")]
        public Record[] GetDict()
        {
            return _catalogRepository.GetAll().ToArray();
        }

        [WebMethod(Description = "добавить новый телефон")]
        public void AddDict(Record record)
        {
            _catalogRepository.Add(record);
        }

        [WebMethod(Description = "корректировать строку")]
        public void Update(Record record)
        {
            _catalogRepository.Update(record);
        }

        [WebMethod(Description = "удалить строку")]
        public void Delete(int id)
        {
            _catalogRepository.Delete(id);
        }
    }
}
