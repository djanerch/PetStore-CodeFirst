using PetStore.Infrastructure.Common;

namespace PetStore.Infrastructure
{
    public class PetStoreRepository : Repository, IPetStoreRepository
    {
        public PetStoreRepository(PetStoreContext context)
        {
            this.Context = context;
        }
    }
}
