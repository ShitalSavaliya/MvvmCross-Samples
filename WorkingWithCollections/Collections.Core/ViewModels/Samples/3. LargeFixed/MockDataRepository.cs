using Collections.Core.ViewModels.Samples.ListItems;
using System.Collections.Generic;

namespace Collections.Core.ViewModels.Samples.LargeFixed
{
    public class MockDataRepository
    {
        private readonly List<Kitten> _kittens;

        public MockDataRepository()
        {
            _kittens = new List<Kitten>();
            var generator = new KittenGenerator();
            for (int i = 0; i < 100; i++)
            {
                _kittens.Add(generator.CreateNewKitten());
            }
        }

        public int GetCount()
        {
            return _kittens.Count;
        }

        public Kitten GetKitten(int i)
        {
            return _kittens[i];
        }
    }
}