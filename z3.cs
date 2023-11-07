using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace dz3_z3
{
    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }

        public Node(T data)
        {
            Data = data;
        }
    }

    public class _Stack<T>
    {
        private Node<T> top;
        public int countt;

        public _Stack()
        {
            top = null;
            countt = 0;
        }

        public bool IsEmpty()
        {
            return countt == 0;
        }

        public int Size()
        {
            return countt;
        }

        public void Push(T data)
        {
                Node<T> newNode = new Node<T>(data);
                newNode.Next = top;
                top = newNode;
                countt++;
    
            
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Стек пуст");
            }
            T temp = top.Data;
            top = top.Next;
            countt--;
            return temp;
        }
    }
        internal class z3
        {
            public static bool Check(string str)
            {
                _Stack<char> myStack = new _Stack<char>();
                int CloseCkobki = 0;
                foreach (char value in str.ToCharArray())
                {
                    if (value == '(')
                    {
                        myStack.Push(value);
                    }
                    else if (value == ')')
                    {
                        CloseCkobki++;
                        try
                        {
                            myStack.Pop();
                        }
                        catch (InvalidOperationException e)
                        {
                            Console.WriteLine("Лишняя {0} закрывающая скобка", CloseCkobki);
                            return false;
                        }
                    }
                }
                if (myStack.countt != 0)
                {
                    Console.WriteLine(" Количество лишних открывающих скобок :" + myStack.Size());
                    return false;
                }
                Console.WriteLine("Скобки расставлены верно");
                return true;
            }
            static void Main()
            {

                string str = Console.ReadLine();
                Check(str);
            }
        }
 }
