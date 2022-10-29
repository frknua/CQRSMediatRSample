using Data.CQRS.Queries.Response;
using MediatR;

namespace Data.CQRS.Queries.Request
{
    public class GetAllProductQueryRequest : IRequest<List<GetAllProductQueryResponse>>
    {

    }
}
