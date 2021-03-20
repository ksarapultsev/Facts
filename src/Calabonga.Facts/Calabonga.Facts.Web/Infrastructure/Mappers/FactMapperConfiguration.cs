using Calabonga.Facts.Web.Infrastructure.Base;
using Calabonga.Facts.Web.Data;
using Calabonga.Facts.Web.ViewModels;

namespace Calabonga.Facts.Web.Infrastructure.Mappers
{
    public class FactMapperConfiguration : MapperConfigurationBase
    {
        public FactMapperConfiguration()
        {
            CreateMap<Fact, FactViewModal>();
        }
    }
}
