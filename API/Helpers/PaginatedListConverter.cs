using System.Collections.Generic;
using AutoMapper;
using CeciMedina.Core.Tools;

namespace CeciMedina.API.Helpers
{
    public class PaginatedListConverter<TSource, TDestination> : ITypeConverter<PaginatedList<TSource>, PaginatedList<TDestination>>
    {
        public PaginatedList<TDestination> Convert(PaginatedList<TSource> source, PaginatedList<TDestination> destination, ResolutionContext context)
        {
            return new PaginatedList<TDestination>(
                context.Mapper.Map<List<TSource>, List<TDestination>>(source),
                source.PageIndex,
                source.PageSize,
                source.TotalCount);
        }
    }
}