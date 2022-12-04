using AutoMapper;
using System;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Reflection;
using AutoMapper;

namespace Notes.Application.Commons.Mappings
{
    public class AssemblyMappingProfile : Profile
    {
        public AssemblyMappingProfile(Assembly assembly) =>
            ApplyMappingFromAssembly(assembly);

        private void ApplyMappingFromAssembly(Assembly assembly)
        {
            var types = assembly.GetExportedTypes()
                .Where(type => type.GetInterfaces()
                .Any(inter => inter.IsGenericType &&
                    inter.GetGenericTypeDefinition() == typeof(IMapWith<>)))
                .ToList();

            foreach (var type in types)
            {
                var instance = Activator.CreateInstance(type);
                var methodInfo = type.GetMethod("Mapping");
                methodInfo.Invoke(instance, new object[] { this }); 
            }
        }
    }
}
