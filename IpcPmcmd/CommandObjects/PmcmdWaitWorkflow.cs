﻿namespace IPCUtilities.IpcPmcmd
{
    public class PmcmdWaitWorkflow:AbstractTaskParams
    {
        private string _workflow;
        public string Workflow { get { return _workflow; } set { _workflow = " " + value; } }
    }
}
