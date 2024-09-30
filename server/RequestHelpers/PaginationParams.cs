namespace server.RequestHelpers
{
    public class PaginationParams
    {
        private const int maxPageSize = 50;
        private int _pageSize = 24;
        public int PageSize { get => _pageSize; set => _pageSize = value > maxPageSize ? maxPageSize : value; }
        public int PageNumber { get; set; } = 1;

    }
}