//
//
//
// 
// 
//É obrigatorio que a interface seja implementada caso contrario irá gerar erros no código
//Quem implementar a interface, passa  o <T> de tipo generico
//Independente da classe que estiver immplementando o repositorio, é implementando o repositorio da classe <T>


using System.Collections.Generic;

namespace DIO.Series.Interfaces
{
    public interface IRepositorio<T>
    {
     List<T> Lista (); // a interface possui uma lista que retonar uma lista de <T>
     T RetornaPorId(int id); // passa um id para o parametro e retorna T como parametro
     void Insere(T entidade);
     void Exclui(int id);
     void Atualiza(int id, T entidade);
     int ProximoId();
    }
}