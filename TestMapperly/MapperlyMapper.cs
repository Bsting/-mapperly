using Riok.Mapperly.Abstractions;
using System.Diagnostics.CodeAnalysis;

namespace TestMapperly
{
    [Mapper(AutoUserMappings = false)]
    public partial class MapperlyMapper
    {
        [return: NotNullIfNotNull(nameof(source))]
        public partial object? Map(object? source, Type targetType);
    }

    public static class MapperlyMapperExtensions
    {
        public static TDestination? Map<TDestination>(this MapperlyMapper mapper, [NotNullIfNotNull(nameof(source))] object? source) =>
            (TDestination?)mapper.Map(source, typeof(TDestination));
    }
}
