pragma solidity 0.4.25;


contract aclContract {
    
    address public owner;     

    address[] public users;

    event LogAccess(address indexed by, uint indexed accessTime, string method, string desc);

    constructor() public {
    
        owner = msg.sender;
        users.push(owner);
    }


    function addUser(address user) public{
        if (msg.sender != owner) revert("Adding A user failed");
        users.push(user);

    }

    function getUserByIndex(uint i) public returns (address){
        return users[i];

    }

    function getUserCount() public returns (uint){
        return users.length;

    }
   
    function deleteIthUser(uint i) public {
        if (msg.sender != owner) revert("Deleting user failed");
        delete users[i];

    }

    function isUser(address candidate, string method) public returns (bool){

        for(uint8 i = 0; i < users.length; i++){

            if (users[i] == candidate){               
                LogAccess(candidate, now, method, "Successful access");
                return true;

            }

        }      
        LogAccess(candidate, now,method,  "Failed access");
        return false;

    }

}