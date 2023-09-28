using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WinHomeTaskPattern3.Class1;

namespace WinHomeTaskPattern3
{
    internal class Class1
    {
        // Інтерфейс ітератора
        public interface IComputerIterator
        {
            Computer First();
            Computer Next();
            bool IsDone();
            Computer CurrentItem();
        }

        // Інтерфейс агрегата
        public interface IComputerAggregate
        {
            IComputerIterator CreateIterator();
        }
        public class Computer
        {
            public string Model { get; set; }
            public string Processor { get; set; }
            public int MemoryGB { get; set; }
            public int StorageGB { get; set; }
            public string GraphicsCard { get; set; }
        }
        // Колекція комп'ютерів
        public class ComputerCollection : IComputerAggregate
        {
            private List<Computer> computers = new List<Computer>();

            public void AddComputer(Computer computer)
            {
                computers.Add(computer);
            }

            public IComputerIterator CreateIterator()
            {
                return new ComputerIterator(this);
            }

            public Computer GetComputer(int index)
            {
                return computers[index];
            }

            public int Count()
            {
                return computers.Count;
            }
        }
        // Ітератор для колекції комп'ютерів
        public class ComputerIterator : IComputerIterator
        {
            private ComputerCollection collection;
            private int current = 0;

            public ComputerIterator(ComputerCollection collection)
            {
                this.collection = collection;
            }

            public Computer First()
            {
                current = 0;
                return collection.GetComputer(current);
            }

            public Computer Next()
            {
                current++;
                if (!IsDone())
                {
                    return collection.GetComputer(current);
                }
                else
                {
                    return null;
                }
            }

            public bool IsDone()
            {
                return current >= collection.Count();
            }

            public Computer CurrentItem()
            {
                return collection.GetComputer(current);
            }
        }
    }
}
