using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CrewApp
{
    class Crew : IList<Worker>, IComparer<Worker>
    {
        private List<Worker> workers = new List<Worker>();

        public Worker this[int index] { get => workers.ElementAt(index); set => workers.Insert(index,value); }

        public int Count => workers.Count;

        public bool IsReadOnly => false;

        public void Add(Worker item) => workers.Add(item);

        public void Clear() => workers.Clear();

        public int Compare(Worker x, Worker y) => x.Position.CompareTo(y.Position);

        public bool Contains(Worker item) => workers.Contains(item);

        public void CopyTo(Worker[] array, int arrayIndex)
        {
            foreach (Worker worker in workers)
                array.SetValue(worker, arrayIndex++);
        }

        public IEnumerator<Worker> GetEnumerator() => workers.GetEnumerator();

        public int IndexOf(Worker item) => workers.IndexOf(item);

        public void Insert(int index, Worker item) => workers.Insert(index, item);

        public bool Remove(Worker item) => workers.Remove(item);

        public void RemoveAt(int index) => workers.RemoveAt(index);

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public void ShowCrew()
        {
            foreach (Worker worker in workers)
                worker.Show();
        }

        public void Sort() => workers.Sort(new Crew());

    }
}
