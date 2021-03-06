﻿using System.Collections.Generic;

namespace SnsApplication.Domain.Models.Circles
{
    public interface ICircleRepository
    {
        Circle Find(CircleId id);
        Circle Find(CircleName name);
        List<Circle> FindAll();
        void Save(Circle circle);
        void Delete(Circle circle);
    }
}
