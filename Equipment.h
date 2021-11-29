#pragma once
#include <iostream>
#include <string.h>
#include "Technician.h"


using namespace std;


class Equipment 
{
private:
	string strEquipType;
	string strCondition;
	char chaAvailable;
	Technician techName;
	
public:
	Equipment(void);
	~Equipment(void);
};

