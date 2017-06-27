﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPCUtilities
{
    namespace IpcPmcmd
    {
        /// <summary>
        /// Manage workflows. Use pmcmd to start, stop, schedule, and monitor workflows.
        /// </summary>
        public class Pmcmd
        {
            private string _pmcmdFile;
            private PmcmdConnection _connectionValue;
            private string _connectionCommand = "";
            PmcmdWorker _pmwork;
            public Pmcmd(string pmcmdfile, PmcmdConnection parameters, string logFile = null)
            {

                if (!File.Exists(pmcmdfile))
                    throw new FileNotFoundException("File not found!", pmcmdfile);
                _pmcmdFile = pmcmdfile;
                _connectionValue = parameters ?? throw new ArgumentNullException("parameters", "parameters is null");
                _connectionCommand = "connect " + parameters.Domain + parameters.Service + parameters.Password + parameters.UserName;
                _pmwork = new PmcmdWorker(pmcmdfile, _connectionCommand);
                // PmcmdWorker.ExecuteCommand(pmcmdfile, command);

            }

            public bool AbortTask()
            {
                return false;
            }
            public bool Abortworkflow()
            {
                return false;
            }
            public bool Disconnect()
            {
                return false;
            }
            public bool Exit()
            {
                return false;
            }
            public string GetRunningSessionsDetails()
            {
                var command = "getrunningsessionsdetails";
                var result = _pmwork.ExecuteCommand(command);
                return result;
            }
            public string GetServiceDetails(WorkflowsStatus type)
            {
                var command = "getservicedetails " + type.Value;
                var result = _pmwork.ExecuteCommand(command);
                return result;
            }
            public string GetServiceDetailsData(WorkflowsStatus type)
            {
                var command = "getservicedetails " + type.Value;
                var result = _pmwork.ExecuteCommand(command);
                return result;
            }
            public string GetServiceProperties()
            {
                var command = "getserviceproperties";
                var result = _pmwork.ExecuteCommand(command);
                return result;
            }
            public bool GetSessionStatistics()
            {
                return false;
            }
            public bool GetTaskDetails()
            {
                return false;
            }
            public bool GetWorkflowDetails()
            {
                return false;
            }
            public bool PingService()
            {
                var command = "pingservice";
                var result = _pmwork.ExecuteCommand(command);
                if (result.ToLower(CultureInfo.CurrentCulture).Contains("integration service is alive"))
                {
                    return true;
                }
                return false;
            }
            public bool RecoverWorkflow()
            {
                return false;
            }
            public bool ScheduleWorkflow()
            {
                return false;
            }
            public string ShowSettings()
            {
                var command = "showsettings";
                var result = _pmwork.ExecuteCommand(command);
                return result;
            }
            public bool StartTask()
            {
                return false;
            }
            public bool StartWorkflow()
            {
                return false;
            }
            public bool StopTask()
            {
                return false;
            }
            public bool StopWorkflow()
            {
                return false;
            }
            public bool UnscheduleWorkflow()
            {
                return false;
            }
            public string Version()
            {
                var command = "version";
                var result = _pmwork.ExecuteCommand(command);
                return result;
            }

            public bool WaitTask()
            {
                return false;
            }
            public bool WaitWorkflow()
            {
                return false;
            }

        }
    }
}
