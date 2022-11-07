using Data.Infrastructure;
using Data.Repositories;
using Models;
using System;

namespace Services
{

    public class FeatureService : IFeatureService
    {
        private readonly IFeatureRepository FeatureRepository;
        private readonly IUnitOfWork unitOfWork;

        public FeatureService(IFeatureRepository FeatureRepository, IUnitOfWork unitOfWork)
        {
            this.FeatureRepository = FeatureRepository;
            this.unitOfWork = unitOfWork;
        }

        #region IApplicationService Members


        public Feature GetFeature(Guid id)
        {
            var Feature = FeatureRepository.GetById(id);
            return Feature;
        }

        public void CreateFeature(Feature Feature)
        {
            FeatureRepository.Add(Feature);
        }


        public void SaveFeature()
        {
            unitOfWork.SaveChanges();
        }

   

        #endregion
    }
}
