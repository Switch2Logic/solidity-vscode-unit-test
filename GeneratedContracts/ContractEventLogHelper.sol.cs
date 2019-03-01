//228795f3707d1ad5c4e69df94ede36f21463d36308b8fb66e67760b5138b6ed1
// NOTICE: Do not change this file. This file is auto-generated and any changes will be reset.
// Generated date: 2019-03-01T08:38:50 (UTC)
#pragma warning disable SA1000 // The keyword 'new' should be followed by a space

#pragma warning disable SA1003 // Symbols should be spaced correctly

#pragma warning disable SA1008 // Opening parenthesis should be preceded by a space

#pragma warning disable SA1009 // Closing parenthesis should be spaced correctly

#pragma warning disable SA1011 // Closing square brackets should be spaced correctly

#pragma warning disable SA1012 // Opening brace should be preceded by a space

#pragma warning disable SA1013 // Closing brace should be preceded by a space

#pragma warning disable SA1024 // Colons Should Be Spaced Correctly

#pragma warning disable SA1128 // Put constructor initializers on their own line

#pragma warning disable SA1300 // Element should begin with upper-case letter

#pragma warning disable SA1307 // Field names should begin with upper-case letter

#pragma warning disable SA1313 // Parameter names should begin with lower-case letter

#pragma warning disable IDE1006 // Naming Styles

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;
using Meadow.JsonRpc.Types;

namespace solidity_vscode_unit_test
{
    public static class ContractEventLogHelper
    {
        public static Meadow.Contract.EventLog Parse(string eventSignatureHash, Meadow.JsonRpc.Types.FilterLogObject log)
        {
            var eventLog = Meadow.Contract.EventLogUtil.Parse(eventSignatureHash, log);
            if (eventLog != null)
            {
                return eventLog;
            }

            // Switch on the event signature hash and the number of indexed event arguments.
            switch (eventSignatureHash + "_" + (log.Topics.Length - 1).ToString("00", CultureInfo.InvariantCulture))
            {
                case "d114fdd66c4524801ee92e5d6d9db879e73730efc8ba069ae8d56046bd4e2d4d_02":
                    return new solidity_vscode_unit_test.aclContract.LogAccess(log);
                // Event with duplicate signature: solidity_vscode_unit_test.patientContract.LogAccess
                default:
                    return null;
            }
        }
    }
}
