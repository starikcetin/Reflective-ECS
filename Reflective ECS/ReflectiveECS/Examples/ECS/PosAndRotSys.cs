﻿namespace ReflectiveECS.Examples.ECS
{
    public class PosAndRotSys : ISystem
    {
        [Execute]
        public void Execute(PosComp posComp, RotComp rotComp)
        {
            posComp.X++;
            posComp.Y++;
            rotComp.Angle++;
        }
    }
}
