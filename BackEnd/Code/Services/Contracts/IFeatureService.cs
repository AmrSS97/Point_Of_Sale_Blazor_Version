using Data.Repositories;
using Models;
using System;

namespace Services
{

    public interface IFeatureService
    {
        Feature GetFeature(Guid id);
        void CreateFeature(Feature Feature);
        void SaveFeature();
    }
}
