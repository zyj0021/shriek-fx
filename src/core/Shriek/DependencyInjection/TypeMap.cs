﻿using System;
using System.Collections.Generic;

namespace Shriek.DependencyInjection
{
    internal class TypeMap
    {
        public TypeMap(Type implementationType, IEnumerable<Type> serviceTypes)
        {
            ImplementationType = implementationType;
            ServiceTypes = serviceTypes;
        }

        public Type ImplementationType { get; }

        public IEnumerable<Type> ServiceTypes { get; }
    }
}
