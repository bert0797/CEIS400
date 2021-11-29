#include <iostream>
#include <string.h>
#include "Technician.h"

using namespace std;

Technician::Technician(void)
{
	this-> strFName = "";
	this-> strLName = "";
	this-> dblEmployeeNumber = 0;
}


Technician::~Technician(void)
{
}

Technician::Technician (string fName, string lName, double EmpNum)
{
	this-> strFName = fName;
	this-> strLName = lName;
	this->dblEmployeeNumber = EmpNum;

}

void Technician::setName (string fName, string lName)
{
	this->strFName = fName;
	this->strLName = lName;
}

string Technician::getName (void)
{
	return strFName + " " + strLName;
}