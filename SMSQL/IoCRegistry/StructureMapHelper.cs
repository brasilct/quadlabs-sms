using StructureMap;
using System.Collections.Generic;

namespace SMSQL.IoCRegistry
{
    public static class StructureMapHelper
    {
        public static Container Inicializar(List<Registry> registry)
        {
            var container = new Container();
            foreach (var item in registry)
                container.Configure(x => x.AddRegistry(item));

            return container;
        }

    }
}