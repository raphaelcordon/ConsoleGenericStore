using ConsoleGenericStore.Data.Users;

namespace ConsoleGenericStore.Data._Shared
{
	public abstract class Base
	{
        public Base()
        {
            Guid Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
	}
}
