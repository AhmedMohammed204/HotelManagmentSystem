﻿using System;

namespace MyClassLibrary
{
    public static class clsErrorHandling
    {
        public static void HandleError(Exception ex)
        {
            clsLogging logging = new clsLogging("Stegi Hotle");
            logging.Write($"Error:{ex.Message}", System.Diagnostics.EventLogEntryType.Error);

        }
    }
}