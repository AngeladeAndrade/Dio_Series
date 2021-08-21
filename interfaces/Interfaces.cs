    using System.Collections.Generic;

namespace Dio.series.interfaces
{
    public interface IRepositorio<T> 
        {
     List<T> List() ;
     T RetornaPorId(int id) ;
     void Insere(T entidade);
     void Exclui(int id);
     void atualizar(int id, T entidade);
     int ProximoId() ;

    }
}