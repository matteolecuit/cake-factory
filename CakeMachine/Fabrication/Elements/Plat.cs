﻿namespace CakeMachine.Fabrication.Elements
{
    internal class Plat : IConforme
    {
        /// <inheritdoc />
        public bool EstConforme => true;

        /// <inheritdoc />
        public Plat PlatSousJacent => this;

        private bool _hasSuccessor;

        public void Lock(GâteauCru _)
        {
            if (_hasSuccessor) 
                throw new InvalidOperationException("Ce plat a déjà été utilisé pour un premier gâteau ! " +
                                                    "N'essayez pas de frauder.");
            _hasSuccessor = true;
        }
    }
}
