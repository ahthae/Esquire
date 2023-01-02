using System;
using System.Collections.Generic;
using System.Data.Common;
using esquire.Models;
using esquire.Services.Settings;

namespace esquire.Services;

public interface IDatabaseService
{
    public string CreateConnectionString();
    public string CreateConnectionString(Options settings);
    public DbConnection? GetConnection();
    public DbConnection? GetConnection(Options settings);
}