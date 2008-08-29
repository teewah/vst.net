﻿namespace Jacobi.Vst.Core.Plugin
{
    /// <summary>
    /// The Plugin Command Stub called by the Interop.
    /// </summary>
    public interface IVstPluginCommandStub : IVstPluginCommands24
    {
        /// <summary>
        /// Retrieves the plugin info to pass onto the host.
        /// </summary>
        /// <param name="hostCmdStub">A reference to the host command stub the plugin can use to call the host.</param>
        /// <returns>Returns an instance with the plugin info filled in. 
        /// If null is returned the plugin load sequence is aborted.</returns>
        VstPluginInfo GetPluginInfo(IVstHostCommandStub hostCmdStub);
    }
}
