﻿using _11.SnsDomain.Models.Users;

namespace _11.SnsDomain.Models.Circles
{
    public interface ICircleFactory
    {
        Circle Create(CircleName name, User owner);
    }
}
