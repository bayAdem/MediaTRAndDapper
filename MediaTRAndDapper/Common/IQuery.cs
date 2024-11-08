using MediatR;

namespace MediaTRAndDapper.Common;

public interface IQuery<out TResponse> : IRequest<TResponse>
{
}
