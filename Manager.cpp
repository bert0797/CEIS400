#include "Manager.h"


Manager::Manager(void)
{
	this->strFName = "";
	this->strLName = "";
	this->strDepartment = "";
	this->intNumEmployees = 0;
}

Manager::~Manager(void)
{
}

Manager::Manager(string fName, string lName, string Dept, int NumEmployees)
{
	this->strFName = fName;
	this->strLName = lName;
	this->strDepartment = Dept;
	this->intNumEmployees = NumEmployees;
}

void Manager::setName (string fName, string lName)
{
	this->strFName = fName;
	this->strLName = lName;
	strManName = strFName + " " + strLName;
}

string Manager::getName (void)
{
	return strManName;
}