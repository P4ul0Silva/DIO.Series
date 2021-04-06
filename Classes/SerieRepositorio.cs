// 
// 
// 
// 
// Faz a mediação entre o programa e este "banco de dados".
// Organizaçao superior do código.
// 

using System;
using System.Collections.Generic;
using DIO.Series.Interfaces;

namespace DIO.Series
{
    public class SerieRepositorio : IRepositorio<Serie> //implementa uma interface e o repostorio especificamente de "Serie".
    {                                                   //O "<Serie>" acima, é o que vai ser entendido como T. Quando compilado, o T é substuido pela "<Serie>"

    //Métodos implementados automaticamente pelo Visual Studio Code, promptados como obrigatório após a herança\/\/\/
        private List<Serie> listaSerie = new List<Serie>();
        public void Atualiza(int id, Serie objeto)
        {
            listaSerie[id] = objeto; //recebe o objeto e coloca na posicao do vetor
        }

        public void Exclui(int id)
        {
            listaSerie[id].Excluir(); //nao foi usado "Remove.At(id)" pois pode causar inconsistencia, ao reclassificar os items após a exclusao.
        }                             //criado um método "Exluir" para marcar o "Excluido" em "true" e um booleano em "Serie.cs" para verificar a exclusao, e a cada serie criado é colocado com valor "false" incialmente.

        public void Insere(Serie objeto)
        {
            listaSerie.Add(objeto); // Usado método "Add" para adicionar um novo objeto.
        }

        public List<Serie> Lista()
        {
            return listaSerie; // retorna para a lista de series.
        }

        public int ProximoId()
        {
            return listaSerie.Count; // Considerando a garantia de nenhuma exclusao da lista, retorna o proximo id.
        }

        public Serie RetornaPorId(int id)
        {
            return listaSerie[id]; // retorna o "listaSerie[id]" 
        }
    }
}