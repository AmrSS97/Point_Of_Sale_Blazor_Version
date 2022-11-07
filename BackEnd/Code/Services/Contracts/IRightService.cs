using Data.Repositories;
using Models;
using System;

namespace Services
{

    public interface IRightService
    {
        Right GetRight(Guid id);
        void CreateRight(Right Right);
        void SaveRight();
    }
}
