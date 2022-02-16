namespace LibraryTest
{
    public static class TestInterfacesAndClasses
    {
        public interface IService {}

        public class Service1 : IService {}

        public class Service2 : IService {}
    
        public abstract class AbstractService : IService {}
    
        public class AbstractServiceImpl : AbstractService {}
    
        public class Service3 : IService
        {
            public IRepository Repository { get; set; }

            public Service3(IRepository repository)
            {
                Repository = repository;
            }
        }

        public interface IRepository{}

        public class Repository1 : IRepository {}

        public interface IService<TRepository> where TRepository : IRepository {}

        public class Service4<TRepository> : IService<TRepository> where TRepository : IRepository
        {
            public TRepository Repository { get; set; }
            public Service4(TRepository repository)
            {
                Repository = repository;
            }
        }
        
        public class Service5 : IService
        {
            public Service5(Service2 service2)
            {
                
            }
            public IRepository Repository { get; set; }
        }
        

            
        
    }
}