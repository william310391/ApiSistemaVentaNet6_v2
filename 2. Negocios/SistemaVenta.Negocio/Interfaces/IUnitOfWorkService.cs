using System;
namespace SistemaVenta.Negocio.Interfaces
{
    public interface IUnitOfWorkService
    {
        IProductoService ProductoService { get; }
        IUsuarioService UsuarioService { get; }
        ISeguridadService SeguridadService { get; }
        IClienteDapperService ClienteDapperService { get; }
    }
}
