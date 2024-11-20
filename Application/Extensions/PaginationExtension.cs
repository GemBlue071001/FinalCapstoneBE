using Application.Response.Pagination;

namespace Application.Extensions
{
    public static class PaginationExtension
    {
        public static PaginationResponse<T> ToPaginationResponse<T>(this IEnumerable<T> items, int pageIndex, int pageSize, bool pagingItem = true)
        {
            items ??= Enumerable.Empty<T>();

            var totalCount = items.Count();
            var totalPages = (int)Math.Ceiling(totalCount / (double)pageSize);

            // Ensure pageIndex is within valid bounds
            if (pageIndex < 1) pageIndex = 1;
            if (pageIndex > totalPages) pageIndex = totalPages;

            var paginatedItems = items;

            if (pagingItem && totalCount > 0 && pageIndex <= totalPages)
            {
                paginatedItems = items
                    .Skip((pageIndex - 1) * pageSize)
                    .Take(pageSize)
                    .ToList();
            }

            return new PaginationResponse<T>
            {
                PageSize = pageSize,
                TotalCount = totalCount,
                TotalPages = totalPages,
                PageIndex = pageIndex,
                Items = paginatedItems,
            };
        }

    }
}
