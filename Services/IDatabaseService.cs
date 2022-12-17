using System;
using System.Collections.Generic;
using System.Data.Common;
using esquire.Models;

namespace esquire.Services;

public interface IDatabaseService
{
    public DbProviderFactory Factory { get; init; }

    public void Query<T>(List<T> list) where T : BusinessUnit;
    
    
}