using StructureMap;
using System.Web.Http.Dependencies;

namespace SMSQL.IoCRegistry
{
    public class StructureMapDependencyResolver : StructureMapScope, System.Web.Http.Dependencies.IDependencyResolver
    {
        private readonly IContainer _container;

        public StructureMapDependencyResolver(IContainer container) : base(container)
        {
            this._container = container;
        }

        public IDependencyScope BeginScope()
        {
            var childContainer = this._container.GetNestedContainer();
            return new StructureMapScope(childContainer);
        }
    }
}