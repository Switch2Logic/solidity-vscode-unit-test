# Solidity Unit Test with Visual Studio Code Setup
`$ dotnet new console --name solidity-vscode-unit-test`

`$ cd solidity-vscode-unit-test`

`$ dotnet add package Meadow.UnitTestTemplate`

`$ mkdir contracts`

# Add and Run Smart Contracts
Add/Create your smart contracts to/in the contracts folder

`$ dotnet build`

A GeneratedContracts folder would be generated. Now in the project root create a unittest.cs class that inherits form :ContractTest. Write test and start debugging your smart contracts. 

# After debugging a report is generated wich is super usefull. 
