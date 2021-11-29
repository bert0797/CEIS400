#include <iostream>
#include <string.h>
#include "Equipment.h"


Equipment::Equipment(void)
{
	this->strCondition = "";
	this->strEquipType = "";
	this->chaAvailable = ' ';
}


Equipment::~Equipment(void)
{
}

Equipment::Equipment(string Cond, string Type, char Avail)
{
	this->strCondition = Cond;
	this->strEquipType = Type;
	this->chaAvailable = Avail;
}

void Equipment::setEquipment (string Cond, string Type, char Avail)
{
	this->strCondition = Cond;
	this->strEquipType = Type;
	this->chaAvailable = Avail;
}

string Equipment::getEqType (void)
{
	return strEquipType;
}

string Equipment::getEqCond (void)
{
	return strCondition;
}

char Equipment::getEqAvail (void)
{
	return chaAvailable;
}