using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;

namespace Ejercicio_2
{
    public class Fifo<T>
    {
        public List<T> fifo;

        public Fifo(){
            fifo = new List<T>();
        }

        public void Add(T item){
            fifo.Add(item);
        }
        public T Get(){
            var firstItem = fifo[0];
            fifo.RemoveAt(0);
            return firstItem;
        }        
        public void Delete(int index){
            fifo.RemoveAt(index);
        }

        public int GetLength(){
            return fifo.Count;
        }

        public T GetMin(){
            return fifo[0];
        }

        public T GetMax(){
            return fifo[fifo.Count-1];
        }
        
        public T Find(int index){
            return fifo[index];
        }

        public void PrintAll(){
            var i = 0;
            foreach(T item in fifo){
                Console.WriteLine("Indice " + i + ": " + item);
                i++;
            }
        }
    }
}