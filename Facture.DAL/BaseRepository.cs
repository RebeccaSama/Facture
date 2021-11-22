using MyLibs.Serialisation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Facture.DAL
{
    public class BaseRepository<T>
    {
        protected List<T> datas;
        protected readonly string PATH;
        private Serializer<List<T>> serializer;
        public BaseRepository()
        {
            datas = new List<T>();
            PATH = $"Data/{typeof(T).Name}.json";
            FileInfo fi = new FileInfo(PATH);
            if (!fi.Directory.Exists)
                fi.Directory.Create();

            serializer = new Serializer<List<T>>(Mode.JSON, PATH);

            Restore();
        }

        public void Add(T obj)
        {
            foreach (var data in datas)
                if (data.Equals(obj))
                    throw new DuplicateWaitObjectException($"{nameof(T)} already exists !");
            datas.Add(obj);
            Save();
        }

        public void Set(T OldObj, T NewObj)
        {
            Console.WriteLine(datas.Count);
            var OldIndex = -1;
            for (int i = 0; i < datas.Count; i++)
                if (datas[i].Equals(OldObj))
                    OldIndex = i;
            if (OldIndex < 0)
                throw new KeyNotFoundException($"{nameof(T)} not found !");

            var NewIndex = -1;
            for (int i = 0; i < datas.Count; i++)
                if (datas[i].Equals(NewObj))
                    NewIndex = i;
            if (NewIndex >= 0 && NewIndex != OldIndex)
                throw new KeyNotFoundException($"{nameof(T)} already exists !");
            datas[OldIndex] = NewObj;
        }

        public void Delete(T obj)
        {
            var index = -1;
            for (int i = 0; i < datas.Count; i++)
                if (datas[i].Equals(obj))
                    index = i;
            if (index >= 0)
                datas.RemoveAt(index);
            Save();
        }

        public List<T> GetAll()
        {
            T[] copy = new T[datas.Count];
            datas.CopyTo(copy);
            return copy.ToList();
        }
        public void Save()
        {
            serializer.Serialize(datas);
        }
        private void Restore()
        {
            FileInfo fi = new FileInfo(PATH);
            if (fi.Exists && fi.Length > 0)
                datas = serializer.Deserialize();
        }
        public T findByIndex(int Index)
        {
            if (Index < 0 || Index >= datas.Count)
                throw new KeyNotFoundException($"{typeof(T).Name} with index not found !");
            return datas[Index];
        }
    }
}
