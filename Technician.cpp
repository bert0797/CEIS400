#include <iostream>
#include <string.h>
#include "Technician.h"

using namespace std;

Technician::Technician(void)
{
	this-> strName = "";
	this-> dblEmployeeNumber = 0;
}


Technician::~Technician(void)
{
}

Technician::Technician (string Name, double EmpNum)
{
	this-> strName = Name;
	this-> dblEmployeeNumber = EmpNum;

}

void Technician::setEmployee (string Name, double EmpNum)
{
	strName = Name;
	dblEmployeeNumber = EmpNum;
}

string Technician::getName (void)
{	
	return strName;
}

void Technician::setEmpNum (double EmpNum)
{
	dblEmployeeNumber = EmpNum;
}

double Technician::getEmpNum (void)
{
	return dblEmployeeNumber;
}

