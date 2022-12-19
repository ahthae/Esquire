using System;
using System.Collections.Generic;
using System.Data.Common;
using esquire.Models;

namespace esquire.Services;

public interface IDatabaseService
{
    public DbConnection? GetConnection();
}