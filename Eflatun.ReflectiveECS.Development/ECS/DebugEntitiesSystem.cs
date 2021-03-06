﻿using System;
using Eflatun.ReflectiveECS.Core;
using Eflatun.ReflectiveECS.Core.ECS;

namespace Eflatun.ReflectiveECS.Development.ECS
{
    public class DebugEntitiesSystem : ISystem
    {
        [Execute]
        public void Execute(Entity entity)
        {
            Console.WriteLine($"entity {entity.Id}");
            foreach (var component in entity.Components)
            {
                Console.WriteLine("\t" + component.GetType().Name);

                var fields = component.GetType().GetFields();
                foreach (var fieldInfo in fields)
                {
                    Console.WriteLine($"\t\t{fieldInfo.Name} = {fieldInfo.GetValue(component)}");
                }
            }
            Console.WriteLine();
        }
    }
}
