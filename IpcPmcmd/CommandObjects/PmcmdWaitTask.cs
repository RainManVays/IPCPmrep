﻿namespace IPCUtilities.IpcPmcmd.CommandObjects
{
    public class PmcmdWaitTask: PmcmdGetTaskDetails
    {
        private string _workflowRunId;

        public string WorkflowRunId { get { return _workflowRunId; } set { _workflowRunId = " -wfrunid " + value; } }
    }
}
