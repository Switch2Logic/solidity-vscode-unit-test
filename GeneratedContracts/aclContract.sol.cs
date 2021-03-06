//504d799533680ce3cd17affe0833a9e9a239525d3fdfde2ee0534da331f253b8
// NOTICE: Do not change this file. This file is auto-generated and any changes will be reset.
// Generated date: 2019-03-01T08:38:49 (UTC)
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

using Meadow.Contract;
using Meadow.Core.AbiEncoding;
using Meadow.Core.EthTypes;
using Meadow.Core.Utils;
using Meadow.JsonRpc.Types;
using SolcNet.DataDescription.Output;
using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace solidity_vscode_unit_test
{
    /// <summary>From file aclContract.sol<para/></summary>
    [Meadow.Contract.SolidityContractAttribute(typeof(aclContract), CONTRACT_SOL_FILE, CONTRACT_NAME)]
    public class aclContract : Meadow.Contract.BaseContract
    {
        public static Lazy<byte[]> BYTECODE_BYTES = new Lazy<byte[]>(() => Meadow.Core.Utils.HexUtil.HexToBytes(GeneratedSolcData<aclContract>.Default.GetSolcBytecodeInfo(CONTRACT_SOL_FILE, CONTRACT_NAME).Bytecode));
        public const string CONTRACT_SOL_FILE = "aclContract.sol";
        public const string CONTRACT_NAME = "aclContract";
        protected override string ContractSolFilePath => CONTRACT_SOL_FILE;
        protected override string ContractName => CONTRACT_NAME;
        private aclContract(Meadow.JsonRpc.Client.IJsonRpcClient rpcClient, Meadow.Core.EthTypes.Address address, Meadow.Core.EthTypes.Address defaultFromAccount): base(rpcClient, address, defaultFromAccount)
        {
            Meadow.Contract.EventLogUtil.RegisterDeployedContractEventTypes(address.GetHexString(hexPrefix: true), typeof(solidity_vscode_unit_test.aclContract.LogAccess));
        }

        public static async Task<aclContract> At(Meadow.JsonRpc.Client.IJsonRpcClient rpcClient, Meadow.Core.EthTypes.Address address, Meadow.Core.EthTypes.Address? defaultFromAccount = null)
        {
            defaultFromAccount = defaultFromAccount ?? (await rpcClient.Accounts())[0];
            return new aclContract(rpcClient, address, defaultFromAccount.Value);
        }

        public aclContract()
        {
        }

        /// <summary>
        /// Deploys the contract.  <para/>
        /// </summary>
         
        /// <param name = "rpcClient">The RPC client to be used for this contract instance.</param>
        /// <param name = "defaultFromAccount">If null then the first account returned by eth_accounts will be used.</param>
        /// <returns>An contract instance pointed at the deployed contract address.</returns>
        public static async Task<aclContract> Deploy(Meadow.JsonRpc.Client.IJsonRpcClient rpcClient, Meadow.JsonRpc.Types.TransactionParams transactionParams = null, Meadow.Core.EthTypes.Address? defaultFromAccount = null)
        {
            transactionParams = transactionParams ?? new Meadow.JsonRpc.Types.TransactionParams();
            defaultFromAccount = defaultFromAccount ?? transactionParams.From ?? (await rpcClient.Accounts())[0];
            transactionParams.From = transactionParams.From ?? defaultFromAccount;
            var encodedParams = Array.Empty<byte>();
            var contractAddr = await ContractFactory.Deploy(rpcClient, BYTECODE_BYTES.Value, transactionParams, encodedParams);
            return new aclContract(rpcClient, contractAddr, defaultFromAccount.Value);
        }

        /// <summary>
        /// Deploys the contract.  <para/>
        /// </summary>
         
        /// <param name = "rpcClient">The RPC client to be used for this contract instance.</param>
        /// <param name = "defaultFromAccount">If null then the first account returned by eth_accounts will be used.</param>
        /// <returns>An contract instance pointed at the deployed contract address.</returns>
        public static ContractDeployer<aclContract> New(Meadow.JsonRpc.Client.IJsonRpcClient rpcClient, Meadow.JsonRpc.Types.TransactionParams transactionParams = null, Meadow.Core.EthTypes.Address? defaultFromAccount = null)
        {
            var encodedParams = Array.Empty<byte>();
            return new ContractDeployer<aclContract>(rpcClient, BYTECODE_BYTES.Value, transactionParams, defaultFromAccount, encodedParams);
        }

        [Meadow.Contract.EventSignatureAttribute(SIGNATURE)]
        public class LogAccess : Meadow.Contract.EventLog
        {
            public override string EventName => "LogAccess";
            public override string EventSignature => SIGNATURE;
            public const string SIGNATURE = "d114fdd66c4524801ee92e5d6d9db879e73730efc8ba069ae8d56046bd4e2d4d";
            // Event log parameters.
            public readonly Meadow.Core.EthTypes.Address by;
            public readonly Meadow.Core.EthTypes.UInt256 accessTime;
            public readonly System.String method;
            public readonly System.String desc;
            public LogAccess(Meadow.JsonRpc.Types.FilterLogObject log): base(log)
            {
                // Decode the log topic args.
                Span<byte> topicBytes = MemoryMarshal.AsBytes(new Span<Meadow.Core.EthTypes.Data>(log.Topics).Slice(1));
                AbiTypeInfo[] topicTypes = new AbiTypeInfo[]{"address", "uint256"};
                var topicBuff = new AbiDecodeBuffer(topicBytes, topicTypes);
                DecoderFactory.Decode(topicTypes[0], ref topicBuff, out by);
                DecoderFactory.Decode(topicTypes[1], ref topicBuff, out accessTime);
                // Decode the log data args.
                Span<byte> dataBytes = log.Data;
                AbiTypeInfo[] dataTypes = new AbiTypeInfo[]{"string", "string"};
                var dataBuff = new AbiDecodeBuffer(dataBytes, dataTypes);
                DecoderFactory.Decode(dataTypes[0], ref dataBuff, out method);
                DecoderFactory.Decode(dataTypes[1], ref dataBuff, out desc);
                // Add all the log args and their metadata to a collection that can be checked at runtime.
                LogArgs = new(string Name, string Type, bool Indexed, object Value)[]{("by", "address", true, by), ("accessTime", "uint256", true, accessTime), ("method", "string", false, method), ("desc", "string", false, desc)};
            }
        }

        /// <summary> <para/>Returns <c>address</c></summary>
        /// <param name = "unamed0"><c>uint256</c></param>
        public EthFunc<Meadow.Core.EthTypes.Address> users(Meadow.Core.EthTypes.UInt256 unamed0)
        {
            var callData = Meadow.Core.AbiEncoding.EncoderUtil.GetFunctionCallBytes("users(uint256)", EncoderFactory.LoadEncoder("uint256", unamed0));
            return EthFunc.Create<Meadow.Core.EthTypes.Address>(this, callData, "address", DecoderFactory.Decode);
        }

        /// <summary></summary>
        /// <param name = "user"><c>address</c></param>
        public EthFunc addUser(Meadow.Core.EthTypes.Address user)
        {
            var callData = Meadow.Core.AbiEncoding.EncoderUtil.GetFunctionCallBytes("addUser(address)", EncoderFactory.LoadEncoder("address", user));
            return EthFunc.Create(this, callData);
        }

        /// <summary> <para/>Returns <c>bool</c></summary>
        /// <param name = "candidate"><c>address</c></param>
        /// <param name = "method"><c>string</c></param>
        public EthFunc<System.Boolean> isUser(Meadow.Core.EthTypes.Address candidate, System.String method)
        {
            var callData = Meadow.Core.AbiEncoding.EncoderUtil.GetFunctionCallBytes("isUser(address,string)", EncoderFactory.LoadEncoder("address", candidate), EncoderFactory.LoadEncoder("string", method));
            return EthFunc.Create<System.Boolean>(this, callData, "bool", DecoderFactory.Decode);
        }

        /// <summary></summary>
        /// <param name = "i"><c>uint256</c></param>
        public EthFunc deleteIthUser(Meadow.Core.EthTypes.UInt256 i)
        {
            var callData = Meadow.Core.AbiEncoding.EncoderUtil.GetFunctionCallBytes("deleteIthUser(uint256)", EncoderFactory.LoadEncoder("uint256", i));
            return EthFunc.Create(this, callData);
        }

        /// <summary> <para/>Returns <c>address</c></summary>
        public EthFunc<Meadow.Core.EthTypes.Address> owner()
        {
            var callData = Meadow.Core.AbiEncoding.EncoderUtil.GetFunctionCallBytes("owner()");
            return EthFunc.Create<Meadow.Core.EthTypes.Address>(this, callData, "address", DecoderFactory.Decode);
        }

        /// <summary> <para/>Returns <c>uint256</c></summary>
        public EthFunc<Meadow.Core.EthTypes.UInt256> getUserCount()
        {
            var callData = Meadow.Core.AbiEncoding.EncoderUtil.GetFunctionCallBytes("getUserCount()");
            return EthFunc.Create<Meadow.Core.EthTypes.UInt256>(this, callData, "uint256", DecoderFactory.Decode);
        }

        /// <summary> <para/>Returns <c>address</c></summary>
        /// <param name = "i"><c>uint256</c></param>
        public EthFunc<Meadow.Core.EthTypes.Address> getUserByIndex(Meadow.Core.EthTypes.UInt256 i)
        {
            var callData = Meadow.Core.AbiEncoding.EncoderUtil.GetFunctionCallBytes("getUserByIndex(uint256)", EncoderFactory.LoadEncoder("uint256", i));
            return EthFunc.Create<Meadow.Core.EthTypes.Address>(this, callData, "address", DecoderFactory.Decode);
        }

        /// <summary>The contract fallback function. <para/></summary>
        public EthFunc FallbackFunction => EthFunc.Create(this, Array.Empty<byte>());
    }
}
