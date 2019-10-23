﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ACME.BL
{
    public abstract class EntityBase
    {
        public enum EntityStateOption
        {
            Active,
            Deleted
        }
        public bool IsNew { get; private set; }
        public bool HasChanges { get; set; }
        public bool IsValid => Validate();
        public EntityStateOption EntityState { get; set; }

        public abstract bool Validate();
    }
}
