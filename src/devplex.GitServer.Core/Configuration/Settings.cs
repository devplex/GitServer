﻿namespace devplex.GitServer.Core.Configuration
{
    public class Settings
    {
        private static GitServerSection _section;
        public static GitServerSection Section
        {
            get
            {
                return _section ?? (_section = GitServerSection.GetSection());
            }
        }
    }
}