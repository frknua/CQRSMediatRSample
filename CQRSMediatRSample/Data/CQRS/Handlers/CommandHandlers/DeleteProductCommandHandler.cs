using Data.Context;
using Data.CQRS.Commands.Request;
using Data.CQRS.Commands.Response;
using MediatR;

namespace Data.CQRS.Handlers.CommandHandlers
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommandRequest, DeleteProductCommandResponse>
    {
        public async Task<DeleteProductCommandResponse> Handle(DeleteProductCommandRequest request, CancellationToken cancellationToken)
        {
            var deleteProduct = DbContext.ProductList.FirstOrDefault(p => p.Id == request.Id);
            DbContext.ProductList.Remove(deleteProduct);
            return new DeleteProductCommandResponse
            {
                IsSuccess = true
            };
        }
    }
}
