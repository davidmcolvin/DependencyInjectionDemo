﻿using DemoLibrary.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
  public class BetterBusinessLogic : IBusinessLogic
  {
    ILogger _logger;
    IDataAccess _dataAccess;
    public BetterBusinessLogic(ILogger logger, IDataAccess dataAccess)
    {
      _logger = logger;
      _dataAccess = dataAccess;
    }

    public void ProcessData()
    {
      _logger.Log("Starting the processing of data.");
      Console.WriteLine();
      Console.WriteLine("Processing the data");
      Console.WriteLine();
      _dataAccess.LoadData();
      Console.WriteLine();
      _dataAccess.SaveData("ProcessedInfo");
      Console.WriteLine();
      _logger.Log("Finished Processing of the data.");
      Console.WriteLine();
    }
  }
}
