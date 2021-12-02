#include <iostream>
#include <string.h>
#include "Manager.h"


Manager::Manager(void)
{
	this->strName = "";
	this->strDepartment = "";
	this->intNumEmployees = 0;
}

Manager::~Manager(void)
{
}

Manager::Manager(string Name, string Dept, int NumEmployees)
{
	this->strName = Name;
	this->strDepartment = Dept;
	this->intNumEmployees = NumEmployees;
}

void Manager::setManager (string Name, string Dept, int NumEmp )
{
	strName = Name;
	strDepartment = Dept;
	intNumEmployees = NumEmp;
}

string Manager::getName (void)
{
	return strName;
}

string Manager::getDept (void)
{
	return strDepartment;
}

int Manager::getNumEmp (void)
{
	return intNumEmployees;
}


