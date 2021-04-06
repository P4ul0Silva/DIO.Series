//Classe base usada para o projeto. É uma classe abstrata contendo a propriedade inteira "Id"
//Todas as heranças irão conter o "Id".
// 
namespace DIO.Series
{
    public abstract class EntidadeBase
    {
        public int Id { get; protected set; }  // identificador do objeto, acessado somente dentro da dll.
    }
}