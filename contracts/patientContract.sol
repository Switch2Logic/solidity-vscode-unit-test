pragma solidity 0.4.25;

import "./aclContract.sol";


contract patientContract is aclContract {

    uint constant active = 1;
    uint constant pending = 2;
    uint constant deleted = 3;
    uint public count = 0;

    struct Patient{
        uint id;
        string name;
        uint dateOfBirth;
        uint social;
        uint status;
    }

    mapping (uint => Patient) Patients;
    

    function updatePatient(uint index, string name) public {

        if (isUser(msg.sender, "updatePatient")) {

            if (index > count) revert();
            Patients[index].name = name;

        }
        else revert();
    }

    function updatePatientStatus(uint index, uint status) public {

        if (isUser(msg.sender, "updatePatient")) {

            if (index > count) revert();
            Patients[index].status = status;

        }  
        else revert();
    }

    function createPatient(uint id,string name,uint dateOfBirth,uint social) public {

        if (isUser(msg.sender, "createPatient")) {
            Patients[count] = Patient(id, name, dateOfBirth, social, pending);
            count++;
        }
        else revert();
    }
    function getPatientById(uint id) public returns (string) {

        for (var i=0; i <= count; i++)
        {
            if (Patients[i].id == id) {
                return "Found patient";
            }
            else revert("Patient not found");
        }

    }
}