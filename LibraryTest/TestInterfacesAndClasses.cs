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
        
        public interface IA {}
        public interface IB {}
        public interface IC {}

        public class A : IA
        {
            public IB b { get; set; }

            public A(IB b)
            {
                this.b = b;
            }

            public A()
            {
                
            }

        }
        
        public class B : IB
        {
            public IA a { get; set; }
            public IC c { get; set; }

            public B(IA a, IC c)
            {
                this.a = a;
                this.c = c;
            }

            public B()
            {
                
            }
        }
        
        public class C : IC
        {
            public IA a { get; set; }
            public IC c { get; set; }
            
            public C(IA a, IC c)
            {
                this.a = a;
                this.c = c;
            }

            public C()
            {
                
            }
            
        }
    }
}