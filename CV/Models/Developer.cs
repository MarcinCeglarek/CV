﻿namespace CV.Models
{
    #region

    using System.Collections.Generic;

    using CV.Enums;

    #endregion

    public abstract class Developer
    {
        #region Public Methods and Operators

        public abstract IDictionary<string, Level> Skills();

        public abstract List<Employer> WorkExperience();

        public abstract List<School> Education();

        #endregion
    }
}