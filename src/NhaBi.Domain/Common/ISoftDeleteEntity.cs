﻿namespace NhaBi.Domain.Common
{
    public interface ISoftDeleteEntity
    {
        bool IsDeleted { get; set; }
    }
}