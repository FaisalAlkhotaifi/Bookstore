using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Model.Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            ApplyMappingsFromAssembly(Assembly.GetExecutingAssembly());
        }

        private void ApplyMappingsFromAssembly(Assembly assembly)
        {
            var types = assembly
                .GetExportedTypes()
                .Where(t => t.GetInterfaces().Any(HasMapFromInterface))
                .ToList();

            foreach (var type in types)
            {
                var instance = Activator.CreateInstance(type);
                var methodInfo = GetMappingMethod(type);
                methodInfo?.Invoke(instance, new object[] { this });
            }
        }

        private bool HasMapFromInterface(Type type)
        {
            return type.IsGenericType && type.GetGenericTypeDefinition() == typeof(IMapFrom<>);
        }

        private MethodInfo? GetMappingMethod(Type type)
        {
            var methodInfo = type.GetMethod("Mapping");
            if (methodInfo == null)
            {
                var mapFromInterface = GetMapFromInterface(type);
                if (mapFromInterface != null)
                {
                    methodInfo = mapFromInterface.GetMethod("Mapping");
                }
            }
            return methodInfo;
        }

        private Type? GetMapFromInterface(Type type)
        {
            return type.GetInterfaces().Where(x => x.Name.Contains("IMapFrom")).FirstOrDefault();
        }
    }
}
